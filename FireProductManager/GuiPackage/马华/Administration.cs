using FireProductManager.EntityPackage;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

//管理员主页面

namespace FireProductManager.GuiPackage
{
    public partial class Administration : Form, LogoutIDataDisplayer
    {
        delegate void AccountDataHandler(Fingerprint fingerprint);
        private PackageBorrowRecord packageBorrow = null;
        private BarrelManagement barrelManagement = null;
        private EmployeeManagement employeeManagement = null;
        private AdministratorManagement administratorManagement = null;
        private PackageManagement packageManagement = null;
        private MainPage mainPage = null;
        private AdminLogin login = null;
        private ProjectManageme projectManageme = null;
        private WarehouseDataReport warehouseDataReport = null;
        ConnectFingerprint2 connectFingerprint = ConnectFingerprint2.GetInstance();
        bool isLogout = false;

        public Administration()
        {
            InitializeComponent();
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employeeManagement == null)
            {
                employeeManagement = new EmployeeManagement();
            }
            else
            {
                employeeManagement.Close();
                employeeManagement = new EmployeeManagement();
            }
            employeeManagement.MdiParent = this;
            employeeManagement.Show();
            employeeManagement.Activate();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Text = "";
            AccountManager.Logout();
            isLogout = true;
            出入库登记ToolStripMenultem_Click(sender,e);
            ShowLoginWindow();
            this.Text = "当前登录的管理员为：" + AccountManager.ReturnAccount();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            connectFingerprint.GetIPConnect();
            connectFingerprint.AddDisplayer(this);
            ShowLoginWindow();
            this.Text ="当前登录的管理员为：" + AccountManager.ReturnAccount();
            出入库登记ToolStripMenultem_Click(sender, e);
        }

        private void ShowLoginWindow()
        {
            login = new AdminLogin();
            if (login.ShowDialog() != DialogResult.OK)
                Close();
            isLogout = false;
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

        public void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AccountManager.CanWriteDatabase())
            {
                AutoClosingMessageBox.Show("          用户权限级别不足", "权限", 1000);
                return;
            }
            
            if (administratorManagement == null)
            {
                administratorManagement = new AdministratorManagement();
            }
            else
            {
                administratorManagement.Close();
                administratorManagement = new AdministratorManagement();
            }
            administratorManagement = new AdministratorManagement
            {
                MdiParent = this
            };
            administratorManagement.Show();
            administratorManagement.Activate();
        }

        private void 锂合金材料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (packageManagement == null)
            {
                packageManagement = new PackageManagement();
            }
            else
            {
                packageManagement.Close();
                packageManagement = new PackageManagement();
            }
            packageManagement.MdiParent = this;
            packageManagement.Show();
            packageManagement.Activate();
        }

        private void 出入库登记ToolStripMenultem_Click(object sender, EventArgs e)
        {
            //if (mainPage == null)
            //{
            //    mainPage = new MainPage();
            //}
            //else
            //{
            //    mainPage.Close();
            //    mainPage.Dispose();
            //    GC.Collect();
            //    mainPage = new MainPage();
            //}
            //mainPage?.Dispose();
            mainPage = new MainPage();
            GC.Collect();
            mainPage.MdiParent = this;
            mainPage.Show();
            mainPage.Activate();
        }

        private void 项目令号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (projectManageme == null)
            {
                projectManageme = new ProjectManageme();
            }
            else
            {
                projectManageme.Close();
                projectManageme = new ProjectManageme();
            }
            projectManageme.MdiParent = this;
            projectManageme.Show();
            projectManageme.Activate();
        }

        private void 仓库数据统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (warehouseDataReport == null)
            {
                warehouseDataReport = new WarehouseDataReport();
            }
            else
            {
                warehouseDataReport.Close();
                warehouseDataReport = new WarehouseDataReport();
            }
            warehouseDataReport.MdiParent = this;
            warehouseDataReport.Show();
            warehouseDataReport.Activate();
        }

        public void FingerprintLogout(Fingerprint fingerprint)
        {
            Invoke(new AccountDataHandler(LogoutAccount), new object[] { fingerprint });
        }

        private void LogoutAccount(Fingerprint fingerprint)
        {
            if (AccountManager.CanNotLogout(fingerprint.fi_accountNumber))
                return;
            if (isLogout)
                return;
            object sender = null ;
            EventArgs e = null;
            this.Text = "";
            AccountManager.Logout();
            isLogout = true;
            出入库登记ToolStripMenultem_Click(sender, e);
            ShowLoginWindow();
            this.Text = "当前登录的管理员为：" + AccountManager.ReturnAccount();
        }
    }
}
