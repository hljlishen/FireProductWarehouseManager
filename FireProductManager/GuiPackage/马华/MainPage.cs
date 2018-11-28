using FireProductManager.EntityPackage;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    public partial class MainPage : Form
    {
        PackageBorrowRecord packageBorrowRecord = null;
        QueryBarrel queryBarrel;

        int employeeid = 0;//员工怎么获取
        int packageId = 0;

        public MainPage()
        {
            InitializeComponent();
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

            Ahdr ahdr = new Ahdr();
            ahdr.WeightGetted += Ahdr_WeightGetted;
        }

        private void btn_selectbarrelid_Click(object sender, EventArgs e)
        {
            queryBarrel = new QueryBarrel();
            queryBarrel.FormBorderStyle = FormBorderStyle.FixedSingle;
            queryBarrel.BarrelIdSelected += BarrelIdSelected;
            queryBarrel.ShowDialog();
            queryBarrel.BarrelIdSelected -= BarrelIdSelected;
        }

        private void BarrelIdSelected(int barrelId)
        {
            tb_barrelid.Text = "";
            tb_barrelid.Text = barrelId.ToString();
        }

        private void Ahdr_WeightGetted(double weigh)
        {
            tb_packageweight.Text = weigh.ToString ();
        }

        private void InOrOutInformationShow()
        {
            if (tb_packageid.Text == "")
                return;

            string accountname = AccountManager.ReturnAccount();

            if (RecordOperationGateway.IsinWarehouse(packageId) == 0)
            {
                foreach (DataRow dr in PackageGateway.GetPackageInformation(packageId).Rows)
                {
                    tb_packagename.Text = dr["pa_name"].ToString();
                    tb_packagemodel.Text = dr["pa_model"].ToString();
                    tb_packageweight.Text = dr["pa_weight"].ToString();
                    tb_barrelid.Text = dr["pa_barrelId"].ToString();
                    tb_projectid.Text = dr["pa_projectId"].ToString();
                }

                tb_direction.Text = "出库";
                RecordOperationGateway.BorrowPackage(packageId, employeeid, int.Parse(tb_projectid.Text), tb_borrowName.Text, accountname);
            }
            else
            {
                foreach (DataRow dr in PackageGateway.GetPackageInformation(packageId).Rows)
                {
                    tb_packagename.Text = dr["pa_name"].ToString();
                    tb_packagemodel.Text = dr["pa_model"].ToString();
                    tb_packageweight.Text = dr["pa_weight"].ToString();
                    tb_projectid.Text = dr["pa_projectId"].ToString();
                }

                tb_barrelid.Text = "6";
                tb_direction.Text = " 入库";
                RecordOperationGateway.ReturnPackage(packageId, int.Parse(tb_barrelid.Text), employeeid, int.Parse(tb_projectid.Text), tb_borrowName.Text, accountname);
            }
        }

        private void tb_packageid_TextChanged(object sender, EventArgs e)
        {
            packageId = int.Parse(tb_packageid.Text);
            if (!RecordOperationGateway.IsPackageIdValid(packageId)) return;
            InOrOutInformationShow();
        }
    }
}
