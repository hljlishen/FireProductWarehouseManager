using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class MainPage : Form
    {
        delegate void WeightGettedHandler(double weight);
        Ahdr ahdr = new Ahdr();
        PackageBorrowRecord packageBorrowRecord = null;
        ListViewItem listView = new ListViewItem();
        EmployeeManagement selectEmployees;

        int employeeid = 0;
        int packageid = 0;
        bool isPrint = false;
        string accountname = AccountManager.ReturnAccount();

        public MainPage()
        {
            InitializeComponent();
            TextBoxCheckShow();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void PackageIdSelected(int packageId)
        {
            packageid = packageId;
            if (RecordOperationGateway.IsinWarehouse(packageid))
                return;
            tb_packageid.Text = packageId.ToString();
            isPrint = true;
        }

        //换袋后打印二维码
        private void PrintAfterBagChange()
        {
            PrintQRCode printQRCode = new PrintQRCode(packageid);
            isPrint = false;
        }

        private void Ahdr_WeightGetted(double weight) => Invoke(new WeightGettedHandler(UpdateWeight), new object[] { weight });

        private void UpdateWeight(double weight)
        {
            tb_packageweight.Text = weight.ToString();
            RecordPackagePutInStorageInformation();
        }

        private void InOrOutInformationShow()
        {
            if (RecordOperationGateway.IsinWarehouse(packageid))
                PackageOutboundShow();
            else
                PackagePutInStorageShow();
        }

        private void PackageOutboundShow()
        {
            foreach (DataRow dr in PackageGateway.GetPackageInformation(packageid).Rows)
            {
                tb_packagename.Text = dr["pa_name"].ToString();
                tb_packagemodel.Text = dr["pa_model"].ToString();
                tb_packageweight.Text = dr["pa_weight"].ToString();
                tb_barrelid.Text = dr["pa_barrelId"].ToString();
                tb_projectid.Text = dr["pa_projectId"].ToString();
            }
            tb_direction.Text = "出库";
            RecordPackageOutboundInformation();
        }

        private void RecordPackageOutboundInformation()
        {
            TextBoxCheckShow();
            if (!TextBoxCheck())
                return;

            if (isPrint)
                PrintAfterBagChange();
            RecordOperationGateway.BorrowPackage(packageid, employeeid, int.Parse(tb_projectid.Text), tb_borrowName.Text, accountname);
            ListViewShow();
            AutoClosingMessageBox.Show("                出库成功", "出库", 1000);
            EmptyTextBox();
        }

        private void PackagePutInStorageShow()
        {
            foreach (DataRow dr in PackageGateway.GetPackageInformation(packageid).Rows)
            {
                tb_packagename.Text = dr["pa_name"].ToString();
                tb_packagemodel.Text = dr["pa_model"].ToString();
            }

            foreach (DataRow dr in RecordOperationGateway.ThroughPackageIdQueryinoutrecord(packageid).Rows)
            {
                tb_projectid.Text = dr["ior_projectId"].ToString();
                tb_borrowName.Text = dr["ior_borrowName"].ToString();
            }

            tb_barrelid.Text = BarrelGateway.SearchShortweightBarrrelId().ToString();
            ahdr.WeightGetted += Ahdr_WeightGetted;
            tb_direction.Text = "入库";
            RecordPackagePutInStorageInformation();
        }

        private void RecordPackagePutInStorageInformation()
        {
            TextBoxCheckShow();
            if (!TextBoxCheck())
                return;

            if (isPrint)
                PrintAfterBagChange();
            RecordOperationGateway.ReturnPackage(packageid, int.Parse(tb_barrelid.Text), employeeid, int.Parse(tb_projectid.Text), tb_borrowName.Text, accountname,double.Parse(tb_packageweight.Text));
            ListViewShow();
            AutoClosingMessageBox.Show("                入库成功", "入库", 1000);
            EmptyTextBox();
        }

        private void tb_packageid_TextChanged(object sender, EventArgs e)
        {
            TextBoxCheck();
            TextBoxCheckShow();
            if (tb_packageid.Text == "")
            {
                EmptyTextBox();
                return;
            }
            packageid = int.Parse(tb_packageid.Text);
            if (!RecordOperationGateway.IsPackageIdValid(packageid))
            {
                AutoClosingMessageBox.Show("                袋子不存在", "袋子不存在", 1000);
                EmptyTextBox();
                return;
            }
            InOrOutInformationShow();
        }

        //表单验证
        private bool TextBoxCheck()
        {
            bool validation = true;
            if (tb_packageweight.Text == "")
            {
                la_packagewigth.Visible = true;
                validation = false;
            }
            else la_packagewigth.Visible = false;
            if (tb_borrowName.Text == "")
            {
                la_borrow.Visible = true;
                validation = false;
            }
            else la_borrow.Visible = false;
            return validation;
        }

        private void TextBoxCheckShow()
        {
            la_packagewigth.Visible = false;
            la_borrow.Visible = false;
        }

        private void EmptyTextBox()
        {
            tb_packagename.Text = "";
            tb_barrelid.Text = "";
            tb_packagemodel.Text = "";
            tb_projectid.Text = "";
            tb_packageweight.Text = "";
            tb_direction.Text = "";
            tb_borrowName.Text = "";
            tb_packageid.Text = "";
        }

        private void ListViewShow()
        {
            listView = lv_inoroutrecord.Items.Add((lv_inoroutrecord.Items.Count + 1).ToString());
            listView.SubItems.Add(tb_packagename.Text);
            listView.SubItems.Add(tb_packagemodel.Text);
            listView.SubItems.Add(tb_packageweight.Text);
            listView.SubItems.Add(tb_barrelid.Text);
            listView.SubItems.Add("");
            listView.SubItems.Add(tb_direction.Text);
            listView.SubItems.Add(DateTime.Now.ToString());
            listView.SubItems.Add(tb_borrowName.Text);
            lv_inoroutrecord.EnsureVisible(lv_inoroutrecord.Items.Count - 1);
        }

        private void btn_Empty_Click(object sender, EventArgs e) => lv_inoroutrecord.Items.Clear();

        private void btn_borrowemployee_Click(object sender, EventArgs e)
        {
            selectEmployees = new EmployeeManagement();
            selectEmployees.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectEmployees.EmployeesSelected += EmployeesSelected;
            selectEmployees.ShowDialog();
            selectEmployees.EmployeesSelected -= EmployeesSelected;
        }

        private void EmployeesSelected(int employeesId, string emNumbers, string name)
        {
            tb_borrowName.Text = "";
            tb_borrowName.Text = name.ToString();
            employeeid = employeesId;
            RecordPackageOutboundInformation();
        }

        private void btn_packageid_Click(object sender, EventArgs e)
        {
            EmptyTextBox();
            packageBorrowRecord = new PackageBorrowRecord();
            packageBorrowRecord.FormBorderStyle = FormBorderStyle.FixedSingle;
            packageBorrowRecord.PackageIdSelected += PackageIdSelected;
            packageBorrowRecord.ShowDialog();
            packageBorrowRecord.PackageIdSelected -= PackageIdSelected;
        }
    }
}
