using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class AddOrUpdateAministrator : Form
    {
        int accountid;

        //修改管理员信息
        public AddOrUpdateAministrator(int accountId,string account,string password,int authority)
        {
            InitializeComponent();
            TextBoxVisibleIsFalse();
            btn_add.Visible = false;
            btn_update.Visible = true;
            la_title.Text = "修改管理员信息";
            accountid = accountId;
            tb_account.Text = account;
            tb_password.Text = password;
            cb_authority.Text = authority.ToString();
        }

        //添加管理员信息
        public AddOrUpdateAministrator()
        {
            InitializeComponent();
            TextBoxVisibleIsFalse();
            btn_add.Visible = true;
            btn_update.Visible = false;
            la_title.Text = "添加管理员信息";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            TextBoxVisibleIsFalse();
            if (!TextBoxCheck())
                return;
            AccountManager.UpdateAccount(accountid, tb_account.Text, tb_password.Text, int.Parse(cb_authority.Text));
            AutoClosingMessageBox.Show("                修改成功", "修改管理员", 1000);
            EmptyTextBox();
        }

        private void EmptyTextBox()
        {
            tb_account.Text = "";
            tb_password.Text = "";
            cb_authority.Text = "";
        }

        //表单验证
        private bool TextBoxCheck()
        {
            bool validation = true;
            if (tb_account.Text == "")
            {
                la_accountcheck.Visible = true;
                validation = false;
            }
            else la_accountcheck.Visible = false;
            if (tb_password.Text == "")
            {
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
            return validation;
        }

        private void TextBoxVisibleIsFalse()
        {
            la_accountcheck.Visible = false;
            la_authoritycheck.Visible = false;
            la_passwordcheck.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TextBoxVisibleIsFalse();
            if (!TextBoxCheck())
                return;
            AccountManager.AddAccount(tb_account.Text, tb_password.Text, int.Parse(cb_authority.Text));
            AutoClosingMessageBox.Show("                添加成功", "添加管理员", 1000);
            EmptyTextBox();
        }
    }
}
