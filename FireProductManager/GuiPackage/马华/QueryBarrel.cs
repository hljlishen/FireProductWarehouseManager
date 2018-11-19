using System;
using System.Data;
using DbLink;
using System.Windows.Forms;
using System.Collections.Generic;
using FireProductManager.ServiceLogicPackage;

namespace FireProductManager.GuiPackage
{
    public partial class QueryBarrel : Form
    {

        public delegate void BarrelIdSelectedHandler(List<string> barrelid);
        public event BarrelIdSelectedHandler BarrelIdSelected;

        public QueryBarrel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowDataGridView(DataTable dt)
        {
            dgv_existbarrelid.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_existbarrelid.Rows.Add(row);
                dgv_existbarrelid.Rows[index].Cells[0].Value = dr["ba_id"] + "号桶";
            }
        }

        private void QueryBarrel_Load(object sender, EventArgs e)
        {
            SelectSqlMaker maker = new SelectSqlMaker("barrel");
            maker.AddAndCondition(new IntEqual("ba_isRemoved",0));
            string sql = maker.MakeSelectSql();
            ShowDataGridView(BarrelGateway.Query(sql));
        }

        private void dgv_existbarrelid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                var selectedRows = dgv_existbarrelid.SelectedRows;
                List<string> ids = new List<string>();
                foreach (var row in selectedRows)
                {
                    string id = ((DataGridViewRow)row).Cells[0].Value.ToString();
                    ids.Add(id);
                }
                BarrelIdSelected?.Invoke(ids);
                Close();
            }
        }
    }
}
