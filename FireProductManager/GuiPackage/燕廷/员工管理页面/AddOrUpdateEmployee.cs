using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

//员工信息的添加、修改

namespace FireProductManager.GuiPackage
{
    public partial class AddOrUpdateEmployee : Form
    {
        ImageManager getSetImagePath = new ImageManager();
        private int _employeeid;
        private string _employeenumber;
        private string _name;
        private string _sex;
        private int _departmentid = -1;
        private string _companyname;
        private string _departmentname;
        private string _groupname;

        //添加页面状态
        public AddOrUpdateEmployee()
        {
            InitializeComponent();
            bt_updateemployee.Visible = false;
            pb_employeephoto.Image = Image.FromFile(getSetImagePath.DefualtEmployeeImagePath);
        }

        //修改页面状态
        public AddOrUpdateEmployee(int employeeId)
        {
            InitializeComponent();
            La_addoralter.Text = "修改员工";
            ShowEmployeeInformation(employeeId);
            Bt_addemployee.Visible = false; 
        }

        //加载部门树状图
        private void AddOrAlterEmployees_Load(object sender, EventArgs e)
        {
            tv_departmentshow.Nodes.Clear();
            DepartmentGateway.LoadTreeView(tv_departmentshow);
            tv_departmentshow.ExpandAll();
        }

        //员工信息展示
        private void ShowEmployeeInformation(int employeeid)
        {
            _employeeid = employeeid;
            _employeenumber = EmployeeGateway.GetEmployeeInformation(employeeid).em_employeenumber;
            _name = EmployeeGateway.GetEmployeeInformation(employeeid).em_name;
            _sex = EmployeeGateway.GetEmployeeInformation(employeeid).em_sex;
            _departmentid = EmployeeGateway.GetEmployeeInformation(employeeid).em_departmentid.Value;
            List<string> list = DepartmentGateway.ReadDepartmentNodeName(EmployeeGateway.GetEmployeeInformation(employeeid).em_departmentid.Value);
            _companyname = list[2];
            _departmentname = list[1];
            _groupname = list[0];

            tb_employeesnumber.Text = _employeenumber;
            tb_name.Text = _name;
            if (_sex.Equals("男"))
            {
                Rb_sexman.Checked = true;
            }
            else
            {
                Rb_sexwoman.Checked = true;
            }
            la_company.Text = list[2];
            la_department.Text = list[1];
            la_group.Text = list[0];

            pb_employeephoto.Image = Image.FromFile(getSetImagePath.GetEmployeeImagePath(EmployeeGateway.GetEmployeeInformation(employeeid).em_employeenumber));
        }

        //添加员工
        private void Bt_addemployee_Click(object sender, EventArgs e)
        {
            GetEmployeeInformation();
            EmployeeGateway.NewEmployee(_employeenumber,_name,_sex,_departmentid);
            getSetImagePath.SaveEmployeeImage(_employeenumber);
            AutoClosingMessageBox.Show("员工信息添加成功", "员工信息添加", 1000);
            Close();
        }

        //获取员工信息
        public void GetEmployeeInformation()
        {
            _employeenumber = tb_employeesnumber.Text.ToString();
            _name = tb_name.Text.ToString();
            if (Rb_sexman.Checked) _sex = "男";
            else _sex = "女";
        }

        //员工信息修改
        private void bt_alteremployee_Click(object sender, EventArgs e)
        {
            GetEmployeeInformation();
            EmployeeGateway.UpdateEmployee(_employeeid,_employeenumber,_name,_sex,_departmentid);
            pb_employeephoto.Image.Dispose();
            getSetImagePath.SaveEmployeeImage(_employeenumber);
            AutoClosingMessageBox.Show("员工信息修改成功", "员工信息修改", 1000);
            Close();
        }

        //选择员工的公司、部门、小组信息
        private void tv_departmentshow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tv_departmentshow.SelectedNode.Level != 3) //确定选中到部门
            {
                AutoClosingMessageBox.Show("为精确到小组", "为精确到小组", 500);
                return;
            }
            la_group.Text = tv_departmentshow.SelectedNode.Text;
            la_department.Text = tv_departmentshow.SelectedNode.Parent.Text;
            la_company.Text = tv_departmentshow.SelectedNode.Parent.Parent.Text;
            _departmentid = (int)tv_departmentshow.SelectedNode.Tag;
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
