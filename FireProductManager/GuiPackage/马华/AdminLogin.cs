using FireProductManager.EntityPackage;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    public partial class AdminLogin : Form, LoginIDataDisplayer
    {
        delegate void AccountDataHandler(Fingerprint fingerprint);
        ConnectFingerprint connectFingerprint = ConnectFingerprint.GetInstance();
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void tb_password_TextChanged(object sender, EventArgs e) => tb_password.PasswordChar = '*';

        private void but_login_Click(object sender, EventArgs e)
        {
            //获取用户名和密码
            String account = tb_account.Text;
            String password = tb_password.Text;

            if (AccountManager.Login(account, password) && account != "" && password != "")
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                lab_tip.Text = "*登陆失败，请重新登录";
            tb_account.Text = "";
            tb_password.Text = "";
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            //try { connectFingerprint.GetIPConnect(); }
            //catch (Exception)
            //{
            //    MessageBox.Show("无法连接到进库指纹设备");
            //    Application.Exit();
            //}

            //connectFingerprint.AddDisplayer(this);
        }

        public void FingerprintLogin(Fingerprint fingerprint)
        {
            if(IsHandleCreated)
            Invoke(new AccountDataHandler(LoginAccount), new object[] { fingerprint });
        }

        private void LoginAccount(Fingerprint fingerprint)
        {
            if (AccountManager.IsAccountNumberValid(fingerprint.fi_accountNumber))
            {
                if (AccountManager.CanNotLogin())
                {
                    lab_tip.Text = "*用户权限不足无法登录";
                    return;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                lab_tip.Text = "*登陆失败，请重新登录";
        }
    }
}
