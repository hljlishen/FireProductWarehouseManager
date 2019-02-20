using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
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
        ElectronicScaleDevice ScaleDevice;
        delegate void WeightGettedHandler(double weight);

        private int _oldbarrelId;

        private int _id;
        private string _type;
        private string _specifications;
        private double _suttle;
        private int _barrelId;
        private string _isinWarehouse;
        private string _productionCompany;
        private DateTime _purchaseTime;
        private double _tareweight;
        private string _note;
        private int _packagenumber;

        private void AddOrModifyInstrument_Load(object sender, EventArgs e)
        {
            ScaleDevice = Ahdr.CreateInstance();
            ScaleDevice.WeightGetted += Ahdr_WeightGetted;
        }

        //添加材料构造方法
        public AddOrUpdatePackage(PackageManagement packageManagement)
        {
            InitializeComponent();
            title.Text = "添加材料基本信息";
            ShowManufacturer();

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
            ShowManufacturer();

            _packagefrom = packageManagement;

            bt_addinstrument.Visible = false;

            la_weigth.Visible = false;
            tb_weight.Visible = false;

            _id = packageid;
            InstrumentMessageDataTableShowTextBox();
        }

        public void ShowManufacturer()
        {
            DataTable dataTable = SystemDictionaryGateway.GetQueryDictionaryTypeText("生产厂商");
            tb_productioncompany.DataSource = SystemDictionaryGateway.DataTableChangeList(dataTable);
        }

        //材料信息展示在页面组件中
        private void InstrumentMessageDataTableShowTextBox()
        {
            DataTable dataTable = PackageGateway.GetPackageInformation(_id);
            DataRow myDr = dataTable.Rows[0];
            tb_type.Text = myDr["pa_type"].ToString();
            tb_specifications.Text = myDr["pa_specifications"].ToString();
            tb_suttle.Text = myDr["pa_suttle"].ToString();
            tb_barrel.Text = myDr["pa_barrelId"].ToString();
            _oldbarrelId = (int)myDr["pa_barrelId"];
            cb_isInWareHouse.Text = PackageGateway.IsinWarehouseDataTypeChangeString((int)myDr["pa_isinWarehouse"]);
            tb_productioncompany.Text = myDr["pa_productionCompany"].ToString();
            time_purchaseTime.Text = myDr["pa_purchaseTime"].ToString();
            tb_beginningweight.Text = myDr["pa_beginningweight"].ToString();
            tb_tareweight.Text = myDr["pa_tareweight"].ToString();
            tb_note.Text = myDr["pa_note"].ToString();
        }

        //取消按钮
        private void bt_close_Click_1(object sender, EventArgs e)     
        {
            Close();
        }

        private void Ahdr_WeightGetted(double weight)
        {
            if (IsHandleCreated)
                Invoke(new WeightGettedHandler(UpdateWeight), new object[] { weight });
        }

        private void UpdateWeight(double weight)
        {     
            tb_weight.Text = weight.ToString();
        }

        //材料信息添加
        private void bt_addinstrument_Click(object sender, EventArgs e)    
        {
            if (!FormValidation()) return;
            GetPackageInformation();
            PackageGateway.NewPackage(_type, _specifications, _suttle, _barrelId, _isinWarehouse, _productionCompany, _purchaseTime, _tareweight, _note);
            AutoClosingMessageBox.Show("材料信息保存成功", "仪器信息添加", 1000);
            ResetPageInformation();
            PrintQRCode printQRCode = new PrintQRCode(PackageGateway.GetLastPackage());
            _packagefrom.ShowAllPackage();
        }

        //重置页面信息
        private void ResetPageInformation()
        {
            tb_suttle.Text = "";
            tb_tareweight.Text = "";
        }

        //获取材料信息
        private void GetPackageInformation()
        {
            _type = tb_type.Text;
            _specifications = tb_specifications.Text;
            if (title.Text.Equals("修改材料基本信息"))
                _suttle = Convert.ToDouble(tb_suttle.Text);
            else
                GetPackageWeight();
            _barrelId = Convert.ToInt32(tb_barrel.Text);
            _isinWarehouse = cb_isInWareHouse.Text;
            _productionCompany = tb_productioncompany.Text;
            _purchaseTime = Convert.ToDateTime(time_purchaseTime.Text);
            _note = tb_note.Text;
        }

        //材料初始重量计算
        private void GetPackageWeight()
        {
            if (tb_tareweight.Text.Trim().Equals("") && !tb_suttle.Text.Trim().Equals(""))
            {
                _tareweight = (Convert.ToDouble(tb_weight.Text) - Convert.ToDouble(tb_suttle.Text));
                tb_tareweight.Text = _tareweight.ToString();
                _suttle = Convert.ToDouble(tb_suttle.Text);
            }
            if (!tb_tareweight.Text.Trim().Equals("") && tb_suttle.Text.Trim().Equals(""))
            {
                tb_suttle.Text = (Convert.ToDouble(tb_weight.Text) - Convert.ToDouble(tb_tareweight.Text)).ToString();
                _suttle = Convert.ToDouble(tb_weight.Text) - Convert.ToDouble(tb_tareweight.Text);
                _tareweight = Convert.ToDouble(tb_tareweight.Text);
            }
        }

        //材料信息修改
        private void bt_alterpackage_Click(object sender, EventArgs e)
        {
            GetPackageInformation();
            if (!FormValidation()) return;
            PackageGateway.UpdatePackage(_id,_type, _specifications, _suttle, _barrelId, _isinWarehouse, _productionCompany, _purchaseTime, _tareweight, _note);
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

            if (HasBarrelFull(_barrelId) && _barrelId != 0)
            {
                la_errorfull.Visible = true;
                la_errorfull.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorfull.Visible = false;

            if (title.Text.Equals("修改材料基本信息")) return validation;

            if (tb_weight.Text.Trim().Equals(""))
            {
                la_errorweigth.Visible = true;
                la_errorweigth.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorweigth.Visible = false;

            if (tb_tareweight.Text.Trim().Equals("") && tb_suttle.Text.Trim().Equals(""))
            {
                la_errorpackageweightnull_1.Visible = true;
                la_errorpackageweightnull_1.ForeColor = Color.Red;
                la_errorpackageweightnull_2.Visible = true;
                la_errorpackageweightnull_2.ForeColor = Color.Red;
                validation = false;
            }
            else la_errorpackageweightnull_1.Visible = la_errorpackageweightnull_2.Visible = false;

            if (!(tb_tareweight.Text.Trim().Equals("")) && !(tb_suttle.Text.Trim().Equals("")))
            {
                la_towonlyone_1.Visible = true;
                la_towonlyone_1.ForeColor = Color.Red;
                la_towonlyone_2.Visible = true;
                la_towonlyone_2.ForeColor = Color.Red;
                validation = false;
            }
            else la_towonlyone_1.Visible = la_towonlyone_2.Visible = false;

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
        private void BarrelIdSelected(int barrelid,int packagenumber)
        {
            _packagenumber = packagenumber;
            _barrelId = barrelid;
            if (!(HasBarrelFull(barrelid)))
            {
                tb_barrel.Text = barrelid.ToString();
                la_errorfull.Visible = false;
                la_errorbarrel.Visible = false;
                return;
            }
            tb_barrel.Text = barrelid.ToString();
            la_errorfull.Visible = true;
            la_errorbarrel.Visible = false;
        }

        //查询桶是否装满
        private bool HasBarrelFull(int barrelid)
        {
            if (_oldbarrelId == barrelid) return false;
            if (BarrelGateway.SelectBarrelidPackageNumber(barrelid) + 1 <= _packagenumber) return false;
            return true;
        }

        //设置文本框只能输入数字
        private void tb_tareweight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46) && (e.KeyChar != 127))
            {
                e.Handled = true;
            }
        }

        private void tb_suttle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46) && (e.KeyChar != 127))
            {
                e.Handled = true;
            }
        }
    }
} 
