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
        private int _projectid;
        private ProjectManageme _projectfrom;

        private enum Operation
        {
            Update,
            New,
        }

        //项目添加构造方法
        public AddOrUpdateProject(ProjectManageme projectManageme)
        {
            InitializeComponent();
            la_addoralter.Text = "项目添加";

            _projectfrom = projectManageme;

            bt_updateproject.Visible = false;
        }

        //项目修改构造方法
        public AddOrUpdateProject(int projectid, ProjectManageme projectManageme)
        {
            InitializeComponent();
            la_addoralter.Text = "项目修改";

            _projectfrom = projectManageme;
            _projectid = projectid;
            ShowProjectInformation();

            bt_addproject.Visible = false;
        }

        //项目信息修改
        private void bt_updateproject_Click(object sender, EventArgs e)
        {
            if (!FormValidation(Operation.Update)) return;
            ProjectGateway.UpdateProject(_projectid,tb_name.Text, tb_projectpassword.Text, tb_note.Text);
            _projectfrom.ShowAllProject();
            Close();
        }

        //项目信息添加
        private void Bt_addproject_Click(object sender, EventArgs e)
        {
            if (!FormValidation(Operation.New)) return;
            ProjectGateway.NewProject(tb_name.Text,tb_projectpassword.Text,tb_note.Text);
            _projectfrom.ShowAllProject();
            Close();
        }

        //表单验证
        private bool FormValidation(Operation operation)
        {
            bool validation = true;

            if (tb_name.Text.Trim().Equals(""))
            {
                la_errorname.Visible = true;
                la_errorname.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorname.Visible = false;

            if (tb_projectpassword.Text.Trim().Equals(""))
            {
                la_errorprojectpassword.Visible = true;
                la_errorprojectpassword.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorprojectpassword.Visible = false;

            switch (operation)
            {
                case Operation.New:
                    if (!(ProjectGateway.NewValidationProjectPassWord(tb_projectpassword.Text)))
                    {
                        la_projectpasswordrepeat.Visible = true;
                        la_projectpasswordrepeat.ForeColor = Color.Red;
                        validation = false;
                    }
                    else la_projectpasswordrepeat.Visible = false;
                    break;

                case Operation.Update:
                    if (!(ProjectGateway.UpdateValidationProjectPassWord(_projectid, tb_projectpassword.Text)))
                    {
                        la_projectpasswordrepeat.Visible = true;
                        la_projectpasswordrepeat.ForeColor = Color.Red;
                        validation = false;
                    }
                    else la_projectpasswordrepeat.Visible = false;
                    break;
            }

            if (tb_note.Text.Trim().Equals(""))
            {
                la_errornote.Visible = true;
                la_errornote.ForeColor = Color.Red;
                validation = false;
            }
            else la_errornote.Visible = false;

            return validation;
        }

        //项目信息展示
        private void ShowProjectInformation()
        {
            DataTable dataTable = ProjectGateway.GetProjectInformation(_projectid);
            DataRow myDr = dataTable.Rows[0];
            tb_name.Text = myDr["pr_name"].ToString();
            tb_projectpassword.Text = myDr["pr_projectpassword"].ToString();
            tb_note.Text = myDr["pr_note"].ToString();
        }
    }
}
