﻿using FireProductManager.ServiceLogicPackage;
using System;
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
            ShowDataGridView(RecordOperationGateway.GetAllInOrOutRecord()); 
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
                dgv_PackageInAndOutrecord.Rows[index].Cells[6].Value = dr["ior_borrowName"];
                dgv_PackageInAndOutrecord.Rows[index].Cells[8].Value = SelectPackageWeigth((int)dr["ior_packageId"]) + "g";
                dgv_PackageInAndOutrecord.Rows[index].Cells[11].Value = dr["ior_accountName"];
            }
        }

        private int SelectBaeerlId(int id)
        {
            int barrelid = 0;
            foreach (DataRow dr in RecordOperationGateway.ThroughPackageIdQuerypackage(id).Rows)
                barrelid = (int)dr["pa_barrelId"];
            return barrelid;
        }

        private string SelectPackageName(int id)
        {
            string packagename = null;
            foreach (DataRow dr in RecordOperationGateway.ThroughPackageIdQuerypackage(id).Rows)
                packagename = dr["pa_name"].ToString();
            return packagename;
        }

        private string SelectPackageModel(int id)
        {
            string packagemodel = null;
            foreach (DataRow dr in RecordOperationGateway.ThroughPackageIdQuerypackage(id).Rows)
                packagemodel = dr["pa_model"].ToString();
            return packagemodel;
        }

        private double SelectPackageWeigth(int id)
        {
            double packageweigth = 0;
            foreach (DataRow dr in RecordOperationGateway.ThroughPackageIdQuerypackage(id).Rows)
                packageweigth = (double)dr["pa_weight"];
            return packageweigth;
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
            string packageId = tb_packageid.Text;
            string employeeId = tb_employeeid.Text;
            string projectId = tb_projectPassword.Text;
            string direction = cb_directquery.Text;
            bool isChoiceTime = false;
            DateTime begintTime = dtp_begin.Value;
            DateTime endTime = dtp_end.Value.AddDays(1);
            if (cb_choicetime.Checked.Equals(true))
                isChoiceTime = true;
            ShowDataGridView(RecordOperationGateway.ConditionsSearchInOrOutRecord(packageId, employeeId, projectId, direction, isChoiceTime, begintTime, endTime));
            tb_packageid.Text = "";
            tb_employeeid.Text = "";
            tb_projectPassword.Text = "";
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
            tb_projectPassword.Text = "";
            tb_projectPassword.Text = projectPassword.ToString();
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
