using DbLink;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    //仪器出入库查询页面
    public partial class PackageBorrowRecord : Form
    {
        public PackageBorrowRecord()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void PackageBorrowRecord_Load(object sender, EventArgs e)
        {
            cb_directquery.Text = "出入库";
            //选择时间查询
            cb_choicetime.MouseClick += cb_choicetime_MouseClick;

            SelectSqlMaker maker = new SelectSqlMaker("inoutrecord");
            string sql = maker.MakeSelectSql();
            ShowDataGridView(RecordOperationGateway.Query(sql)); 
        }

        //DataGridView显示数据
        private void ShowDataGridView(DataTable dt)
        {
            dgv_PackageInAndOutrecord.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_PackageInAndOutrecord.Rows.Add(row);
                dgv_PackageInAndOutrecord.Rows[index].Cells[0].Value = dr["ior_packageId"];
                dgv_PackageInAndOutrecord.Rows[index].Cells[1].Value = SelectBaeerlId((int)dr["ior_packageId"]) + "号桶";
                dgv_PackageInAndOutrecord.Rows[index].Cells[2].Value = SelectPackageName((int)dr["ior_packageId"]);
                dgv_PackageInAndOutrecord.Rows[index].Cells[3].Value = SelectPackageModel((int)dr["ior_packageId"]);
                dgv_PackageInAndOutrecord.Rows[index].Cells[4].Value = dr["ior_direction"];
                dgv_PackageInAndOutrecord.Rows[index].Cells[5].Value = dr["ior_timeStmp"];

                dgv_PackageInAndOutrecord.Rows[index].Cells[6].Value = SelectEmployeeName((int)dr["ior_employeeId"]);
                dgv_PackageInAndOutrecord.Rows[index].Cells[8].Value = SelectPackageWeigth((int)dr["ior_packageId"]) + "g";
            }
        }

        private int SelectBaeerlId(int id)
        {
            int barrelid = 0;
            foreach (DataRow dr in GetPackageIdQuerySql(id).Rows)
                barrelid = (int)dr["pa_barrelId"];
            return barrelid;
        }

        private string SelectPackageName(int id)
        {
            string packagename = null;
            foreach (DataRow dr in GetPackageIdQuerySql(id).Rows)
                packagename = dr["pa_name"].ToString();
            return packagename;
        }

        private string SelectPackageModel(int id)
        {
            string packagemodel = null;
            foreach (DataRow dr in GetPackageIdQuerySql(id).Rows)
                packagemodel = dr["pa_model"].ToString();
            return packagemodel;
        }

        private string SelectEmployeeName(int id)
        {
            return EmployeeGateway.GetEmployeeInformation(id).em_name;
        }

        private double SelectPackageWeigth(int id)
        {
            double packageweigth = 0;
            foreach (DataRow dr in GetPackageIdQuerySql(id).Rows)
                packageweigth = (double)dr["pa_weigth"];
            return packageweigth;
        }

        private DataTable GetPackageIdQuerySql(int id)
        {
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_id", id));
            string sql = maker.MakeSelectSql();
            DataTable dt = PackageGateway.Query(sql);
            return dt;
        }

        //点击勾选框选择时间查询
        private void cb_choicetime_MouseClick(object sender, MouseEventArgs e)
        {
            if (cb_choicetime.Checked.Equals(true))
            {
                dtp_begin.Enabled = true;
                dtp_end.Enabled = true;
            }
            else
            {
                dtp_begin.Enabled = false;
                dtp_end.Enabled = false;
            }
        }

        //导出Excel表
        private void btn_exceloperator_Click(object sender, EventArgs e)
        {
            ExcelOperator.DataGridViewToExcel(dgv_PackageInAndOutrecord, true);
        }
    }
}
