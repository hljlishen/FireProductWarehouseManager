using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using FireProductManager.ServiceLogicPackage;

//员工信息管理页面

namespace FireProductManager.GuiPackage
{
    public partial class EmployeeManagement : Form
    {
        private TreeNode _treenode;
        private int _level;
        public delegate void EmployeesSelectedHandler(int employeesIds,string emNumbers);
        public event EmployeesSelectedHandler EmployeesSelected;

        public EmployeeManagement()
        {
            InitializeComponent();
        }

        #region 员工页面信息展示
        //初始化页面信息
        public void index_employees_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ShowTreeView();
            ShowAllEmployee();
            cb_foundsex.Text = "男/女";
        }

        //TreeView显示数据
        private void ShowTreeView()
        {
            tv_department.Nodes.Clear();
            DepartmentGateway.LoadTreeView(tv_department);
            tv_department.ExpandAll();
        }

        //显示数据库员工
        private void ShowAllEmployee()
        {
            DataTable dataTable = EmployeeGateway.GetAllEmployees();
            ShowDataGridView(dataTable);
        }

        //DataGridView显示数据
        private void ShowDataGridView(DataTable dataTable)
        {
            dgv_employeeinformation.Rows.Clear();
            foreach (DataRow dr in dataTable.Rows)
            {
                DataGridViewRow row2 = new DataGridViewRow();
                int index = dgv_employeeinformation.Rows.Add(row2);
                dgv_employeeinformation.Rows[index].Cells[0].Value = dr["em_employeenumber"];
                dgv_employeeinformation.Rows[index].Cells[1].Value = dr["em_name"];
                dgv_employeeinformation.Rows[index].Cells[2].Value = dr["em_sex"];
                List<string> mList = DepartmentGateway.ReadDepartmentNodeName((int)dr["em_departmentid"]);
                dgv_employeeinformation.Rows[index].Cells[3].Value = mList[2];
                dgv_employeeinformation.Rows[index].Cells[4].Value = mList[1];
                dgv_employeeinformation.Rows[index].Cells[5].Value = mList[0];
                dgv_employeeinformation.Rows[index].Cells[8].Value = dr["em_id"];
            }
        }
        #endregion

        #region 添加、删除、修改员工信息
        //添加员工
        private void bt_addemployee_Click(object sender, EventArgs e)
        {
            AddOrUpdateEmployee add = new AddOrUpdateEmployee();
            add.Show();
            ShowAllEmployee();
        }

