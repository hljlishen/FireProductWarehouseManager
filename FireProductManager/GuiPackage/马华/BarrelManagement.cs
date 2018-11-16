using DbLink;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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
            tb_showaddbarrelid.Text = BarrelGateway.RecordNewBarrel().ToString();
        }

        private void btn_removebarrel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认删除该桶吗?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                BarrelGateway.RemoveBarrel(barrelid1);
            lab_showbarrelid1.Text = "";
            dgv_packageshow1.Rows.Clear();
        }

        private void btn_querybarrel1_Click(object sender, EventArgs e)
        {
            lab_showbarrelid1.Text = "";
            queryBarrel = new QueryBarrel();
            queryBarrel.FormBorderStyle = FormBorderStyle.None;
            queryBarrel.BarrelIdSelected += BarrelIdSelected1;
            queryBarrel.ShowDialog();
            queryBarrel.BarrelIdSelected -= BarrelIdSelected1;
        }

        private void btn_querybarrel2_Click(object sender, EventArgs e)
        {
            lab_showbarrelid2.Text = "";
            queryBarrel = new QueryBarrel();
            queryBarrel.FormBorderStyle = FormBorderStyle.None;
            queryBarrel.BarrelIdSelected += BarrelIdSelected2;
            queryBarrel.ShowDialog();
            queryBarrel.BarrelIdSelected -= BarrelIdSelected2;
        }

        private void BarrelIdSelected1(List<string> barrelIds)
        {
            foreach (var id in barrelIds)
            {
                lab_showbarrelid1.Text += id;
            }
            lab_showbarrelid1.Text = lab_showbarrelid1.Text.Substring(0, lab_showbarrelid1.Text.Length);
            barrelid1 =int.Parse(lab_showbarrelid1.Text.Substring(0, lab_showbarrelid1.Text.Length - 2));
            BarrelIdQueryPackageMessage(barrelid1);
        }

        private void BarrelIdSelected2(List<string> barrelIds)
        {
            foreach (var id in barrelIds)
            {
                lab_showbarrelid2.Text += id;
            }
            lab_showbarrelid2.Text = lab_showbarrelid2.Text.Substring(0, lab_showbarrelid2.Text.Length);
            barrelid2 = int.Parse(lab_showbarrelid2.Text.Substring(0, lab_showbarrelid2.Text.Length - 2));
            BarrelIdQueryPackageMessage(barrelid2);
        }

        private void ShowDataGridView(DataTable dt)
        {
            dgv_packageshow1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgv_packageshow1.Rows.Add(row);
                dgv_packageshow1.Rows[index].Cells[0].Value = dr["pa_id"];
                dgv_packageshow1.Rows[index].Cells[1].Value = dr["pa_modle"];
                dgv_packageshow1.Rows[index].Cells[2].Value = dr["pa_weigth"];
            }
        }

        private void BarrelManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void BarrelIdQueryPackageMessage(int barrelid)
        {
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_barrelId", barrelid));
            string sql = maker.MakeSelectSql();
            ShowDataGridView(BarrelGateway.Query(sql));
            //ShowDataGridView(PackageGateway.Query(sql));
        }
    }
}
