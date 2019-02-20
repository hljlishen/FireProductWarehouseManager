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

namespace FireProductManager.GuiPackage
{
    public partial class SystemDictionary : Form
    {
        string type = "生产厂商";
        public SystemDictionary()
        {
            InitializeComponent();
        }

        private void SystemDictionary_Load(object sender, EventArgs e)
        {
            ShowAllManufacturerName();
        }

        //显示全部材料
        public void ShowAllManufacturerName()
        {
            DataTable dataTable = SystemDictionaryGateway.GetQueryDictionaryTypeText(type);
            ShowDataGridView(dataTable);
        }

        //DataGridView显示数据
        private void ShowDataGridView(DataTable dt)
        {
            dgv_manufacturername.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_manufacturername.Rows.Add(row);
                dgv_manufacturername.Rows[index].Cells[0].Value = dr["sy_id"];
                dgv_manufacturername.Rows[index].Cells[1].Value = dr["sy_text"];
            }
        }

        //添加生产厂商
        private void bt_add_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.Equals("")) return;
            string name = tb_name.Text;
            SystemDictionaryGateway.NewSystemDictionary(type, name);
            ShowAllManufacturerName();
            tb_name.Text = "";
        }

        //删除生产厂商
        private void dgv_manufacturername_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)//点击在删除按钮上
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)dgv_manufacturername.CurrentRow.Cells[0].Value;
                    SystemDictionaryGateway.DeleteSystemDictionary(id);
                    dgv_manufacturername.Rows.RemoveAt(e.RowIndex);//从DGV移除
                }
            }
        }
    }
}
