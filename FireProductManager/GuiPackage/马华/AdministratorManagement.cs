using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class AdministratorManagement : Form
    {
        AddOrUpdateAministrator addOrUpdateAministrator = null;

        public AdministratorManagement()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ShowDataGridView(AccountManager.GetAllAccountInformation());
        }

        private void ShowDataGridView(DataTable dt)
        {
            dgv_administrator.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_administrator.Rows.Add(row);
                dgv_administrator.Rows[index].Cells[0].Value = dr["ac_id"];
                dgv_administrator.Rows[index].Cells[1].Value = dr["ac_account"];
                dgv_administrator.Rows[index].Cells[2].Value = dr["ac_password"];
                dgv_administrator.Rows[index].Cells[3].Value = dr["ac_authority"];
            }
        }

        private void dgv_administrator_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //删除
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int accountid =(int)dgv_administrator.CurrentRow.Cells[0].Value;
                    AccountManager.RemoveAccount(accountid);
                    AutoClosingMessageBox.Show("            管理员删除成功", "删除管理员", 1000);
                    dgv_administrator.Rows.RemoveAt(e.RowIndex);//从DGV移除
                }
            }
            //修改
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int accountid = (int)dgv_administrator.CurrentRow.Cells[0].Value;
                    string account = dgv_administrator.CurrentRow.Cells[1].Value.ToString();
                    string password = dgv_administrator.CurrentRow.Cells[2].Value.ToString();
                    int authority = (int)dgv_administrator.CurrentRow.Cells[3].Value;
                    addOrUpdateAministrator.Close();
                    addOrUpdateAministrator = new AddOrUpdateAministrator(accountid, account, password, authority);
                    PanelShow(addOrUpdateAministrator);
                }
            }
        }

        private void AdministratorManagement_Load(object sender, EventArgs e)
        {
            addOrUpdateAministrator = new AddOrUpdateAministrator();
            PanelShow(addOrUpdateAministrator);
        }

        private void PanelShow(AddOrUpdateAministrator addOrUpdateAministrator)
        {
            addOrUpdateAministrator.TopLevel = false;
            addOrUpdateAministrator.FormBorderStyle = FormBorderStyle.None;
            pa_addorupdate.Controls.Add(addOrUpdateAministrator);
            addOrUpdateAministrator.Show();
        }

        private void btn_addaccount_Click(object sender, EventArgs e)
        {
            addOrUpdateAministrator.Close();
            addOrUpdateAministrator = new AddOrUpdateAministrator();
            PanelShow(addOrUpdateAministrator);
        }
    }
}
