using DbLink;
using FireProductManager.EntityPackage;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static cangku_01.view.AdminPage.AutoCloseMassageBox;

//员工信息的添加、修改

namespace cangku_01.view.EmployeesManagement
{
    public partial class AddOrUpdateEmployee : Form
    {
        ImageManager getSetImagePath = new ImageManager();
        private Employee _employee = new Employee();
        private EmployeeManagement _employeefrom;
        private string _companyname;
        private string _departmentname;
        private string _groupname;
        private int _index;

        //添加页面状态
        public AddOrUpdateEmployee(EmployeeManagement form)
        {
            InitializeComponent();

            _employeefrom = form;

            bt_alteremployee.Visible = false;
            
            pb_employeephoto.Image = Image.FromFile(getSetImagePath.DefualtEmployeeImagePath);
        }

        //修改页面状态
        public AddOrUpdateEmployee(EmployeeManagement from , Employee employee, string company, string department, string group ,int index)
        {
            InitializeComponent();

            _employeefrom = from;
            _index = index;
            La_addoralter.Text = "修改员工";
            tb_employeesid.Text = employee.em_employeenumber.ToString();
            tb_name.Text = employee.em_name;
            if (employee.em_sex.Equals("男"))
            {
                Rb_sexman.Checked = true;
            }
            else
            {
                Rb_sexwoman.Checked = true;
            }
            la_company.Text = company;
            la_department.Text = department;
            la_group.Text = group;
            pb_employeephoto.Image = Image.FromFile(getSetImagePath.GetEmployeeImagePath(employee.em_employeenumber));

            Bt_addemployee.Visible = false;
            tb_employeesid.ReadOnly = true;  
        }

        //加载部门树状图
        private void AddOrAlterEmployees_Load(object sender, EventArgs e)
        {
            tv_departmentshow.Nodes.Clear();
            DepartmentGateway.LoadTreeView(tv_departmentshow,0);
            tv_departmentshow.ExpandAll();
        }

        //添加员工
        private void Bt_addemployee_Click(object sender, EventArgs e)
        {
            if (!FormValidation(EmployeeGateway.FormValidation(_employee))) return;
            GetEmployeeInformation();
            EmployeeGateway.AddEmployee(_employee);

            getSetImagePath.SaveEmployeeImage(_employee.em_employeenumber);
            AutoClosingMessageBox.Show("员工信息添加成功", "员工信息添加", 1000);
            _index = _employeefrom.dgv_employeeinformation.Rows.Add();
            AddOneEmployeeToTheDataGridView();
            Close();
        }

        //获取员工信息
        public void GetEmployeeInformation()
        {
            _employee.em_employeenumber = tb_employeesid.Text.ToString();
            _employee.em_name = tb_name.Text.ToString();
            if (Rb_sexman.Checked) _employee.em_sex = "男";
            else _employee.em_sex = "女";
            _companyname = la_company.Text;
            _departmentname = la_department.Text;
            _groupname = la_group.Text;
        }

        //给DataGridView添加一行数据
        public void AddOneEmployeeToTheDataGridView()
        {
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[0].Value = _employee.em_employeenumber;
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[1].Value = _employee.em_name;
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[2].Value = _employee.em_sex;
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[3].Value = _companyname;
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[4].Value = _departmentname;
            _employeefrom.dgv_employeeinformation.Rows[_index].Cells[5].Value = _groupname;
        }

        //员工信息修改
        private void bt_alteremployee_Click(object sender, EventArgs e)
        {
            //if (!FormValidation()) return;
            //GetEmployeeInformation();

            //if (_employee.em_departmentId == 0)
            //{
            //    DataTable dt = _employee.EmployeeNumberFindEmployee();
            //    DataRow myDr = dt.Rows[0];
            //    _employee.DepartmentId = (int)myDr["em_departmentid"];
            //}
            //_companyname = la_company.Text;
            //_departmentname = la_department.Text;
            //_groupname = la_group.Text;
            //dao.UpdateEmployee(_employee);
            //pb_employeephoto.Image.Dispose();
            //getSetImagePath.SaveEmployeeImage(_employee.EmployeeNumber);
            //AutoClosingMessageBox.Show("员工信息修改成功", "员工信息修改", 1000);
            //Employee employee = new Employee();
            //DataTable datatable = employee.QueryAllEmployee();//将全部员工加载
            //_employeefrom.ShowDataGridView(datatable);
            //Close();
        }

        //选择员工的公司、部门、小组信息
        private void tv_departmentshow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tv_departmentshow.SelectedNode.Level != 2) //确定选中到部门
            {
                AutoClosingMessageBox.Show("为精确到小组", "为精确到小组", 500);
                return;
            }
            la_group.Text = tv_departmentshow.SelectedNode.Text;
            la_department.Text = tv_departmentshow.SelectedNode.Parent.Text;
            la_company.Text = tv_departmentshow.SelectedNode.Parent.Parent.Text;
            _employee.em_departmentId = (int)tv_departmentshow.SelectedNode.Tag;
        }

        //表单验证
        private bool FormValidation(Dictionary<string, string> dictionary)
        {
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            return false;
        }

        //浏览图片
        private void pb_employeephoto_MouseClick(object sender, MouseEventArgs e)
        {
            string imagepath = getSetImagePath.GetBrowseImagePath();
            if (imagepath.Equals("")) return;
            pb_employeephoto.Image.Dispose();
            pb_employeephoto.Image = Image.FromFile(imagepath);
        }

        //清空图片组件缓存
        private void AddOrUpdateEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            pb_employeephoto.Image.Dispose();
        }
    }
}
