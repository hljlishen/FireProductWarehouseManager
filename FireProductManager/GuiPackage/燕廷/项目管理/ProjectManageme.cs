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
                dgv_projectinformation.Rows[index].Cells[5].Value = dr["pr_id"];
            }
        }

        //添加项目
        private void bt_addproject_Click(object sender, EventArgs e)
        {
            AddOrUpdateProject addProject = new AddOrUpdateProject();
            addProject.ShowDialog();
        }

        //修改、删除项目
        private void dgv_projectinformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //删除
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int projectid = (int)dgv_projectinformation.CurrentRow.Cells[5].Value;
                    ProjectGateway.DeleteProject(projectid);
                    AutoClosingMessageBox.Show("项目信息删除成功", "项目信息删除", 1000);
                    dgv_projectinformation.Rows.RemoveAt(e.RowIndex);
                }
            }
            //修改
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    uint projectid = (uint)dgv_projectinformation.CurrentRow.Cells[9].Value;
                    AddOrUpdateProject UpdateProject = new AddOrUpdateProject(projectid);
                    UpdateProject.ShowDialog();
                }
            }
        }

        //项目搜索
        private void bt_queryproject_Click(object sender, EventArgs e)
        {

        }

        //dgv导出Excel
        private void bt_dgvchangeexcel_Click(object sender, EventArgs e)
        {
            ExcelOperator.DataGridViewToExcel(dgv_projectinformation, true);
        }

       
    }
}
