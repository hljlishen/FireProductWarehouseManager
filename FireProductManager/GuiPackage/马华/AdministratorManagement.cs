using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class AdministratorManagement : Form
    {
        AddOrUpdateAministrator addOrUpdateAministrator;

        public AdministratorManagement()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            RefreshDataGridViewShow();
        }

        private void RefreshDataGridViewShow() => ShowDataGridView(AccountManager.GetAllAccountInformation());

        private void ShowDataGridView(DataTable dt)
        {
            dgv_administrator.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_administrator.Rows.Add(row);
                dgv_administrator.Rows[index].Cells[0].Value = dr["ac_id"];
                dgv_administrator.Rows[index].Cells[1].Value = dr["ac_accountNumber"];
                dgv_administrator.Rows[index].Cells[2].Value = dr["ac_accountName"];
                dgv_administrator.Rows[index].Cells[3].Value = dr["ac_password"];
                dgv_administrator.Rows[index].Cells[4].Value = dr["ac_authority"];
            }
        }

        public void AdministratorManagement_Load(object sender, EventArgs e)
        {
            addOrUpdateAministrator = new AddOrUpdateAministrator();
            addOrUpdateAministrator.RefreshData += RefreshDataGridViewShow;
            AddOrUpdatePageSwitching(addOrUpdateAministrator);
        }

        private void AddOrUpdatePageSwitching(AddOrUpdateAministrator addOrUpdateAministrator)
        {
            addOrUpdateAministrator.TopLevel = false;
            addOrUpdateAministrator.FormBorderStyle = FormBorderStyle.None;
            pa_addorupdate.Controls.Add(addOrUpdateAministrator);
            addOrUpdateAministrator.Show();
        }

        private void dgv_administrator_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip2.Show(MousePosition);
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            addOrUpdateAministrator.Close();
            addOrUpdateAministrator = new AddOrUpdateAministrator();
            addOrUpdateAministrator.RefreshData += RefreshDataGridViewShow;
            AddOrUpdatePageSwitching(addOrUpdateAministrator);
        }

        private void UpdateAccount_Click(object sender, EventArgs e)
        {
            int accountid = (int)dgv_administrator.CurrentRow.Cells[0].Value;
            string account = dgv_administrator.CurrentRow.Cells[1].Value.ToString();
            string name = dgv_administrator.CurrentRow.Cells[2].Value.ToString();
            string password = dgv_administrator.CurrentRow.Cells[3].Value.ToString();
            int authority = (int)dgv_administrator.CurrentRow.Cells[4].Value;
            addOrUpdateAministrator.Close();
            addOrUpdateAministrator = new AddOrUpdateAministrator(accountid, account, name ,password, authority);
            addOrUpdateAministrator.RefreshData += RefreshDataGridViewShow;
            AddOrUpdatePageSwitching(addOrUpdateAministrator);
        }

        private void DelectAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int accountid = (int)dgv_administrator.CurrentRow.Cells[0].Value;
                AccountManager.RemoveAccount(accountid);
                AutoClosingMessageBox.Show("            管理员删除成功", "删除管理员", 1000);
                RefreshDataGridViewShow();
            }
        }

        private void dgv_administrator_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgv_administrator.Rows[e.RowIndex].Selected == false)
                    {
                        dgv_administrator.ClearSelection();
                        dgv_administrator.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (e.ColumnIndex < 0)
                        return;
                    if (dgv_administrator.SelectedRows.Count == 1)
                    {
                        dgv_administrator.CurrentCell = dgv_administrator.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
    }
}
