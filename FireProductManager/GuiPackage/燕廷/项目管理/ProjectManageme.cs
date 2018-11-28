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

        }

        //添加项目
        private void bt_addproject_Click(object sender, EventArgs e)
        {

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
                    PackageGateway.DeletePackage(projectid);
                    AutoClosingMessageBox.Show("项目信息删除成功", "仪器信息删除", 1000);
                    dgv_projectinformation.Rows.RemoveAt(e.RowIndex);
                }
            }
            //修改
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int packageid = (int)dgv_projectinformation.CurrentRow.Cells[9].Value;
                    AddOrUpdatePackage Update = new AddOrUpdatePackage(packageid);
                    Update.ShowDialog();
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
