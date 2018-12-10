using FireProductManager.ServiceLogicPackage;
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
    public partial class AddOrUpdateProject : Form
    {
        private uint _projectid;

        //项目添加构造方法
        public AddOrUpdateProject()
        {
            InitializeComponent();
            la_addoralter.Text = "项目添加";

            bt_updateproject.Visible = false;
        }

        //项目修改构造方法
        public AddOrUpdateProject(int projectid)
        {
            InitializeComponent();
            la_addoralter.Text = "项目修改";

            _projectid = (uint)projectid;
            ShowProjectInformation();

            Bt_addproject.Visible = false;
        }

        //项目信息修改
        private void bt_updateproject_Click(object sender, EventArgs e)
        {
            ProjectGateway.UpdateProject(_projectid,tb_name.Text, tb_projectpassword.Text, tb_note.Text);
            Close();
        }

        //项目信息添加
        private void Bt_addproject_Click(object sender, EventArgs e)
        {
            ProjectGateway.NewProject(tb_name.Text,tb_projectpassword.Text,tb_note.Text);
            Close();
        }

        //员工信息展示
        private void ShowProjectInformation()
        {
            DataTable dataTable = ProjectGateway.GetProjectInformation(_projectid);
            DataRow myDr = dataTable.Rows[0];
            tb_name.Text = myDr["pr_name"].ToString();
            tb_projectpassword.Text = myDr["pr_projectpassword"].ToString();
            tb_note.Text = myDr["pr_note"].ToString();
        }

        private void AddOrUpdateProject_Load(object sender, EventArgs e)
        {

        }
    }
}
