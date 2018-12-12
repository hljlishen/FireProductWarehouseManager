using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

//添加仪器  观察者模式

namespace FireProductManager.GuiPackage
{
    public partial class AddOrUpdatePackage : Form 
    {
        private int _id;
        private string _name;
        private string _model;
        private double _weigth;
        private int _barrelId;
        private string _isinWarehouse;
        private DateTime _purchaseTime;
        private int _projectId;

        private void AddOrModifyInstrument_Load(object sender, EventArgs e)
        {

        }

        //添加材料构造方法
        public AddOrUpdatePackage()
        {
            InitializeComponent();
            title.Text = "添加材料基本信息";
            cb_isInWareHouse.Text = "在库";
            bt_alterinstrument.Visible = false;
        }

        //修改材料构造方法
        public AddOrUpdatePackage(int packageid)
        {
            InitializeComponent();
            title.Text = "修改材料基本信息";
            bt_addinstrument.Visible = false;
            _id = packageid;
            InstrumentMessageDataTableShowTextBox();
        }

        //仪器信息展示在页面组件中
        public void InstrumentMessageDataTableShowTextBox()
        {
            DataTable dataTable = PackageGateway.GetPackageInformation(_id);
            DataRow myDr = dataTable.Rows[0];
            tb_name.Text = myDr["pa_name"].ToString();
            tb_model.Text = myDr["pa_model"].ToString();
            tb_weigth.Text = myDr["pa_weight"].ToString();
            tb_barrel.Text = myDr["pa_barrelId"].ToString();
            cb_isInWareHouse.Text = PackageGateway.IsinWarehouseDataTypeChangeString((int)myDr["pa_isinWarehouse"]);
            time_purchaseTime.Text = myDr["pa_purchaseTime"].ToString();
            tb_projectpassword.Text = myDr["pa_projectId"].ToString(); 
        }

        //取消按钮
        private void bt_close_Click_1(object sender, EventArgs e)     
        {
            Close();
        }

        //仪器信息添加
        private void bt_addinstrument_Click(object sender, EventArgs e)    
        {
            GetPackageInformation();
            PackageGateway.NewPackage(_name,_model,_weigth,_projectId,_isinWarehouse,_purchaseTime,_projectId);
            AutoClosingMessageBox.Show("仪器信息保存成功", "仪器信息添加", 1000);
            ResetPageInformation();
            PrintQRCode printQRCode = new PrintQRCode(PackageGateway.GetLastPackage());
        }

        //重置页面信息
        public void ResetPageInformation()
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)//考虑是文本框的话
                {
                    ((TextBox)ctr).Text = String.Empty;
                }
            }
            cb_isInWareHouse.Text = "入库";
        }

        //获取仪器信息
        public void GetPackageInformation()
        {
            _name = tb_name.Text;
            _model = tb_model.Text;
            _weigth = Convert.ToDouble(tb_weigth.Text);
            _barrelId = Convert.ToInt32(tb_barrel.Text);
            _isinWarehouse = cb_isInWareHouse.Text;
            _purchaseTime = Convert.ToDateTime(time_purchaseTime.Text);
        }

        //材料信息修改
        private void bt_alterpackage_Click(object sender, EventArgs e)
        {
            GetPackageInformation();
            PackageGateway.UpdatePackage(_id,_name, _model, _weigth, _projectId, _isinWarehouse, _purchaseTime, _projectId);
            AutoClosingMessageBox.Show("材料信息修改成功", "仪器信息修改", 1000);
            Close();
        }

        //选择通位置
        private void bt_showshelves_Click(object sender, EventArgs e)
        {
            //ShelvesTreeView shelvesTreeView = new ShelvesTreeView();
            //if (shelvesTreeView.ShowDialog() == DialogResult.OK)
            //{
            //    tb_position.Text = shelvesTreeView.locationName;
            //    placeidcoding = shelvesTreeView.PlaceIdCoding;
            //}
        }

        //选择项目令号
        private void bt_changeprojectpassword_Click(object sender, EventArgs e)
        {
            ProjectManageme projectManageme = new ProjectManageme();
            projectManageme.FormBorderStyle = FormBorderStyle.FixedSingle;
            projectManageme.ProjectSelecteds += ProjectSelecteds;
            projectManageme.ShowDialog();
            projectManageme.ProjectSelecteds -= ProjectSelecteds;
        }

        //显示项目令号
        private void ProjectSelecteds(int projectid, string projectpassword)
        {
            _projectId = projectid;
            tb_projectpassword.Text = projectpassword;
        }
    }
} 
