using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    public partial class QueryBarrel : Form
    {

        public delegate void BarrelIdSelectedHandler(int barrelid,int loadingCapacity);
        public event BarrelIdSelectedHandler BarrelIdSelected;

        public QueryBarrel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_return_Click(object sender, EventArgs e) => Close();

        private void ShowDataGridView(DataTable dt)
        {
            dgv_existbarrelid.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_existbarrelid.Rows.Add(row);
                dgv_existbarrelid.Rows[index].Cells[0].Value = dr["ba_id"];
                dgv_existbarrelid.Rows[index].Cells[1].Value = dr["ba_loadingCapacity"];
                dgv_existbarrelid.Rows[index].Cells[2].Value = SelectWeightOfBarrel((int)dr["ba_id"]) + "g";
            }
        }

        private string SelectWeightOfBarrel(int barrelid) => BarrelGateway.WeightOfBarrel(barrelid).ToString();

        private void QueryBarrel_Load(object sender, EventArgs e) => ShowDataGridView(BarrelGateway.NoRemoveBarrelId());

        //右键菜单选择
        //private void dgv_existbarrelid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        if (e.RowIndex >= 0)
        //        {
        //            if (e.ColumnIndex < 0)
        //                return;
        //            //若行已是选中状态就不再进行设置
        //            if (dgv_existbarrelid.Rows[e.RowIndex].Selected == false)
        //            {
        //                dgv_existbarrelid.ClearSelection();
        //                dgv_existbarrelid.Rows[e.RowIndex].Selected = true;
        //            }
        //            //只选中一行时设置活动单元格
        //            if (dgv_existbarrelid.SelectedRows.Count == 1)
        //            {
        //                dgv_existbarrelid.CurrentCell = dgv_existbarrelid.Rows[e.RowIndex].Cells[e.ColumnIndex];
        //            }
        //            //弹出操作菜单
        //            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        //        }
        //    }
        //}

        //private void 选择ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    BarrelIdSelected?.Invoke((int)(dgv_existbarrelid.SelectedRows[0]).Cells[0].Value);
        //    Close();
        //}

        private void ShowDataGridView2(DataTable dt)
        {
            dgv_package.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_package.Rows.Add(row);
                dgv_package.Rows[index].Cells[0].Value = dr["pa_id"];
                dgv_package.Rows[index].Cells[1].Value = dr["pa_type"];
                dgv_package.Rows[index].Cells[2].Value = dr["pa_specifications"];
                dgv_package.Rows[index].Cells[3].Value = dr["pa_suttle"] + "g";
            }
        }

        private void dgv_existbarrelid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int barrelid = (int)(dgv_existbarrelid.SelectedRows[0]).Cells[0].Value;
            ShowDataGridView2(BarrelGateway.BarrelIdQueryPackageInformation(barrelid));
        }

        private void dgv_existbarrelid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BarrelIdSelected?.Invoke((int)(dgv_existbarrelid.SelectedRows[0]).Cells[0].Value, (int)(dgv_existbarrelid.SelectedRows[0]).Cells[1].Value);
            Close();
        }
    }
}
