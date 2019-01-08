using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class ProjectManageme : Form
    {
        public delegate void ProjectSelectedHandler(int id,string projectPassword);
        public event ProjectSelectedHandler ProjectSelecteds;
        private int _index;

        public ProjectManageme()
        {
            InitializeComponent();
        }

        private void ProjectManageme_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            DataTable dataTable = ProjectGateway.GetAllProject();
            ShowDataGridView(dataTable);
        }

        //显示全部项目
        public void ShowAllProject()
        {
            DataTable dataTable = ProjectGateway.GetAllProject();
            ShowDataGridView(dataTable);
        }

        //DataGridView显示数据
        private void ShowDataGridView(DataTable dataTable)
        {
            dgv_projectinformation.Rows.Clear();
            foreach (DataRow dr in dataTable.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_projectinformation.Rows.Add(row);
                dgv_projectinformation.Rows[index].Cells[0].Value = dr["pr_id"];
                dgv_projectinformation.Rows[index].Cells[1].Value = dr["pr_name"];
                dgv_projectinformation.Rows[index].Cells[2].Value = dr["pr_projectPassword"];
                dgv_projectinformation.Rows[index].Cells[3].Value = dr["pr_note"];
                
            }
        }

        //项目搜索
        private void bt_queryproject_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ProjectGateway.GetQueryProject(tb_name.Text, tb_projectpassword.Text);
            ShowDataGridView(dataTable);
        }

        //右键单击表格数据
        private void dgv_projectinformation_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                int x = e.X;
                int y = e.Y;
                int a = e.RowIndex;
                dgv_projectinformation.CurrentCell = dgv_projectinformation.Rows[e.RowIndex].Cells[1];
                dgv_projectinformation.Rows[e.RowIndex].Selected = true;
                cms_projectoperation.Show(MousePosition);
                _index = e.RowIndex;
            }
        }

        //右键单击DGV空白
        private void dgv_projectinformation_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms_newproject.Show(MousePosition);
            }
        }

        //添加-右键菜单
        private void tsm_newproject_Click(object sender, EventArgs e) => NewProject();

        //添加项目
        private void NewProject()
        {
            AddOrUpdateProject addProject = new AddOrUpdateProject(this);
            addProject.ShowDialog();
        }

        //修改-右键菜单
        private void tsm_updateproject_Click(object sender, EventArgs e) => UpdateProject();

        //修改项目
        private void UpdateProject()
        {
            int projectid = (int)dgv_projectinformation.CurrentRow.Cells[0].Value;
            AddOrUpdateProject UpdateProject = new AddOrUpdateProject(projectid,this);
            UpdateProject.ShowDialog();
        }

        //删除-右键菜单
        private void tsm_deleteproject_Click(object sender, EventArgs e) => DeleteProject();

        //删除项目
        private void DeleteProject()
        {
            //if (!AccountManager.CanReadDatabase()) 
            //{
            //    AutoClosingMessageBox.Show("        权限不足", "权限", 2000);
            //    return;
            //}

            if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int projectid = (int)dgv_projectinformation.CurrentRow.Cells[0].Value;
                if (ProjectGateway.DeleteProject(projectid))
                {
                    dgv_projectinformation.Rows.RemoveAt(_index);//从DGV移除
                    return;
                }
                AutoClosingMessageBox.Show("该项目存在出入库记录，无法删除", "删除失败", 2000);
            }
        }

        //双击返回行数据
        private void dgv_projectinformation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.FixedSingle)
            {
                int projectid = (int)(dgv_projectinformation.SelectedRows[0]).Cells[0].Value;
                string projectPassword = (dgv_projectinformation.SelectedRows[0]).Cells[2].Value.ToString();
                ProjectSelecteds?.Invoke(projectid,projectPassword);
                Close();
            }
        }

        //dgv导出Excel
        private void bt_dgvchangeexcel_Click(object sender, EventArgs e)
        {
            ExcelOperator.DataGridViewToExcel(dgv_projectinformation, true);
        }
    }
}
