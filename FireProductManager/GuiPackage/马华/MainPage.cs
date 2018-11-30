using FireProductManager.EntityPackage;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class MainPage : Form
    {
        Ahdr ahdr = new Ahdr();
        PackageBorrowRecord packageBorrowRecord = null;
        ListViewItem listView = new ListViewItem();

        int employeeid = 0;//员工怎么获取
        int packageId = 0;
        string weighs = "";

        public MainPage()
        {
            InitializeComponent();
            TextBoxCheckShow();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            packageBorrowRecord = new PackageBorrowRecord();
            panel1.Dock = DockStyle.Bottom;
            packageBorrowRecord.TopLevel = false;
            packageBorrowRecord.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(packageBorrowRecord);
            packageBorrowRecord.Show();

            packageBorrowRecord.PackageIdSelected += PackageIdSelected;

            ahdr.WeightGetted += Ahdr_WeightGetted;
        }

        private void PackageIdSelected(int packageId)
        {
            tb_packageid.Text = packageId.ToString();
        }

        private void Ahdr_WeightGetted(double weigh)//？？无效
        {
            tb_packageweight.Text = weigh.ToString();
        }

        private void InOrOutInformationShow()
        {
            string accountname = AccountManager.ReturnAccount();

            if (RecordOperationGateway.IsinWarehouse(packageId))
            {
                foreach (DataRow dr in PackageGateway.GetPackageInformation(packageId).Rows)
                {
                    tb_packagename.Text = dr["pa_name"].ToString();
                    tb_packagemodel.Text = dr["pa_model"].ToString();
                    tb_packageweight.Text = dr["pa_weight"].ToString();
                    tb_barrelid.Text = dr["pa_barrelId"].ToString();
                }

                tb_borrowName.Text = "1";
                tb_direction.Text = "出库";

                TextBoxCheckShow();
                if (!TextBoxCheck())
                    return;

                RecordOperationGateway.BorrowPackage(packageId, employeeid, int.Parse(tb_projectid.Text), tb_borrowName.Text, accountname);
                ListViewShow();
                AutoClosingMessageBox.Show("                出库成功", "出库", 1000);
                EmptyTextBox();
            }
            else
            {
                foreach (DataRow dr in PackageGateway.GetPackageInformation(packageId).Rows)
                {
                    tb_packagename.Text = dr["pa_name"].ToString();
                    tb_packagemodel.Text = dr["pa_model"].ToString();
                }

                foreach (DataRow dr in RecordOperationGateway.ThroughPackageIdQueryinoutrecord(packageId).Rows)
                {
                    tb_projectid.Text = dr["ior_projectId"].ToString();
                    tb_borrowName.Text = dr["ior_borrowName"].ToString();
                }
                    
                tb_barrelid.Text = BarrelGateway.SearchShortweightBarrrelId().ToString();
                tb_direction.Text = " 入库";

                TextBoxCheckShow();
                if (!TextBoxCheck())
                    return;

                RecordOperationGateway.ReturnPackage(packageId, int.Parse(tb_barrelid.Text), employeeid, int.Parse(tb_projectid.Text), tb_borrowName.Text, accountname);
                ListViewShow();
                AutoClosingMessageBox.Show("                入库成功", "入库", 1000);
                EmptyTextBox();
            }
        }

        private void tb_packageid_TextChanged(object sender, EventArgs e)
        {
            TextBoxCheck();
            if (tb_packageid.Text == "")
                return;
            packageId = int.Parse(tb_packageid.Text);
            if (!RecordOperationGateway.IsPackageIdValid(packageId))
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
            if (tb_projectid.Text == "")
            {
                la_projectid.Visible = true;
                validation = false;
            }
            else la_projectid.Visible = false;
            if (tb_packageweight.Text == "")
            {
                la_packagewigth.Visible = true;
                validation = false;
            }
            else la_packagewigth.Visible = false;
            return validation;
        }

        private void TextBoxCheckShow()
        {
            la_projectid.Visible = false;
            la_packagewigth.Visible = false;
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
            listView.SubItems.Add(tb_barrelid.Text);
            listView.SubItems.Add(tb_direction.Text);
            listView.SubItems.Add(DateTime.Now.ToString());
            listView.SubItems.Add(tb_borrowName.Text);
            lv_inoroutrecord.EnsureVisible(lv_inoroutrecord.Items.Count - 1);
        }

        private void btn_Empty_Click(object sender, EventArgs e)
        {
            lv_inoroutrecord.Items.Clear();
        }
    }
}
