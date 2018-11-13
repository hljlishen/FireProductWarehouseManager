using FireProductManager.EntityPackage;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Windows.Forms;

//管理员主页面

namespace FireProductManager.GuiPackage
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            AccountManager.Logout();
            ShowLoginWindow();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            ShowLoginWindow();
        }

        private void ShowLoginWindow()
        {
            AdminLogin login = new AdminLogin();
            if (login.ShowDialog() != DialogResult.OK)
                Close();
        }
    }
}
