using FireProductManager.ServiceLogicPackage;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class AddOrUpdateAdministratorManagement : Form
    {
        int accoundid;

        public AddOrUpdateAdministratorManagement()
        {
            InitializeComponent();
            btn_add.Visible = true;
            btn_update.Visible = false;
            FirstPerform();
        }

        public void FirstPerform()
        {
            TextBoxCheckShow();
            StartPosition = FormStartPosition.CenterScreen;
            ShowDataGridView(AccountManager.GetAllAccount());
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
                    int accoundid =(int)dgv_administrator.CurrentRow.Cells[0].Value;
                    AccountManager.RemoveAccount(accoundid);
                    AutoClosingMessageBox.Show("            管理员删除成功", "删除管理员", 1000);
                    dgv_administrator.Rows.RemoveAt(e.RowIndex);//从DGV移除
                }
            }
            //修改
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    la_title.Text = "修改管理员信息";
                    btn_add.Visible = false;
                    btn_update.Visible = true;
                    //获取要修改属性
                    accoundid = (int)dgv_administrator.CurrentRow.Cells[0].Value;
                    tb_account.Text = dgv_administrator.CurrentRow.Cells[1].Value.ToString();
                    tb_password.Text = dgv_administrator.CurrentRow.Cells[2].Value.ToString();
                    cb_authority.Text = dgv_administrator.CurrentRow.Cells[3].Value.ToString();
                }
            }
        }

        private void btn_add_Click(object sender, System.EventArgs e)
        {
            TextBoxCheckShow();
            if (!TextBoxCheck())
                return;

            AccountManager.AddAccount(tb_account.Text, tb_password.Text, int.Parse(cb_authority.Text));
            AutoClosingMessageBox.Show("                添加成功", "添加管理员", 1000);
            EmptyTextBox();
            FirstPerform();
        }

        private void btn_update_Click(object sender, System.EventArgs e)
        {
            TextBoxCheckShow();
            if (!TextBoxCheck())
                return;

            AccountManager.UpdateAccount(accoundid, tb_account.Text, tb_password.Text, int.Parse(cb_authority.Text));
            AutoClosingMessageBox.Show("                修改成功", "修改管理员", 1000);
            EmptyTextBox();
            FirstPerform();
        }

        private void btn_addaccount_Click(object sender, System.EventArgs e)
        {
            EmptyTextBox();
            la_title.Text = " 添加管理员信息";
            btn_add.Visible = true;
            btn_update.Visible = false;
        }

        private void EmptyTextBox()
        {
            tb_account.Text = "";
            tb_password.Text = "";
            cb_authority.Text = "";
        }

        private bool TextBoxCheck()
        {
            bool validation = true;
            if (tb_account.Text == "")
            {
                la_accountcheck.Visible = true;
                validation = false;
            }
            else la_accountcheck.Visible = false;
            if (tb_password.Text == "")
            {
                la_passwordcheck.Visible = true;
                validation = false;
            }
            else la_passwordcheck.Visible = false;
            if (cb_authority.Text == "")
            {
                la_authoritycheck.Visible = true;
                validation = false;
            }
            else la_passwordcheck.Visible = false;
            return validation;
        }

        private void TextBoxCheckShow()
        {
            la_accountcheck.Visible = false;
            la_authoritycheck.Visible = false;
            la_passwordcheck.Visible = false;
        }
    }
}
