using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static FireProductManager.GuiPackage.AutoCloseMassageBox;

//材料的添加、修改

namespace FireProductManager.GuiPackage
{
    public partial class AddOrUpdatePackage : Form 
    {
        private PackageManagement _packagefrom;

        private int _id;
        private string _type;
        private string _specifications;
        private double _weigth;
        private int _barrelId;
        private string _isinWarehouse;
        private string _productionCompany;
        private DateTime _purchaseTime;

        private void AddOrModifyInstrument_Load(object sender, EventArgs e)
        {

        }

        //添加材料构造方法
        public AddOrUpdatePackage(PackageManagement packageManagement)
        {
            InitializeComponent();
            title.Text = "添加材料基本信息";

            _packagefrom = packageManagement;

            cb_isInWareHouse.Text = "在库";
            bt_alterinstrument.Visible = false;
            la_beginningweight.Visible = false;
            tb_beginningweight.Visible = false;
        }

        //修改材料构造方法
        public AddOrUpdatePackage(int packageid, PackageManagement packageManagement)
        {
            InitializeComponent();
            title.Text = "修改材料基本信息";

            _packagefrom = packageManagement;

            bt_addinstrument.Visible = false;
            tb_beginningweight.ReadOnly = true;

            _id = packageid;
            InstrumentMessageDataTableShowTextBox();
        }

        //材料信息展示在页面组件中
        private void InstrumentMessageDataTableShowTextBox()
        {
            DataTable dataTable = PackageGateway.GetPackageInformation(_id);
            DataRow myDr = dataTable.Rows[0];
            tb_type.Text = myDr["pa_type"].ToString();
            tb_specifications.Text = myDr["pa_specifications"].ToString();
            tb_weigth.Text = myDr["pa_weight"].ToString();
            tb_barrel.Text = myDr["pa_barrelId"].ToString();
            cb_isInWareHouse.Text = PackageGateway.IsinWarehouseDataTypeChangeString((int)myDr["pa_isinWarehouse"]);
            tb_productioncompany.Text = myDr["pa_productionCompany"].ToString();
            time_purchaseTime.Text = myDr["pa_purchaseTime"].ToString();
            tb_beginningweight.Text = myDr["pa_beginningweight"].ToString();
        }

        //取消按钮
        private void bt_close_Click_1(object sender, EventArgs e)     
        {
            Close();
        }

        //材料信息添加
        private void bt_addinstrument_Click(object sender, EventArgs e)    
        {
            GetPackageInformation();
            if (!FormValidation()) return;
            PackageGateway.NewPackage(_type,_specifications,_weigth, _barrelId, _isinWarehouse,_productionCompany,_purchaseTime);
            AutoClosingMessageBox.Show("材料信息保存成功", "仪器信息添加", 1000);
            ResetPageInformation();
            PrintQRCode printQRCode = new PrintQRCode(PackageGateway.GetLastPackage());
            _packagefrom.ShowAllPackage();
        }

        //重置页面信息
        private void ResetPageInformation()
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

        //获取材料信息
        private void GetPackageInformation()
        {
            _type = tb_type.Text;
            _specifications = tb_specifications.Text;
            if (tb_weigth.Text.Equals("")) return;
            _weigth = Convert.ToDouble(tb_weigth.Text);
            if (tb_barrel.Text.Equals("")) return;
            _barrelId = Convert.ToInt32(tb_barrel.Text);
            _isinWarehouse = cb_isInWareHouse.Text;
            _productionCompany = tb_productioncompany.Text;
            _purchaseTime = Convert.ToDateTime(time_purchaseTime.Text);
        }

        //材料信息修改
        private void bt_alterpackage_Click(object sender, EventArgs e)
        {
            GetPackageInformation();
            if (!FormValidation()) return;
            PackageGateway.UpdatePackage(_id,_type, _specifications, _weigth, _barrelId, _isinWarehouse, _productionCompany, _purchaseTime);
            AutoClosingMessageBox.Show("材料信息修改成功", "材料信息修改", 1000);
            _packagefrom.ShowAllPackage();
            Close();
        }

        //表单验证
        private bool FormValidation()
        {
            bool validation = true;

            if (tb_type.Text.Trim().Equals(""))
            {
                la_errortype.Visible = true;
                la_errortype.ForeColor = Color.Red;
                validation = false;
            }
            else la_errortype.Visible = false;

            if (tb_specifications.Text.Trim().Equals(""))
            {
                la_errorspecifications.Visible = true;
                la_errorspecifications.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorspecifications.Visible = false;

            if (tb_weigth.Text.Trim().Equals(""))
            {
                la_errorweigth.Visible = true;
                la_errorweigth.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorweigth.Visible = false;

            if (tb_barrel.Text.Trim().Equals(""))
            {
                la_errorbarrel.Visible = true;
                la_errorbarrel.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorbarrel.Visible = false;

            if (tb_productioncompany.Text.Trim().Equals(""))
            {
                la_errorproductioncompany.Visible = true;
                la_errorproductioncompany.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorproductioncompany.Visible = false;

            return validation;
        }

        //选择通位置
        private void bt_showshelves_Click(object sender, EventArgs e)
        {
            QueryBarrel queryBarrel = new QueryBarrel();
            queryBarrel.FormBorderStyle = FormBorderStyle.FixedSingle;
            queryBarrel.BarrelIdSelected += BarrelIdSelected;
            queryBarrel.ShowDialog();
            queryBarrel.BarrelIdSelected -= BarrelIdSelected;
        }

        //显示桶编号
        private void BarrelIdSelected(int barrelid)
        {
            tb_barrel.Text = barrelid.ToString();
        }
    }
} 
