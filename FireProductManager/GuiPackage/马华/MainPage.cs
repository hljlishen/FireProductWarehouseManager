using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class MainPage : Form
    {
        delegate void TempHumiHandler(double temp, double humi);
        delegate void WeightGettedHandler(double weight);
        Ahdr ahdr;
        PackageBorrowRecord packageBorrowRecord = null;
        ListViewItem listView = new ListViewItem();
        EmployeeManagement selectEmployees;
        ProjectManageme selectProject;
        EvirmentRecordGateway erg;

        int employeeid = 0;
        int packageid = 0;
        int projectid = 0;
        int outid = 0;
        double consumption = 0;
        bool isPrint = false;
        string accountname = AccountManager.ReturnAccount();

        public MainPage()
        {
            InitializeComponent();
            TextBoxCheckShow();
            StartPosition = FormStartPosition.CenterScreen;
            ShowDataGridView(PackageGateway.StatisticAllModelWeightsInWarehouse());
            erg = new EvirmentRecordGateway(Apem5900.CreateInstance());
            erg.NewEvirmentData += NewEvirmentData;
            instanceCount++;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void NewEvirmentData(double temp, double humi)
        {
            if (IsHandleCreated)
                Invoke(new TempHumiHandler(ShowTempAndHumiDate), new object[] { temp, humi });
        }

        private void ShowTempAndHumiDate(double temp, double humi)
        {
            Tem_num.Text = temp.ToString()+ "℃";
            Hum_num.Text = humi.ToString() + "％";
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
                tb_packagename.Text = dr["pa_type"].ToString();
                tb_packagemodel.Text = dr["pa_specifications"].ToString();
                tb_packageweight.Text = dr["pa_weight"].ToString();
                tb_barrelid.Text = dr["pa_barrelId"].ToString();
            }

            tb_direction.Text = "出库";
            RecordPackageOutboundInformation();
        }


        private void RecordPackageOutboundInformation()
        {
            TextBoxCheckShow();
            if (!TextBoxCheck())
                return;

            if (tb_projectpassword.Text == "")
            {
                DialogResult result = MessageBox.Show("不选择项目令号", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result != DialogResult.OK)
                    return;
            }
            RecordOperationGateway.BorrowPackage(packageid, employeeid, projectid, tb_borrowName.Text, accountname, double.Parse(tb_packageweight.Text));
            ListViewShow();
            AutoClosingMessageBox.Show("                出库成功", "出库", 2000);
            EmptyTextBox();
        }

        private void PackagePutInStorageShow()
        {
            ahdr = new Ahdr();
            foreach (DataRow dr in PackageGateway.GetPackageInformation(packageid).Rows)
            {
                tb_packagename.Text = dr["pa_type"].ToString();
                tb_packagemodel.Text = dr["pa_specifications"].ToString();
                if (tb_packageweight.Text != "")
                    consumption = (double)dr["pa_weight"] - double.Parse(tb_packageweight.Text);
            }

            tb_barrelid.Text = BarrelGateway.SearchShortweightBarrrelId().ToString();
            ahdr.WeightGetted += Ahdr_WeightGetted;
            tb_direction.Text = "入库";

            foreach (DataRow dr in RecordOperationGateway.ThroughPackageIdQueryoutrecord(packageid).Rows)
            {
                outid = (int)dr["or_id"];
                tb_borrowName.Text = dr["or_borrowName"].ToString();
                projectid =(int) dr["or_projectId"];
            }

            foreach (DataRow dr in RecordOperationGateway.ThroughProjectIdQuery(projectid).Rows)
                tb_projectpassword.Text = dr["pr_projectPassword"].ToString();

            RecordPackagePutInStorageInformation();
        }

        private void RecordPackagePutInStorageInformation()
        {
            TextBoxCheckShow();
            if (!TextBoxCheck())
                return;

            if (isPrint)
                PrintAfterBagChange();
            RecordOperationGateway.ReturnPackage(outid,packageid, int.Parse(tb_barrelid.Text), accountname , consumption, double.Parse(tb_packageweight.Text));
            ListViewShow();
            AutoClosingMessageBox.Show("                入库成功", "入库", 2000);
            EmptyTextBox();
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
            tb_projectpassword.Text = "";
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
            listView.SubItems.Add(tb_projectpassword.Text);
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

        private void btn_projectPassword_Click(object sender, EventArgs e)
        {
            selectProject = new ProjectManageme();
            selectProject.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectProject.ProjectSelecteds += ProjectSelected;
            selectProject.ShowDialog();
            selectProject.ProjectSelecteds -= ProjectSelected;
        }

        private void ProjectSelected(int id, string projectPassword)
        {
            tb_projectpassword.Text = "";
            tb_projectpassword.Text = projectPassword;
            projectid = id;
            RecordPackageOutboundInformation();
        }

        //余量提醒
        private void ShowDataGridView(Dictionary<string, double> dicDep)
        {
            dgv_AllowanceRemind.Rows.Clear();
            DataTable dt = new DataTable();
            foreach (var colName in dicDep.Keys)
                dt.Columns.Add(colName, typeof(string));
            DataRow dr = dt.NewRow();
            foreach (KeyValuePair<string, double> item in dicDep)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_AllowanceRemind.Rows.Add(row);
                dgv_AllowanceRemind.Rows[index].Cells[0].Value = item.Key;
                dgv_AllowanceRemind.Rows[index].Cells[1].Value = item.Value + "g";
            }
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            erg.NewEvirmentData -= NewEvirmentData;
        }

        private void tb_packageid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
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
                    AutoClosingMessageBox.Show("                袋子不存在", "袋子不存在", 2000);
                    EmptyTextBox();
                    return;
                }
                InOrOutInformationShow();
            }
        }
    }
}
