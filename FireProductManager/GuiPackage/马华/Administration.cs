using FireProductManager.EntityPackage;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

//管理员主页面

namespace FireProductManager.GuiPackage
{
    public partial class Administration : Form
    {
        private PackageBorrowRecord packageBorrow = null;
        private BarrelManagement barrelManagement = null;
        private AddOrUpdateAdministratorManagement administratorManagement = null;

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
            //仓库管理ToolStripMenuItem_Click(sender, e);
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
            if (barrelManagement == null)
            {
                barrelManagement = new BarrelManagement();
            }
            else
            {
                barrelManagement.Close();
                barrelManagement = new BarrelManagement();
            }
            barrelManagement.MdiParent = this;
            barrelManagement.Show();
            barrelManagement.Activate();
        }

        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AccountManager.CanWriteDatabase())
            {
                AutoClosingMessageBox.Show("          用户权限级别不足", "权限", 1000);
                return;
            }
            
            if (administratorManagement == null)
            {
                administratorManagement = new AddOrUpdateAdministratorManagement();
            }
            else
            {
                administratorManagement.Close();
                administratorManagement = new AddOrUpdateAdministratorManagement();
            }
            administratorManagement.MdiParent = this;
            administratorManagement.Show();
            administratorManagement.Activate();
        }
    }
}
