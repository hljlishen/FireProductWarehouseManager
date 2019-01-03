using FireProductManager.ServiceLogicPackage;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    //仪器出入库查询页面
    public partial class PackageBorrowRecord : Form
    {
        public delegate void PackageIdIdSelectedHandler(int packageid);
        public event PackageIdIdSelectedHandler PackageIdSelected;

        EmployeeManagement selectEmployees;
        PackageManagement selectPackages;
        ProjectManageme selectProject;

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
            ShowOutDataGridView(RecordOperationGateway.GetAllOutRecord());
            ShowInDataGridView(RecordOperationGateway.GetAllInRecord());
            dgv_PackageInAndOutrecord.Sort(dgv_PackageInAndOutrecord.Columns[5], ListSortDirection.Ascending);
        }

        //DataGridView显示数据
        private void ShowOutDataGridView(DataTable dt)
        {
            dgv_PackageInAndOutrecord.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_PackageInAndOutrecord.Rows.Add(row);
                dgv_PackageInAndOutrecord.Rows[index].Cells[0].Value = dr["or_packageId"];
                dgv_PackageInAndOutrecord.Rows[index].Cells[1].Value = SelectBaeerlId((int)dr["or_packageId"]) + "号桶";
                dgv_PackageInAndOutrecord.Rows[index].Cells[2].Value = SelectPackageName((int)dr["or_packageId"]);
                dgv_PackageInAndOutrecord.Rows[index].Cells[3].Value = SelectPackageModel((int)dr["or_packageId"]);
                dgv_PackageInAndOutrecord.Rows[index].Cells[4].Value = dr["or_direction"];
                dgv_PackageInAndOutrecord.Rows[index].Cells[5].Value = dr["or_timeStmp"];
                dgv_PackageInAndOutrecord.Rows[index].Cells[6].Value = dr["or_borrowName"];
                dgv_PackageInAndOutrecord.Rows[index].Cells[7].Value = SelectPorjectPassword((int)dr["or_projectId"]);
                dgv_PackageInAndOutrecord.Rows[index].Cells[8].Value = SelectPackageWeigth((int)dr["or_packageId"]) + "g";
                dgv_PackageInAndOutrecord.Rows[index].Cells[9].Value = SelectProductionCompany((int)dr["or_packageId"]);
                dgv_PackageInAndOutrecord.Rows[index].Cells[10].Value =SelectPurchaseTime((int)dr["or_packageId"]);
                dgv_PackageInAndOutrecord.Rows[index].Cells[11].Value = dr["or_accountName"];
                //dgv_PackageInAndOutrecord.Rows[index].Cells[12].Value = dr["or_projectId"];
            }
        }

        private void ShowInDataGridView(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_PackageInAndOutrecord.Rows.Add(row);
                dgv_PackageInAndOutrecord.Rows[index].Cells[0].Value = SelectOutPackageId((int)dr["ir_outid"]);
                dgv_PackageInAndOutrecord.Rows[index].Cells[1].Value = SelectBaeerlId(SelectOutPackageId((int)dr["ir_outid"])) + "号桶";
                dgv_PackageInAndOutrecord.Rows[index].Cells[2].Value = SelectPackageName(SelectOutPackageId((int)dr["ir_outid"]));
                dgv_PackageInAndOutrecord.Rows[index].Cells[3].Value = SelectPackageModel(SelectOutPackageId((int)dr["ir_outid"]));
                dgv_PackageInAndOutrecord.Rows[index].Cells[4].Value = dr["ir_direction"];
                dgv_PackageInAndOutrecord.Rows[index].Cells[5].Value = dr["ir_timeStmp"];
                dgv_PackageInAndOutrecord.Rows[index].Cells[6].Value = SelectOutBorrowName((int)dr["ir_outid"]);
                dgv_PackageInAndOutrecord.Rows[index].Cells[7].Value = SelectPorjectPassword(int.Parse(SelectOutProjectPassword((int)dr["ir_outid"])));
                dgv_PackageInAndOutrecord.Rows[index].Cells[8].Value = dr["ir_returnWeight"] + "g";
                dgv_PackageInAndOutrecord.Rows[index].Cells[9].Value = SelectProductionCompany(SelectOutPackageId((int)dr["ir_outid"]));
                dgv_PackageInAndOutrecord.Rows[index].Cells[10].Value = SelectPurchaseTime(SelectOutPackageId((int)dr["ir_outid"]));
                dgv_PackageInAndOutrecord.Rows[index].Cells[11].Value = dr["ir_accountName"];
                //dgv_PackageInAndOutrecord.Rows[index].Cells[12].Value = dr["ir_outid"];
            }
        }

        private DataRow SelectOutRecord(int id)
        {
            DataRow dataRow = null;
            foreach (DataRow dr in RecordOperationGateway.ThroughOutRecordIdQuery(id).Rows)
                dataRow = dr;
            return dataRow;
        }

        private int SelectOutPackageId(int id) => (int)SelectOutRecord(id)["or_packageId"];

        private string SelectOutBorrowName(int id) => SelectOutRecord(id)["or_borrowName"].ToString();

        private string SelectOutProjectPassword(int id) => SelectOutRecord(id)["or_projectId"].ToString();

        private DataRow SelcetInRecord(int id)
        {
            DataRow dataRow = null;
            foreach (DataRow dr in RecordOperationGateway.ThroughPackageIdQuerypackage(id).Rows)
                dataRow = dr;
            return dataRow;
        }

        private int SelectBaeerlId(int id) => (int)SelcetInRecord(id)["pa_barrelId"];

        private string SelectPackageName(int id) => SelcetInRecord(id)["pa_type"].ToString();

        private string SelectPackageModel(int id) => SelcetInRecord(id)["pa_specifications"].ToString();

        private double SelectPackageWeigth(int id) => (double)SelcetInRecord(id)["pa_weight"];

        private string SelectProductionCompany(int id) => SelcetInRecord(id)["pa_productionCompany"].ToString();

        private string SelectPurchaseTime(int id) => SelcetInRecord(id)["pa_purchaseTime"].ToString();

        private string SelectPorjectPassword(int id)
        {
            string porjectPassword = "";
            foreach (DataRow dr in RecordOperationGateway.ThroughProjectIdQuery(id).Rows)
                porjectPassword = dr["pr_projectPassword"].ToString();
            return porjectPassword;
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
        private void btn_exceloperator_Click(object sender, EventArgs e) => ExcelOperator.DataGridViewToExcel(dgv_PackageInAndOutrecord, true);

        //搜索出入库信息按钮
        private void btn_search_Click(object sender, EventArgs e)
        {
            string outid = null;
            string packageId = tb_packageid.Text;
            string employeeId = tb_employeeid.Text;
            string projectId = tb_projectid.Text;
            string direction = cb_directquery.Text;
            bool isChoiceTime = false;
            DateTime begintTime = dtp_begin.Value;
            DateTime endTime = dtp_end.Value.AddDays(1);
            if (cb_choicetime.Checked.Equals(true))
                isChoiceTime = true;

            ShowOutDataGridView(RecordOperationGateway.ConditionsSearchOutRecord(packageId, employeeId, projectId, direction, isChoiceTime, begintTime, endTime));

            foreach (DataRow dr in RecordOperationGateway.ConditionsSearchOutRecord(packageId, employeeId, projectId, direction, isChoiceTime, begintTime, endTime).Rows)
            {
                outid = dr["or_id"].ToString();
                ShowInDataGridView(RecordOperationGateway.ConditionsSearchInRecord(outid, direction, isChoiceTime, begintTime, endTime));
            }

            if (cb_directquery.Text == "入库")
            {
                foreach (DataRow dr in RecordOperationGateway.ConditionsSearchOutId(packageId, employeeId, projectId).Rows)
                {
                    outid = dr["or_id"].ToString();
                    ShowInDataGridView(RecordOperationGateway.ConditionsSearchInRecord(outid, direction, isChoiceTime, begintTime, endTime));
                }
            }

            dgv_PackageInAndOutrecord.Sort(dgv_PackageInAndOutrecord.Columns[5], ListSortDirection.Ascending);
            tb_packageid.Text = "";
            tb_employeeid.Text = "";
            tb_projectid.Text = "";
        }

        //查询员工
        private void btn_selectemployee_Click(object sender, EventArgs e)
        {
            selectEmployees = new EmployeeManagement();
            selectEmployees.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectEmployees.EmployeesSelected += EmployeesSelected;
            selectEmployees.ShowDialog();
            selectEmployees.EmployeesSelected -= EmployeesSelected;
        }

        private void EmployeesSelected(int employeesId, string emNumbers,string name)
        {
            tb_employeeid.Text = "";
            tb_employeeid.Text = employeesId.ToString();
        }

        //查询袋子
        private void btn_selectpackageid_Click(object sender, EventArgs e)
        {
            selectPackages = new PackageManagement();
            selectPackages.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectPackages.PackageIdSelected += PackagesSelected;
            selectPackages.ShowDialog();
            selectPackages.PackageIdSelected -= PackagesSelected;
        }

        //查询项目
        private void btn_selectprojectid_Click(object sender, EventArgs e)
        {
            selectProject = new ProjectManageme();
            selectProject.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectProject.ProjectSelecteds += ProjectSelected;
            selectProject.ShowDialog();
            selectProject.ProjectSelecteds -= ProjectSelected;
        }

        private void ProjectSelected(int projectid,string projectPassword)
        {
            tb_projectid.Text = "";
            tb_projectid.Text = projectid.ToString();
        }

        private void PackagesSelected(int packageId)
        {
            tb_packageid.Text = "";
            tb_packageid.Text = packageId.ToString();
        }

        private void dgv_PackageInAndOutrecord_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.FixedSingle)
            {
                int id = (int)(dgv_PackageInAndOutrecord.SelectedRows[0]).Cells[0].Value;
                PackageIdSelected?.Invoke(id);
                Close();
            }
        }

        //右键菜单选择
        //private void dgv_PackageInAndOutrecord_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (FormBorderStyle == FormBorderStyle.None)
        //    {
        //        contextMenuStrip1.Enabled = false;
        //        return;
        //    }

        //    if (e.Button == MouseButtons.Right)
        //    {
        //        if (e.RowIndex >= 0)
        //        {
        //            //若行已是选中状态就不再进行设置
        //            if (dgv_PackageInAndOutrecord.Rows[e.RowIndex].Selected == false)
        //            {
        //                dgv_PackageInAndOutrecord.ClearSelection();
        //                dgv_PackageInAndOutrecord.Rows[e.RowIndex].Selected = true;
        //            }
        //            //只选中一行时设置活动单元格
        //            if (e.ColumnIndex < 0)
        //                return;
        //            if (dgv_PackageInAndOutrecord.SelectedRows.Count == 1)
        //            {
        //                dgv_PackageInAndOutrecord.CurrentCell = dgv_PackageInAndOutrecord.Rows[e.RowIndex].Cells[e.ColumnIndex];
        //            }
        //            //弹出操作菜单
        //            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        //        }
        //    }
        //}

        //private void 选择ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    int id = (int)(dgv_PackageInAndOutrecord.SelectedRows[0]).Cells[0].Value;
        //    PackageIdSelected?.Invoke(id);
        //    Close();
        //}
    }
}
