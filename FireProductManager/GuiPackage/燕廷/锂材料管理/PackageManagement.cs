using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

//材料管理

namespace FireProductManager.GuiPackage
{
    public partial class PackageManagement : Form
    {
        public delegate void PackageIdSelectedHandler(int packageid);
        public event PackageIdSelectedHandler PackageIdSelected;

        public PackageManagement()
        {
            InitializeComponent();
        }

        private void index_instrument_Load(object sender, EventArgs e)
        {
            cb_IsInWareHouse.Text = "全部";
            Left = 0;
            Top = 0;
            DataTable dataTable = PackageGateway.GetAllPackage();
            ShowDataGridView(dataTable);
        }

        //DataGridView显示数据
        public void ShowDataGridView(DataTable dt)
        {
            dgv_instrumentinformation.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_instrumentinformation.Rows.Add(row);
                dgv_instrumentinformation.Rows[index].Cells[0].Value = dr["pa_name"];
                dgv_instrumentinformation.Rows[index].Cells[1].Value = dr["pa_model"];
                dgv_instrumentinformation.Rows[index].Cells[2].Value = dr["pa_weight"];
                dgv_instrumentinformation.Rows[index].Cells[3].Value = dr["pa_barrelid"];
                dgv_instrumentinformation.Rows[index].Cells[4].Value = PackageGateway.IsinWarehouseDataTypeChangeString((int)dr["pa_isinwarehouse"]);
                dgv_instrumentinformation.Rows[index].Cells[5].Value = dr["pa_purchasetime"];
                dgv_instrumentinformation.Rows[index].Cells[6].Value = dr["pa_projectid"];
                dgv_instrumentinformation.Rows[index].Cells[7].Value = dr["pa_id"];
            }
        }

        //搜索按钮
        private void bt_querypackage_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string model = tb_model.Text;
            string barrdlid = tb_barrdlid.Text;
            string isInWareHouse = cb_IsInWareHouse.Text;
            string porject = tb_project.Text;
            DataTable dataTable = PackageGateway.GetQueryPackage(name, model, barrdlid, isInWareHouse, porject);
            ShowDataGridView(dataTable);
        }

        //右键单击表格数据
        private void dgv_instrumentinformation_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                int x = e.X;
                int y = e.Y;
                int a = e.RowIndex;
                dgv_instrumentinformation.CurrentCell = dgv_instrumentinformation.Rows[e.RowIndex].Cells[0];
                dgv_instrumentinformation.Rows[e.RowIndex].Selected = true;
                cms_packageoperation.Show(MousePosition);
            }
        }

        //右键单击DGV空白
        private void dgv_instrumentinformation_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms_newpackage.Show(MousePosition);
            }
        }

        private void tsm_newpackage_Click(object sender, EventArgs e) => NewPackage();

        //添加材料
        private void NewPackage()
        {
            AddOrUpdatePackage add = new AddOrUpdatePackage();
            add.ShowDialog();
        }

        private void tsm_updatepackage_Click(object sender, EventArgs e) => UpdatePackage();

        //修改材料
        private void UpdatePackage()
        {
            int packageid = (int)dgv_instrumentinformation.CurrentRow.Cells[7].Value;
            AddOrUpdatePackage Update = new AddOrUpdatePackage(packageid);
            Update.ShowDialog();
        }

        private void tsm_deletepackage_Click(object sender, EventArgs e) => DeletePackage();

        //删除材料
        private void DeletePackage()
        {
            if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int packageid = (int)dgv_instrumentinformation.CurrentRow.Cells[7].Value;
                PackageGateway.DeletePackage(packageid);
                AutoClosingMessageBox.Show("材料信息删除成功", "材料信息删除", 1000);
            }
        }

        #region dgv导出Excel
        //dgv导出Excel
        private void bt_dgvchangeexcel_Click(object sender, EventArgs e)
        {
            ExcelOperator.DataGridViewToExcel(dgv_instrumentinformation, true);
        }
        #endregion

        private void dgv_instrumentinformation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.FixedSingle)
            {
                PackageIdSelected?.Invoke((int)(dgv_instrumentinformation.SelectedRows[0]).Cells[9].Value);
                Close();
            }
        }

       
    }
}
