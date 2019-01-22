using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class BarrelManagement : Form
    {
        int insertbarrelid = 0;
        int barrelid1;
        int barrelid2;
        int loadingCapacity1;
        int loadingCapacity2;

        QueryBarrel queryBarrel;

        public BarrelManagement()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!AccountManager.CanReadDatabase()) //没有用
            { 
                AutoClosingMessageBox.Show("           权限不足无法新建桶", "权限", 2000);
                return;
            }
            insertbarrelid = BarrelGateway.RecordNewBarrel();
            tb_showaddbarrelid.Text = insertbarrelid.ToString() + "号桶";
            tb_barrelLoadingCapacity.Text = "0";
        }

        private void btn_removebarrel_Click(object sender, EventArgs e)
        {
            if (!BarrelGateway.IsBarrelInExistPackage(barrelid1))
            {
                ConfirmRemoveBarrel(barrelid1);
                lab_showbarrelid1.Text = "";
                tb_delectbarrelLoadingCapacity1.Text = "";
                tb_barrelLoadingCapacity.Text = "";
                tb_showaddbarrelid.Text = "";
                la_number1.Text = "";
                barrelid1 = 0;
                dgv_packageshow1.Rows.Clear();
            }
            else
                AutoClosingMessageBox.Show("        该桶内有袋子，不能删除", "存在袋子", 2000);
        }

        private void btn_querybarrel1_Click(object sender, EventArgs e)
        {
            lab_showbarrelid1.Text = "";
            tb_barrelLoadingCapacity.Text = "";
            tb_showaddbarrelid.Text = "";
            queryBarrel = new QueryBarrel();
            queryBarrel.FormBorderStyle = FormBorderStyle.FixedSingle;
            queryBarrel.BarrelIdSelected += BarrelIdSelected1;
            queryBarrel.ShowDialog();
            queryBarrel.BarrelIdSelected -= BarrelIdSelected1;
        }

        private void btn_querybarrel2_Click(object sender, EventArgs e)
        {
            lab_showbarrelid2.Text = "";
            tb_barrelLoadingCapacity.Text = "";
            tb_showaddbarrelid.Text = "";
            queryBarrel = new QueryBarrel();
            queryBarrel.FormBorderStyle = FormBorderStyle.FixedSingle;
            queryBarrel.BarrelIdSelected += BarrelIdSelected2;
            queryBarrel.ShowDialog();
            queryBarrel.BarrelIdSelected -= BarrelIdSelected2;
        }

        private void BarrelIdSelected1(int barrelId,int loadingCapacity)
        {
            barrelid1 = barrelId;
            loadingCapacity1 = loadingCapacity;
            lab_showbarrelid1.Text = barrelId.ToString() + "号桶";
            tb_delectbarrelLoadingCapacity1.Text = loadingCapacity.ToString();
            la_number1.Text = BarrelGateway.SelectBarrelidPackageNumber(barrelId).ToString();
            ShowDataGridView1(BarrelGateway.BarrelIdQueryPackageInformation(barrelid1));
        }

        private void BarrelIdSelected2(int barrelId,int loadingCapacity)
        {
            barrelid2 = barrelId;
            loadingCapacity2 = loadingCapacity;
            lab_showbarrelid2.Text = barrelId.ToString() + "号桶";
            tb_delectbarrelLoadingCapacity2.Text = loadingCapacity.ToString();
            la_number2.Text = BarrelGateway.SelectBarrelidPackageNumber(barrelId).ToString();
            ShowDataGridView2(BarrelGateway.BarrelIdQueryPackageInformation(barrelid2));
        }

        private void ShowDataGridView1(DataTable dt)
        {
            dgv_packageshow1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_packageshow1.Rows.Add(row);
                dgv_packageshow1.Rows[index].Cells[0].Value = dr["pa_id"];
                dgv_packageshow1.Rows[index].Cells[1].Value = dr["pa_type"];
                dgv_packageshow1.Rows[index].Cells[2].Value = dr["pa_specifications"];
                dgv_packageshow1.Rows[index].Cells[3].Value = dr["pa_weight"] + "g";
            }
        }

        private void ShowDataGridView2(DataTable dt)
        {
            dgv_packageshow2.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_packageshow2.Rows.Add(row);
                dgv_packageshow2.Rows[index].Cells[0].Value = dr["pa_id"];
                dgv_packageshow2.Rows[index].Cells[1].Value = dr["pa_type"];
                dgv_packageshow2.Rows[index].Cells[2].Value = dr["pa_specifications"];
                dgv_packageshow2.Rows[index].Cells[3].Value = dr["pa_weight"] + "g";
            }
        }

        private void BarrelManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_exchangepackageid1_Click(object sender, EventArgs e)
        {
            if (barrelid1 == 0)
            {
                lab_showbarrelid1.Text = "";
                return;
            }
            if (barrelid2 == 0)
            {
                lab_showbarrelid2.Text = "";
                return;
            }
            if (loadingCapacity2 <= int.Parse(la_number2.Text))
            {
                AutoClosingMessageBox.Show("该桶存带数已达上限", "袋子已满", 2000);
                return;
            }
            for (int i = 0; i < dgv_packageshow1.Rows.Count; i++)
            {
                if (dgv_packageshow1.Rows[i].Selected)
                {
                    int packageids =(int)dgv_packageshow1.Rows[i].Cells[0].Value;
                    PackageGateway.PutPackageIntoBarrel(packageids,barrelid2);
                }
            }
            RefreshBarrel();
        }

        private void btn_removebarrel2_Click(object sender, EventArgs e)
        {
            if (!BarrelGateway.IsBarrelInExistPackage(barrelid2))
            {
                ConfirmRemoveBarrel(barrelid2);
                lab_showbarrelid2.Text = "";
                tb_delectbarrelLoadingCapacity2.Text = "";
                tb_barrelLoadingCapacity.Text = "";
                tb_showaddbarrelid.Text = "";
                la_number2.Text = "";
                barrelid2 = 0;
                dgv_packageshow2.Rows.Clear();
            }
            else
                AutoClosingMessageBox.Show("        该桶内有袋子，不能删除", "存在袋子", 2000);
        }

        private void btn_exchangepackageid2_Click(object sender, EventArgs e)
        {
            if (barrelid1 == 0)
            {
                lab_showbarrelid1.Text = "";
                return;
            }
            if (barrelid2 == 0)
            {
                lab_showbarrelid2.Text = "";
                return;
            }
            if (loadingCapacity1 <= int.Parse(la_number1.Text))
            {
                AutoClosingMessageBox.Show("该桶存带数已达上限", "袋子已满", 2000);
                return;
            }
            for (int i = 0; i < dgv_packageshow2.Rows.Count; i++)
            {
                if (dgv_packageshow2.Rows[i].Selected)
                {
                    int packageids = (int)dgv_packageshow2.Rows[i].Cells[0].Value;
                    PackageGateway.PutPackageIntoBarrel(packageids, barrelid1);
                }
            }
            RefreshBarrel();
        }

        //确定删除桶
        private void ConfirmRemoveBarrel(int barrelid)
        {
            if (barrelid == 0)
            {
                AutoClosingMessageBox.Show("        请先选择桶号在进行删除", "未选择桶号", 2000);
                return;
            }
            DialogResult result = MessageBox.Show("确认删除该桶吗?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BarrelGateway.RemoveBarrel(barrelid);
                AutoClosingMessageBox.Show("                   删除成功", "删除成功", 2000);
            }   
        }

        //刷新桶
        private void RefreshBarrel()
        {
            BarrelIdSelected1(barrelid1,loadingCapacity1);
            BarrelIdSelected2(barrelid2,loadingCapacity2);
        }

        private void btn_barrelLoadingCapacity_Click(object sender, EventArgs e)
        {
            if (tb_barrelLoadingCapacity.Text == "")
                return;
            BarrelGateway.UpdateLoadingCapacity(insertbarrelid,int.Parse(tb_barrelLoadingCapacity.Text));
            AutoClosingMessageBox.Show("                   设置成功", "设置成功", 1000);
            tb_barrelLoadingCapacity.Text = "";
            tb_showaddbarrelid.Text = "";
        }

        private void TextBoxNumber(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar <= 31))
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
                else
                    e.Handled = true;
            }
            else
            {
                if (e.KeyChar <= 31)
                {
                    e.Handled = false;
                }
                else if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    if (((TextBox)sender).Text.ToString() != "")
                    {
                        if (Convert.ToDouble(((TextBox)sender).Text) == 0)
                        {
                            if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                e.Handled = true;
                            }
                        }
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
        }

        private void tb_barrelLoadingCapacity_KeyPress(object sender, KeyPressEventArgs e) => TextBoxNumber(sender, e);

        private void tb_delectbarrelLoadingCapacity1_KeyPress(object sender, KeyPressEventArgs e) => TextBoxNumber(sender, e);

        private void tb_delectbarrelLoadingCapacity2_KeyPress(object sender, KeyPressEventArgs e) => TextBoxNumber(sender, e);

        private void btn_delectbarrelLoadingCapacity1_Click(object sender, EventArgs e)
        {
            if (tb_delectbarrelLoadingCapacity1.Text == "")
                return;
            if (int.Parse(la_number1.Text) > int.Parse(tb_delectbarrelLoadingCapacity1.Text))
            {
                AutoClosingMessageBox.Show("  修改失败，存储数量小于当前数量", "修改失败", 1000);
                return;
            }
            BarrelGateway.UpdateLoadingCapacity(barrelid1,int.Parse(tb_delectbarrelLoadingCapacity1.Text));
            AutoClosingMessageBox.Show("                   修改成功", "修改成功", 1000);
        }

        private void btn_delectbarrelLoadingCapacity2_Click(object sender, EventArgs e)
        {
            if (tb_delectbarrelLoadingCapacity2.Text == "")
                return;
            if (int.Parse(la_number2.Text) > int.Parse(tb_delectbarrelLoadingCapacity2.Text))
            {
                AutoClosingMessageBox.Show("  修改失败，存储数量小于当前数量", "修改失败", 1000);
                return;
            }
            BarrelGateway.UpdateLoadingCapacity(barrelid2,int.Parse(tb_delectbarrelLoadingCapacity2.Text));
            AutoClosingMessageBox.Show("                   修改成功", "修改成功", 1000);
        }
    }
}
