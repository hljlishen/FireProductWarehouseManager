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
            BackgroundNavigationBar();
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
            员工管理ToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            employeeManagement.Activate();
        }

        private void btn_logout_Click(object sender, EventArgs e) => Logout(sender, e);

        private void Administration_Load(object sender, EventArgs e)
        {
            //try { connectFingerprint.GetIPConnect(); }
            //catch (Exception)
            //{
            //    MessageBox.Show("无法连接到出库指纹设备");
            //    Application.Exit();
            //}

            //connectFingerprint.AddDisplayer(this);
            ShowLoginWindow();
            this.Text ="当前登录的管理员为：" + AccountManager.ReturnAccount() +"    "+ "锂带仓管1.0";
            出入库登记ToolStripMenultem_Click(sender, e);
        }

        private void ShowLoginWindow()
        {
            login = new AdminLogin();
            if (login.ShowDialog() != DialogResult.OK)
                Close();
            isLogout = false;
        }

        private void button1_Click(object sender, EventArgs e) => BarrelGateway.RecordNewBarrel();

        private void 仓库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundNavigationBar();
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
            仓库管理ToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            barrelManagement.Activate();
        }

        public void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundNavigationBar();
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
            管理员ToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            administratorManagement.Activate();
        }

        private void 出入库登记ToolStripMenultem_Click(object sender, EventArgs e)
        {
            BackgroundNavigationBar();
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

            try { mainPage.MdiParent = this; }
            catch (Exception)
            {
                Application.Exit();
            }

            mainPage.Show();
            出入库登记ToolStripMenultem.BackColor = System.Drawing.Color.DodgerBlue;
            mainPage.Activate();
        }

        private void 项目令号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundNavigationBar();
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
            项目令号ToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            projectManageme.Activate();
        }

        private void 仓库数据统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundNavigationBar();
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
            仓库数据统计ToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            warehouseDataReport.Activate();
        }

        public void FingerprintLogout(Fingerprint fingerprint) => Invoke(new AccountDataHandler(LogoutAccount), new object[] { fingerprint });

        private void LogoutAccount(Fingerprint fingerprint)
        {
            if (AccountManager.CanNotLogout(fingerprint.fi_accountNumber))
                return;
            object sender = null ;
            EventArgs e = null;
            Logout(sender, e);
        }

        private void Logout(object sender, EventArgs e)
        {
            if (isLogout)
                return;
            this.Text = "";
            AccountManager.Logout();
            isLogout = true;
            出入库登记ToolStripMenultem_Click(sender, e);
            ShowLoginWindow();
            this.Text = "当前登录的管理员为：" + AccountManager.ReturnAccount() + "    " + "锂带仓管1.0";
        }

        private void 材料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundNavigationBar();
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
            材料管理ToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            packageManagement.Activate();
        }

        private void 材料出入记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundNavigationBar();
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
            材料出入记录ToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            packageBorrow.Activate();
        }

        private void BackgroundNavigationBar()
        {
            出入库登记ToolStripMenultem.BackColor = System.Drawing.Color.White;
            员工管理ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            项目令号ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            仓库管理ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            材料管理ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            材料出入记录ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            仓库数据统计ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            管理员ToolStripMenuItem.BackColor = System.Drawing.Color.White;
        }
    }
}
