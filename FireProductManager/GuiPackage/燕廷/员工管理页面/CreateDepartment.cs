using DbLink;
using FireProductManager.EntityPackage;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    public partial class CreateDepartment : Form
    {

        private int _parentnodeid;
        private int _id;

        //添加节点
        public CreateDepartment(int id,string nodeType)
        {
            InitializeComponent();
            _parentnodeid = id;
            la_nodenametext.Text = nodeType;
            bt_alter.Visible = false;
        }

        //重命名
        public CreateDepartment(int parentnodeid, int id)
        {
            InitializeComponent();
            _parentnodeid = parentnodeid;
            _id = id;
            bt_sure.Visible = false;
        }

        public CreateDepartment()
        {
            InitializeComponent();
        }

        //确认
        private void bt_sure_Click(object sender, EventArgs e)
        {
            DepartmentGateway.AddDepartment(tb_nodename.Text, _parentnodeid);
            DialogResult = DialogResult.OK;
        }

        //修改
        private void bt_alter_Click(object sender, EventArgs e)
        {
            DepartmentGateway.UpdateDepartment(_id, tb_nodename.Text, _parentnodeid);
            DialogResult = DialogResult.OK;
        }

        //返回节点名称
        public string nodeName
        {
            get { return tb_nodename.Text.Trim(); }
        }

        //取消
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GetDepartmentNodeName_Load(object sender, EventArgs e)
        {

        }
    }
}
