using FireProductManager.ServiceLogicPackage;
using System;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*';
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            //获取用户名和密码
            String account = tb_account.Text;
            String password = tb_password.Text;

            if (AccountManager.Login(account, password))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                lab_tip.Text = "登陆失败，请重新输入";
            tb_account.Text = "";
            tb_password.Text = "";
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
