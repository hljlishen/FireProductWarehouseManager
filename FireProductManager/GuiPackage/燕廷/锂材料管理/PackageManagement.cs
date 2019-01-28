using FireProductManager.ServiceLogicPackage;
using System;
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

        string _barrelid;
        private int _index;

        public PackageManagement()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void index_instrument_Load(object sender, EventArgs e)
        {
            cb_IsInWareHouse.Text = "全部";
            ShowAllPackage();
        }

        //显示全部材料
        public void ShowAllPackage()
        {
            DataTable dataTable = PackageGateway.GetAllPackage();
            ShowDataGridView(dataTable);
        }

        //DataGridView显示数据
        private void ShowDataGridView(DataTable dt)
        {
            dgv_instrumentinformation.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_instrumentinformation.Rows.Add(row);
                dgv_instrumentinformation.Rows[index].Cells[0].Value = dr["pa_id"];
                dgv_instrumentinformation.Rows[index].Cells[1].Value = dr["pa_type"];
                dgv_instrumentinformation.Rows[index].Cells[2].Value = dr["pa_specifications"];
                dgv_instrumentinformation.Rows[index].Cells[3].Value = dr["pa_weight"];
                dgv_instrumentinformation.Rows[index].Cells[4].Value = dr["pa_barrelid"];
                dgv_instrumentinformation.Rows[index].Cells[5].Value = PackageGateway.IsinWarehouseDataTypeChangeString((int)dr["pa_isinwarehouse"]);
                dgv_instrumentinformation.Rows[index].Cells[6].Value = dr["pa_productionCompany"];
                dgv_instrumentinformation.Rows[index].Cells[7].Value = ((DateTime)dr["pa_purchasetime"]).ToString("yyyy-MM-dd");
                dgv_instrumentinformation.Rows[index].Cells[8].Value = dr["pa_beginningweight"];
                
            }
        }

        #region 材料搜索
        //搜索按钮
        private void bt_querypackage_Click(object sender, EventArgs e)
        {
            string type = tb_type.Text;
            string model = tb_model.Text;
            string productioncompany = tb_productioncompany.Text;
            string isInWareHouse = cb_IsInWareHouse.Text;
            DataTable dataTable = PackageGateway.GetQueryPackage(type, model, _barrelid, productioncompany, isInWareHouse);
            ShowDataGridView(dataTable);

            tb_barrelid.Text = "";
            _barrelid = "";
        }

        //选择桶
        private void bt_changebarrel_Click(object sender, EventArgs e)
        {
            QueryBarrel queryBarrel = new QueryBarrel();
            queryBarrel.FormBorderStyle = FormBorderStyle.FixedSingle;
            queryBarrel.BarrelIdSelected += BarrelIdSelected;
            queryBarrel.ShowDialog();
            queryBarrel.BarrelIdSelected -= BarrelIdSelected;
        }

        //显示桶编号
        private void BarrelIdSelected(int barrelid,int packagenumber)
        {
            _barrelid = barrelid.ToString();
            tb_barrelid.Text = barrelid.ToString();
        }
        #endregion

        #region 材料的增、删、改
        //右键单击表格数据
        private void dgv_instrumentinformation_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                int x = e.X;
                int y = e.Y;
                int a = e.RowIndex;
                dgv_instrumentinformation.CurrentCell = dgv_instrumentinformation.Rows[e.RowIndex].Cells[1];
                dgv_instrumentinformation.Rows[e.RowIndex].Selected = true;
                cms_packageoperation.Show(MousePosition);
                _index = e.RowIndex;
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
            AddOrUpdatePackage add = new AddOrUpdatePackage(this);
            add.ShowDialog();
        }

        private void tsm_updatepackage_Click(object sender, EventArgs e) => UpdatePackage();

        //修改材料
        private void UpdatePackage()
        {
            int packageid = (int)dgv_instrumentinformation.CurrentRow.Cells[0].Value;
            AddOrUpdatePackage Update = new AddOrUpdatePackage(packageid, this);
            Update.ShowDialog();
        }

        private void tsm_deletepackage_Click(object sender, EventArgs e) => DeletePackage();

        //删除材料
        private void DeletePackage()
        {
            if (!AccountManager.CanReadDatabase()) //没有用
            {
                AutoClosingMessageBox.Show("        权限不足", "权限", 2000);
                return;
            }
            if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int packageid = (int)dgv_instrumentinformation.CurrentRow.Cells[0].Value;
                if (PackageGateway.DeletePackage(packageid))
                {
                    dgv_instrumentinformation.Rows.RemoveAt(_index);//从DGV移除
                    return;
                }
                AutoClosingMessageBox.Show("该材料存在出入库记录，无法删除", "删除失败", 2000);
            }
        }
        #endregion

        #region dgv导出Excel
        //dgv导出Excel
        private void bt_dgvchangeexcel_Click(object sender, EventArgs e)
        {
            ExcelOperator.DataGridViewToExcel(dgv_instrumentinformation, true);
        }
        #endregion

        #region 双击获取dgv行数据
        //双击获取dgv行数据
        private void dgv_instrumentinformation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.FixedSingle)
            {
                PackageIdSelected?.Invoke((int)(dgv_instrumentinformation.SelectedRows[0]).Cells[0].Value);
                Close();
            }
        }
        #endregion
    }
}
