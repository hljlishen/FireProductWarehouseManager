using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

namespace FireProductManager.GuiPackage
{
    public partial class BarrelManagement : Form
    {
        int barrelid1;
        int barrelid2;

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
            tb_showaddbarrelid.Text = BarrelGateway.RecordNewBarrel().ToString() + "号桶";
        }

        private void btn_removebarrel_Click(object sender, EventArgs e)
        {
            if (!BarrelGateway.IsBarrelInExistPackage(barrelid1))
            {
                ConfirmRemoveBarrel(barrelid1);
                lab_showbarrelid1.Text = "";
                barrelid1 = 0;
                dgv_packageshow1.Rows.Clear();
            }
            else
                AutoClosingMessageBox.Show("        该桶内有袋子，不能删除", "存在袋子", 2000);
        }

        private void btn_querybarrel1_Click(object sender, EventArgs e)
        {
            lab_showbarrelid1.Text = "";
            queryBarrel = new QueryBarrel();
            queryBarrel.FormBorderStyle = FormBorderStyle.FixedSingle;
            queryBarrel.BarrelIdSelected += BarrelIdSelected1;
            queryBarrel.ShowDialog();
            queryBarrel.BarrelIdSelected -= BarrelIdSelected1;
        }

        private void btn_querybarrel2_Click(object sender, EventArgs e)
        {
            lab_showbarrelid2.Text = "";
            queryBarrel = new QueryBarrel();
            queryBarrel.FormBorderStyle = FormBorderStyle.FixedSingle;
            queryBarrel.BarrelIdSelected += BarrelIdSelected2;
            queryBarrel.ShowDialog();
            queryBarrel.BarrelIdSelected -= BarrelIdSelected2;
        }

        private void BarrelIdSelected1(int barrelId)
        {
            barrelid1 = barrelId;
            lab_showbarrelid1.Text = barrelId.ToString() + "号桶";
            ShowDataGridView1(BarrelGateway.BarrelIdQueryPackageInformation(barrelid1));
        }

        private void BarrelIdSelected2(int barrelId)
        {
            barrelid2 = barrelId;
            lab_showbarrelid2.Text = barrelId.ToString() + "号桶";
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
            BarrelIdSelected1(barrelid1);
            BarrelIdSelected2(barrelid2);
        }
    }
}
