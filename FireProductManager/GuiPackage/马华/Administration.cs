using FireProductManager.EntityPackage;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Windows.Forms;

//管理员主页面

namespace FireProductManager.GuiPackage
{
    public partial class Administration : Form
    {
        private PackageBorrowRecord packageBorrow = null;

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

        private void button1_Click(object sender, EventArgs e)
        {
            BarrelGateway.RecordNewBarrel();
        }

        private void 锂合金ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (packageBorrow == null)
            {
                packageBorrow = new PackageBorrowRecord();
            }
            else
            {
                packageBorrow.Close();
                packageBorrow = new PackageBorrowRecord();
            }
            packageBorrow.MdiParent = this;
            packageBorrow.Show();
            packageBorrow.Activate();
        }

        private void 仓库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarrelManagement barrelManagement = new BarrelManagement();
            barrelManagement.Show();
        }
    }
}
