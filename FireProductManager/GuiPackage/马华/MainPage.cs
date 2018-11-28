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
    public partial class MainPage : Form
    {
        PackageBorrowRecord packageBorrowRecord = null;
        EmployeeManagement selectEmployees;
        QueryBarrel queryBarrel;

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            packageBorrowRecord = new PackageBorrowRecord();
            panel1.Dock = DockStyle.Bottom;
            packageBorrowRecord.TopLevel = false;
            packageBorrowRecord.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(packageBorrowRecord);
            packageBorrowRecord.Show();
        }

        private void btn_selectemployee_Click(object sender, EventArgs e)
        {
            selectEmployees = new EmployeeManagement();
            selectEmployees.FormBorderStyle = FormBorderStyle.FixedSingle;
            selectEmployees.EmployeesSelected += EmployeesSelected;
            selectEmployees.ShowDialog();
            selectEmployees.EmployeesSelected -= EmployeesSelected;
        }

        private void EmployeesSelected(int employeesId, string emNumbers)
        {
            tb_borrowName.Text = "";
            tb_borrowName.Text = employeesId.ToString();
        }

        private void btn_selectbarrelid_Click(object sender, EventArgs e)
        {
            queryBarrel = new QueryBarrel();
            queryBarrel.FormBorderStyle = FormBorderStyle.FixedSingle;
            queryBarrel.BarrelIdSelected += BarrelIdSelected;
            queryBarrel.ShowDialog();
            queryBarrel.BarrelIdSelected -= BarrelIdSelected;
        }

        private void BarrelIdSelected(int barrelId)
        {
            tb_barrelid.Text = "";
            tb_barrelid.Text = barrelId.ToString();
        }
    }
}
