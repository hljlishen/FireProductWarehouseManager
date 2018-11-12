using System;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取用户名和密码
            String name = tb_account.Text;
            String password = tb_password.Text;
            if (name.Equals("admin") && password.Equals("admin"))
            {
                
            }
            else
            {
                AutoClosingMessageBox.Show("登陆失败", "登陆失败", 1000);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
