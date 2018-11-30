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
        //项目添加构造方法
        public AddOrUpdateProject()
        {
            InitializeComponent();
            la_addoralter.Text = "项目添加";
        }

        //项目修改构造方法
        public AddOrUpdateProject(uint projectid)
        {
            InitializeComponent();
            la_addoralter.Text = "项目修改";
        }

        //项目信息修改
        private void bt_updateproject_Click(object sender, EventArgs e)
        {

        }

        //项目信息添加
        private void Bt_addproject_Click(object sender, EventArgs e)
        {
            ProjectGateway.NewProject(tb_name.Text,tb_projectpassword.Text,tb_note.Text);
            Close();
        }
    }
}
