using FireProductManager.ServiceLogicPackage;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class AddOrUpdateAministrator : Form
    {
        public delegate void RefreshDataHandler();
        public event RefreshDataHandler RefreshData;
        int accountid;
        LiveDevice liveDevice;
        ConnectFingerprint connectFingerprint = ConnectFingerprint.GetInstance();
        ConnectFingerprint2 connectFingerprint2 = ConnectFingerprint2.GetInstance();
        string str = "";

        //修改管理员信息
        public AddOrUpdateAministrator(int accountId,string account,string name,string password,int authority)
        {
            InitializeComponent();
            TextBoxVisibleIsFalse();
            btn_add.Visible = false;
            btn_update.Visible = true;
            la_title.Text = "修改管理员信息";
            accountid = accountId;
            tb_accountnumber.Text = account;
            tb_accountnumber.ReadOnly = true;
            tb_name.Text = name;
            tb_password.Text = password;
            if(authority == 1)
                cb_authority.Text = "1(超级管理员)";
            else if(authority == 2)
                cb_authority.Text = "2(普通管理员)";
            else if (authority == 3)
                cb_authority.Text = "3(其他人员)";
        }

        private void FingerprintData(Bitmap bmp,string picString)
        {
            picFPImg.Image = bmp;

            str = picString;
        }

        //添加管理员信息
        public AddOrUpdateAministrator()
        {
            InitializeComponent();
            liveDevice = Live.CreateInstance(Handle);
            liveDevice.Open();
            TextBoxVisibleIsFalse();
            btn_add.Visible = true;
            btn_update.Visible = false;
            la_title.Text = "添加管理员信息";
            liveDevice.FingerprintData += FingerprintData;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            TextBoxVisibleIsFalse();
            if (!TextBoxCheck())
                return;
            AccountManager.UpdateAccount(accountid, tb_accountnumber.Text, tb_name.Text ,tb_password.Text, AccountAuthority());
            AutoClosingMessageBox.Show("                修改成功", "修改管理员", 1000);
            EmptyTextBox();
            RefreshData?.Invoke();
        }

        private void EmptyTextBox()
        {
            tb_accountnumber.Text = "";
            tb_name.Text = "";
            tb_password.Text = "";
            cb_authority.Text = "";
            picFPImg.Image = null;
        }

        //表单验证
        private bool TextBoxCheck()
        {
            bool validation = true;
            if (tb_accountnumber.Text == "")
            {
                la_accountcheck.Visible = true;
                validation = false;
            }
            else la_accountcheck.Visible = false;
            if (tb_name.Text == "")
            {
                la_namecheck.Visible = true;
                validation = false;
            }
            else la_namecheck.Visible = false;
            if (tb_password.Text == "")
            {
                if (cb_authority.Text == "3(其他人员)")
                    return true;
                la_passwordcheck.Visible = true;
                validation = false;
            }
            else la_passwordcheck.Visible = false;
            if (cb_authority.Text == "")
            {
                la_authoritycheck.Visible = true;
                validation = false;
            }   
            else la_passwordcheck.Visible = false;
            if (picFPImg.Image == null)
            {
                la_fin.Visible = true;
                validation = false;
            }
            else la_fin.Visible = false;
            return validation;
        }

        private void TextBoxVisibleIsFalse()
        {
            la_accountcheck.Visible = false;
            la_namecheck.Visible = false;
            la_authoritycheck.Visible = false;
            la_passwordcheck.Visible = false;
            la_accountnumber.Visible = false;
            la_fin.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TextBoxVisibleIsFalse();
            if (!TextBoxCheck())
                return;
            if (!IsExistAccountNumber(tb_accountnumber.Text))
                return;

            if (!connectFingerprint.IsConnectionFingerprint() || !connectFingerprint2.IsConnectionFingerprint())
            {
                AutoClosingMessageBox.Show("                添加失败", "添加管理员", 1000);
                return;
            }
            connectFingerprint.UploadUserInformation(tb_accountnumber.Text, tb_name.Text, tb_password.Text, str);
            connectFingerprint2.UploadUserInformation(tb_accountnumber.Text, tb_name.Text, tb_password.Text, str);
            AccountManager.AddAccount(tb_accountnumber.Text, tb_name.Text ,tb_password.Text, AccountAuthority());
            AutoClosingMessageBox.Show("                添加成功", "添加管理员", 1000);
            EmptyTextBox();
            RefreshData?.Invoke();
        }

        private int AccountAuthority()
        {
            if (cb_authority.Text == "1(超级管理员)")
                return 1;
            else if(cb_authority.Text == "2(普通管理员)")
                return 2;
            return 3;
        }

        //只能输入数字
        private void tb_accountnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar <= 31))
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
                else
                    e.Handled = true;
            }
            else
            {
                if (e.KeyChar <= 31)
                {
                    e.Handled = false;
                }
                else if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    if (((TextBox)sender).Text.ToString() != "")
                    {
                        if (Convert.ToDouble(((TextBox)sender).Text) == 0)
                        {
                            if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                e.Handled = true;
                            }
                        }
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
        }

        //判断管理员编号是否存在
        private bool IsExistAccountNumber(string accountNumber)
        {
            if (AccountManager.IsAccountNumberValid(accountNumber))
            {
                la_accountnumber.Visible = true;
                return false;
            }
            la_accountnumber.Visible = false;
            return true;
        }

        private void cb_authority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_authority.Text == "3(其他人员)")
            {
                tb_password.Enabled = false;
                tb_password.Text = "";
            }
            else if(cb_authority.Text == "1(超级管理员)" || cb_authority.Text == "2(普通管理员)")
                tb_password.Enabled = true;
        }

        private void AddOrUpdateAministrator_Load(object sender, EventArgs e)
        {
            //byte[] byteArray = System.Text.Encoding.Default.GetBytes(connectFingerprint.GetFingerprintTemplate("2", 6));

            //改变图片形状
            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(picFPImg.ClientRectangle);

            Region region = new Region(gp);

            picFPImg.Region = region;
        }
    }
}
