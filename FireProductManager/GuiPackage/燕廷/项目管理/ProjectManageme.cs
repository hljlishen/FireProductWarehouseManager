using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class ProjectManageme : Form
    {
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

        //DataGridView显示数据
        public void ShowDataGridView(DataTable dataTable)
        {
            dgv_projectinformation.Rows.Clear();
            foreach (DataRow dr in dataTable.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_projectinformation.Rows.Add(row);
                dgv_projectinformation.Rows[index].Cells[0].Value = dr["pr_name"];
                dgv_projectinformation.Rows[index].Cells[1].Value = dr["pr_projectPassword"];
                dgv_projectinformation.Rows[index].Cells[2].Value = dr["pr_note"];
                dgv_projectinformation.Rows[index].Cells[3].Value = dr["pr_id"];
            }
        }

        //项目搜索
        private void bt_queryproject_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ProjectGateway.GetQueryProject(tb_name.Text, tb_projectpassword.Text);
            ShowDataGridView(dataTable);
        }

        //dgv导出Excel
        private void bt_dgvchangeexcel_Click(object sender, EventArgs e)
        {
            ExcelOperator.DataGridViewToExcel(dgv_projectinformation, true);
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
                dgv_projectinformation.CurrentCell = dgv_projectinformation.Rows[e.RowIndex].Cells[0];
                dgv_projectinformation.Rows[e.RowIndex].Selected = true;
                cms_projectoperation.Show(MousePosition);
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

        //添加-菜单
        private void tsm_newproject_Click(object sender, EventArgs e) => NewProject();

        //添加项目
        private void NewProject()
        {
            AddOrUpdateProject addProject = new AddOrUpdateProject();
            addProject.ShowDialog();
        }

        //修改-菜单
        private void tsm_updateproject_Click(object sender, EventArgs e) => UpdateProject();

        //修改项目
        private void UpdateProject()
        {
            int projectid = (int)dgv_projectinformation.CurrentRow.Cells[3].Value;
            AddOrUpdateProject UpdateProject = new AddOrUpdateProject(projectid);
            UpdateProject.ShowDialog();
        }

        //删除-菜单
        private void tsm_deleteproject_Click(object sender, EventArgs e) => DeleteProject();

        //删除项目
        private void DeleteProject()
        {
            if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int projectid = (int)dgv_projectinformation.CurrentRow.Cells[5].Value;
                ProjectGateway.DeleteProject(projectid);
                AutoClosingMessageBox.Show("项目信息删除成功", "项目信息删除", 1000);
            }
        }

       
    }
}
