using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    //仪器出入库查询页面
    public partial class PackageBorrowRecord : Form
    {
        public PackageBorrowRecord()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void PackageBorrowRecord_Load(object sender, EventArgs e)
        {
            cb_directquery.Text = "出入库";
            //选择时间查询
            cb_choicetime.MouseClick += cb_choicetime_MouseClick;


        }

        //DataGridView显示数据
        private void ShowDataGridView(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {

            }
        }

        //点击勾选框选择时间查询
        private void cb_choicetime_MouseClick(object sender, MouseEventArgs e)
        {
            if (cb_choicetime.Checked.Equals(true))
            {
                dtp_begin.Enabled = true;
                dtp_end.Enabled = true;
            }
            else
            {
                dtp_begin.Enabled = false;
                dtp_end.Enabled = false;
            }
        }

        //导出Excel表
        private void btn_exceloperator_Click(object sender, EventArgs e)
        {
            ExcelOperator.DataGridViewToExcel(dgv_PackageInAndOutrecord, true);
        }
    }
}
