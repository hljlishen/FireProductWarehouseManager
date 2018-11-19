using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

//材料管理

namespace FireProductManager.GuiPackage
{
    public partial class PackageManagement : Form
    {
        EmployeeManagement selectEmployees;
        public delegate void InstrumentSelectedHandler(List<int> instrumentIds,List<string> insTagids);
        public event InstrumentSelectedHandler InstrumentSelected;
        private int dutyid;

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
                dgv_instrumentinformation.Rows[index].Cells[0].Value = dr["pa_modle"];
                dgv_instrumentinformation.Rows[index].Cells[1].Value = dr["pa_weight"];
                dgv_instrumentinformation.Rows[index].Cells[2].Value = dr["pa_barrelid"];
                dgv_instrumentinformation.Rows[index].Cells[3].Value = dr["pa_isinwarehouse"];
                dgv_instrumentinformation.Rows[index].Cells[4].Value = dr["pa_purchasetime"];
                dgv_instrumentinformation.Rows[index].Cells[5].Value = dr["pa_id"];
            }
        }

        //材料添加
        private void button1_Click(object sender, EventArgs e)  
        {
            AddOrUpdatePackage add = new AddOrUpdatePackage();
            add.ShowDialog();
        }

        //搜索按钮
        private void button2_Click(object sender, EventArgs e)  
        {
            //ins.TagId = tb_tagid.Text;
            //ins.Name = tb_instrumentname.Text;
            //ins.Model = tb_model.Text;
            //ins.IsInWareHouse = cb_IsInWareHouse.Text.Equals("全部") ?  null : cb_IsInWareHouse.Text;
            //ins.Duty = dutyid;
            //ShowDataGridView(dao.QueryInstrument(ins));
            //tb_duty.Text = "";
            //dutyid = 0;
        }

        //材料的修改、删除、查看
        private void dgv_instrumentinformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //删除
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int packageid = (int)dgv_instrumentinformation.CurrentRow.Cells[9].Value;
                    //删除逻辑代码？？
                    AutoClosingMessageBox.Show("仪器信息删除成功", "仪器信息删除", 1000);
                    dgv_instrumentinformation.Rows.RemoveAt(e.RowIndex);
                }
            }
            //修改
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int packageid = (int)dgv_instrumentinformation.CurrentRow.Cells[9].Value;
                    //AddOrUpdatePackage Update = new AddOrUpdatePackage(packageid);
                    //Update.ShowDialog();
                }
            }
            //查看
            if (e.ColumnIndex == 8)
            {
                int packageid = (int)dgv_instrumentinformation.CurrentRow.Cells[9].Value;
                //AddOrUpdatePackage add = new AddOrUpdatePackage(packageid);
                //add.ShowDialog();
            }
        }

        #region dgv导出Excel
        //dgv导出Excel
        private void bt_dgvchangeexcel_Click(object sender, EventArgs e)
        {
            ExcelOperator.DataGridViewToExcel(dgv_instrumentinformation, true);
        }
        #endregion
    }
}
