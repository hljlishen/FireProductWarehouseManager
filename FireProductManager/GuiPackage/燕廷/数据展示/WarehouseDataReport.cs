using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FireProductManager.ServiceLogicPackage;

namespace FireProductManager.GuiPackage
{
    public partial class WarehouseDataReport : Form
    {
        List<string> list_X = new List<string>();
        List<double> list_Y = new List<double>();

        string str = Directory.GetCurrentDirectory();

        ProjectManageme selectProject;
        private int projectid;

        public WarehouseDataReport()
        {
            InitializeComponent();
        }

        private void WarehouseDataReport_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            WarehouseProcurement();
        }
        
        private void tc_datareport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_datareport.SelectedTab.Name == "tp_warehouseprocurement")
            {
                WarehouseProcurement();
            }

            if (tc_datareport.SelectedTab.Name == "tp_warehousemargi")
            {
                PackageDosage();
            }

            if (tc_datareport.SelectedTab.Name == "tp_warehousemargin")
            {
                WarehouseMargin();
            }

            if (tc_datareport.SelectedTab.Name == "tp_projectdosage")
            {
                ProjectDosage();
            }
        }

        //材料入库量
        private void WarehouseProcurement()
        {
            ClearData();
            Dictionary<string, double> keyValuePairs = PackageGateway.StatisticAllModelBeginningWeightsInWarehouse();
            ChangeArray(keyValuePairs);
            TwoDimensionalTable a = new TwoDimensionalTable(wb_warehouse, "cylindrical", list_X, list_Y);
        }

        //材料用量
        private void PackageDosage()
        {
            ClearData();
            Dictionary<string, double> keyValuePairs = PackageGateway.GetPackageDosage();
            ChangeArray(keyValuePairs);
            TwoDimensionalTable a = new TwoDimensionalTable(wb_project, "cylindrical", list_X, list_Y);
            TwoDimensionalTable a1 = new TwoDimensionalTable(webBrowser1, "sector", list_X, list_Y);
        }

        //材料余量
        private void WarehouseMargin()
        {
            ClearData();
            Dictionary<string, double> keyValuePairs = PackageGateway.StatisticAllModelWeightsInWarehouse();
            ChangeArray(keyValuePairs);
            TwoDimensionalTable a = new TwoDimensionalTable(wb_warehousemargin , "cylindrical", list_X,list_Y);
        }

        //项目用量
        private void ProjectDosage()
        {
            ClearData();
            if (projectid == 0) return;
            Dictionary<string, double> keyValuePairs = PackageGateway.GetProjectPackageDosage((uint)projectid);
            ChangeArray(keyValuePairs);
            TwoDimensionalTable a = new TwoDimensionalTable(webBrowser3, "cylindrical", list_X, list_Y);
            TwoDimensionalTable a1 = new TwoDimensionalTable(webBrowser2, "sector", list_X, list_Y);

        }

        private void ClearData()
        {
            list_X.Clear();
            list_Y.Clear();
        }

        public void ChangeArray(Dictionary<string, double> keyValuePairs)
        {
            foreach (var item in keyValuePairs)
            {
                list_X.Add(item.Key);
                list_Y.Add(item.Value);
            }
        }

        private void bt_showbarrel_Click(object sender, EventArgs e)
        {
            selectProject = new ProjectManageme();
            selectProject.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectProject.ProjectSelecteds += ProjectSelected;
            selectProject.ShowDialog();
            selectProject.ProjectSelecteds -= ProjectSelected;
        }

        private void ProjectSelected(int id, string projectPassword)
        {
            tb_project.Text = "";
            tb_project.Text = projectPassword;
            projectid = id;
            ProjectDosage();
        }
    }
}