        //删除与修改员工
        private void dgv_employeeinformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)//点击在删除按钮上
            {
                if(DeleteEmployee()) dgv_employeeinformation.Rows.RemoveAt(e.RowIndex);

            }

            if (e.ColumnIndex == 7)//点击在修改按钮上
            {
                if(UpdateEmployee()) ShowAllEmployee();
            }
        }

        //删除员工
        private bool DeleteEmployee()
        {
            if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int employeeid = (int)dgv_employeeinformation.CurrentRow.Cells[8].Value;
                string employeenumber = dgv_employeeinformation.CurrentRow.Cells[0].Value.ToString();
                EmployeeGateway.DeleteEmployee(employeeid);
                ImageManager getSetImagePath = new ImageManager();
                getSetImagePath.DeleteEmployeeImage(employeenumber);
                return true;
            }
            return false;
        }

        //修改员工
        private bool UpdateEmployee()
        {
            if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               int employeeid = (int)dgv_employeeinformation.CurrentRow.Cells[8].Value;
               AddOrUpdateEmployee update = new AddOrUpdateEmployee(employeeid);
               update.Show();
               return true;
            }
            return false;
        }
        #endregion

        #region 员工搜索
        //员工搜索
        private void bt_foundnowgroup_Click(object sender, EventArgs e)
        {
            DataTable dataTable = EmployeeGateway.GetQueryEmployees(tb_foundemployeeid.Text, tb_foundname.Text, cb_foundsex.Text);
            ShowDataGridView(dataTable);
        }

        //选取部门树状图刷新员工信息
        private void tv_department_AfterSelect(object sender, TreeViewEventArgs e)
        { 
            DataTable dataTable = DepartmentGateway.AllEmpolyeesOf(e.Node);
            _treenode = e.Node;
            ShowDataGridView(dataTable);
        }
        #endregion

        #region 部门的添加、修改、删除
        //树状图内鼠标事件
        private void tv_department_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                int x = e.X;
                int y = e.Y;
                TreeNode CurrentNode = tv_department.GetNodeAt(ClickPoint);
                if (CurrentNode is TreeNode)//判断你点的是不是一个节点
                {
                    tv_department.SelectedNode = CurrentNode;
                    CurrentNode.ContextMenuStrip = cms_employeetreeview;
                    cms_employeetreeview.Show(MousePosition);
                    _level = tv_department.SelectedNode.Level;
                    ShowRightClickList();
                }
                else
                {
                    _level = -1;
                    ShowRightClickList();
                }
            }
        }
 
        //展示右键列表
        private void ShowRightClickList()
        {
            switch (_level)
            {
                case 0:
                    tsm_newcompany.Visible = true;
                    tsm_newdepartment.Visible = false;
                    tsm_newgroup.Visible = false;
                    tsm_delete.Visible = false;
                    tsm_rename.Visible = false;
                    break;
                case 1:
                    tsm_newcompany.Visible = false;
                    tsm_newdepartment.Visible = true;
                    tsm_newgroup.Visible = false;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    break;
                case 2:
                    tsm_newcompany.Visible = false;
                    tsm_newdepartment.Visible = false;
                    tsm_newgroup.Visible = true;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    break;
                case 3:
                    tsm_newcompany.Visible = false;
                    tsm_newdepartment.Visible = false;
                    tsm_newgroup.Visible = false;
                    tsm_delete.Visible = true;
                    tsm_rename.Visible = true;
                    break;
                case -1:
                    tv_department.ContextMenuStrip = cms_employeetreeview;
                    tsm_newcompany.Visible = true;
                    tsm_newdepartment.Visible = false;
                    tsm_newgroup.Visible = false;
                    tsm_delete.Visible = false;
                    tsm_rename.Visible = false;
                    cms_employeetreeview.Show(MousePosition);
                    break;
            }
        }

        //新建公司
        private void tsm_newcompany_Click(object sender, EventArgs e)
        {
            CreateDepartment getnodename = new CreateDepartment(0,"请输入公司名称：");
            if (getnodename.ShowDialog() == DialogResult.OK)
            {
                tv_department.Nodes.Add(getnodename.nodeName);
                ShowTreeView();
            }
        }

        //新建部门
        private void tsm_newdepartment_Click(object sender, EventArgs e)
        {
            AddChildNodes("请输入部门名称：");
        }

        //新建小组
        private void tsm_newgroup_Click(object sender, EventArgs e)
        {
            AddChildNodes("请输入小组名称：");
        }

        //添加子节点
        private void AddChildNodes(string nodeType)
        {
            string parentnodename = tv_department.SelectedNode.Text;
            int nodeid = (int)tv_department.SelectedNode.Tag;
            CreateDepartment getnodename = new CreateDepartment(nodeid, nodeType);
            if (getnodename.ShowDialog() == DialogResult.OK)
            {
                ShowTreeView();
            }
            tv_department.ExpandAll();
        }

        //删除
        private void tsm_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除该节点？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int nodeid = (int)tv_department.SelectedNode.Tag;
                if (DepartmentGateway.DeleteDepartment(nodeid))
                {
                    tv_department.SelectedNode.Remove();
                }
            }
        }

        //重命名
        private void tsm_rename_Click(object sender, EventArgs e)
        {
            int parentnodeid = 0;
            if (tv_department.SelectedNode.Level != 0)
            {
                parentnodeid = (int)tv_department.SelectedNode.Parent.Tag;
            }
            string nodename = tv_department.SelectedNode.Text;
            int nodeid = (int)tv_department.SelectedNode.Tag;
            CreateDepartment getnodename = new CreateDepartment(parentnodeid, nodeid);
            if (getnodename.ShowDialog() == DialogResult.OK)
            {
                tv_department.SelectedNode.Text = getnodename.nodeName;
            }
            tv_department.ExpandAll();
        }
        #endregion

        #region 员工信息双击获取
        //dgv双击获取员工id
        private void dgv_employeeinformation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int employeeId = (int)(dgv_employeeinformation.SelectedRows[0]).Cells[8].Value;
            string emNumbers = (dgv_employeeinformation.SelectedRows[0]).Cells[0].Value.ToString();
            EmployeesSelected?.Invoke(employeeId, emNumbers);
            Close();
        }
        #endregion

        #region dgv导出Excel
        //dgv导出Excel
        private void bt_dgvchangexcel_Click(object sender, EventArgs e)
        {
            ExcelOperator.DataGridViewToExcel(dgv_employeeinformation, true);
        }
        #endregion

    }
}
