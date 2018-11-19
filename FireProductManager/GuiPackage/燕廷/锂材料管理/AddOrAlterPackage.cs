using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DbLink;

//添加仪器  观察者模式

namespace FireProductManager.GuiPackage
{
    public partial class AddOrUpdatePackage : Form 
    {
        private int dutyid;
        private string placeidcoding;
        private string alterplaceidcoding;
        EmployeeManagement selectEmployees;
        private PackageManagement fr;
        private int index;

        private void AddOrModifyInstrument_Load(object sender, EventArgs e)
        {

        }

        //仪器信息添加构造方法
        public AddOrUpdatePackage()
        {
            InitializeComponent();
            title.Text = "添加仪器基本信息";
            cb_isInWareHouse.Text = "在库";
            cb_state.Text = "启用";
            tb_tagid.ReadOnly = true;
            bt_alterinstrument.Visible = false;
            tb_isInWareHouse.Visible = false;
            tb_productionDate.Visible = false;
            tb_lastCheckTimes.Visible = false;
            cb_allcheckdate.Visible = false;
            la_allcheckdate.Visible = false;
            tb_state.Visible = false;
            //pb_instrumentphoto.Image = Image.FromFile(getSetImagePath.DefualtInstrumentImagePath);
            pb_instrumentphoto.MouseClick += pb_instrumentphoto_MouseClick;
        }

        private void ReaderAddDrive_TagConnected(string tagId)
        {
            tb_tagid.Text = tagId;
        }

        //仪器信息修改构造方法
        //public AddOrUpdatePackage()
        //{
        //    InitializeComponent();
        //    title.Text = "修改仪器基本信息";
        //    tb_tagid.ReadOnly = true;

        //    bt_addinstrument.Visible = false;
        //    tb_isInWareHouse.Visible = false;
        //    tb_productionDate.Visible = false;
        //    tb_lastCheckTimes.Visible = false;
        //    cb_allcheckdate.Visible = false;
        //    la_allcheckdate.Visible = false;
        //    tb_state.Visible = false;
        //    //pb_instrumentphoto.Image = Image.FromFile(getSetImagePath.GetInstrumentPhotoPath(ins.TagId));
        //    InstrumentMessageDataTableShowTextBox();
        //    pb_instrumentphoto.MouseClick += pb_instrumentphoto_MouseClick;
        //}

        //查看详情构造方法
        //public AddOrUpdatePackage(Instrument ins)
        //{
        //    InitializeComponent();
        //    title.Text = "查看仪器基本信息";
        //    bt_addinstrument.Visible = false;
        //    bt_alterinstrument.Visible = false;
        //    time_lastCheckTimes.Visible = false;
        //    time_productionDate.Visible = false;
        //    cb_isInWareHouse.Visible = false;
        //    bt_showshelves.Enabled = false;
        //    bt_selectduty.Enabled = false;
        //    cb_state.Visible = false;

        //    DataSet ds = dao.QueryInstrumentAllCheckDate(ins);
        //    cb_allcheckdate.DataSource = ds.Tables[0];
        //    cb_allcheckdate.DisplayMember = "ch_date";
        //    cb_allcheckdate.ValueMember = "ch_date";
        //    SettingAllTextBoxReadOnly();
        //    pb_instrumentphoto.Image = Image.FromFile(getSetImagePath.GetInstrumentPhotoPath(ins.TagId));
        //    InstrumentMessageDataTableShowTextBox();
        //}

        //设置页面信息为只读
        public void SettingAllTextBoxReadOnly()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).ReadOnly = true;
                }
            }
        }

        //仪器信息展示在页面组件中
        public void InstrumentMessageDataTableShowTextBox()
        {
            //InstrumentInterface dao = new InstrumentDataManipulation();
            //DataTable dt = dao.TagIdQueryInstrument(ins);
            //tb_tagid.Text = ins.TagId;
            //DataRow myDr = dt.Rows[0];
            //ins.Id = (int)myDr["in_id"];
            //tb_name.Text = myDr["in_name"].ToString();
            //tb_model.Text = myDr["in_model"].ToString();
            //tb_manufactor.Text = myDr["in_manufactor"].ToString();
            //tb_serialnumber.Text = myDr["in_serialnumber"].ToString();
            //ins.Position = myDr["in_position"].ToString();
            //tb_position.Text = ins.PlaceUnscramble();
            //placeidcoding = ins.Position;
            //alterplaceidcoding = ins.Position;
            //tb_checkcycle.Text = myDr["in_checkcycle"].ToString();
            //DutyInformation((int)myDr["in_duty"]);
            //dutyid = (int)myDr["in_duty"];
            //tb_usedmode.Text = myDr["in_usedmode"].ToString();
            //tb_remarks.Text = myDr["in_remarks"].ToString();
            //if (title.Text.Equals("查看仪器基本信息"))
            //{
            //    tb_productionDate.Text = ins.DateFormatConversion((DateTime)myDr["in_productiondate"]);
            //    tb_lastCheckTimes.Text = ins.DateFormatConversion((DateTime)myDr["in_lastchecktimes"]);
            //    tb_isInWareHouse.Text = myDr["in_isinwarehouse"].ToString();
            //    tb_state.Text = myDr["in_state"].ToString();
            //    return;
            //}
            //time_productionDate.Text = myDr["in_productiondate"].ToString();
            //time_lastCheckTimes.Text = myDr["in_lastchecktimes"].ToString();
            //cb_isInWareHouse.Text = myDr["in_isinwarehouse"].ToString();
            //cb_state.Text = myDr["in_state"].ToString();
        }

        //取消按钮
        private void bt_close_Click_1(object sender, EventArgs e)     
        {
            Close();
        }

        //仪器信息添加
        private void bt_addinstrument_Click(object sender, EventArgs e)    
        {
            //if (!FormValidation()) return;
            //InstrumentInterface dao = new InstrumentDataManipulation();
            //DataTable dt = dao.TagIdQueryInstrument(GetInstrumentInformation());
            //if (dt.Rows.Count != 0)
            //{
            //    AutoClosingMessageBox.Show("已存在该仪器TagId，误重复添加", "仪器信息添加重复", 1000);
            //    return;
            //}
            //string[] sArray = placeidcoding.Split(new char[1] { '-'});
            //int placeid = int.Parse(sArray[3]);
            //WarehouseLocation wa = new WarehouseLocation();
            //wa.id = placeid;
            //wa.instrumenttagid = tb_tagid.Text;
            //wa.AddInstrument();
            //dao.AddInstrument(GetInstrumentInformation());
            //getSetImagePath.SaveInstrumentImage(ins.TagId);
            //AutoClosingMessageBox.Show("仪器信息保存成功", "仪器信息添加", 1000);
            //index = fr.dgv_instrumentinformation.Rows.Add();
            //AddOneEmployeeToTheDataGridView();
            //ResetPageInformation();
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
        //public Instrument GetInstrumentInformation()
        //{
        //    ins.TagId = tb_tagid.Text;
        //    ins.Name = tb_name.Text;
        //    ins.Model = tb_model.Text;
        //    ins.Manufactor = tb_manufactor.Text;
        //    ins.SerialNumber = tb_serialnumber.Text;
        //    ins.ProductionDate = Convert.ToDateTime(time_productionDate.Text);
        //    ins.Position = placeidcoding;
        //    ins.IsInWareHouse = cb_isInWareHouse.Text;
        //    ins.CheckCycle = int.Parse(tb_checkcycle.Text);
        //    ins.LastCheckTime = Convert.ToDateTime(time_lastCheckTimes.Text);
        //    ins.Duty = dutyid;
        //    ins.UsedMode = tb_usedmode.Text;
        //    ins.State = cb_state.Text;
        //    ins.Remarks = tb_remarks.Text;
        //    return ins;
        //}

        //给DataGridView添加一行数据
        public void AddOneEmployeeToTheDataGridView()
        {
            //EmployeesInterface dao = new EmployeeDataManipulation();
            //Employee em = new Employee();
            //em.Id = ins.Duty;
            //DataTable dt = dao.IdQueryEmployee(em);
            //DataRow myDr = dt.Rows[0];
            //fr.dgv_instrumentinformation.Rows[index].Cells[0].Value = ins.TagId;
            //fr.dgv_instrumentinformation.Rows[index].Cells[1].Value = ins.Name;
            //fr.dgv_instrumentinformation.Rows[index].Cells[2].Value = ins.Model;
            //fr.dgv_instrumentinformation.Rows[index].Cells[3].Value = ins.Manufactor;
            //fr.dgv_instrumentinformation.Rows[index].Cells[4].Value = ins.PlaceUnscramble();
            //fr.dgv_instrumentinformation.Rows[index].Cells[5].Value = ins.IsInWareHouse;
            //fr.dgv_instrumentinformation.Rows[index].Cells[6].Value = ins.State;
            //fr.dgv_instrumentinformation.Rows[index].Cells[7].Value = ins.UsedMode;
            //fr.dgv_instrumentinformation.Rows[index].Cells[8].Value = myDr["em_name"].ToString();
            //fr.dgv_instrumentinformation.Rows[index].Cells[12].Value = ins.Id;
        }

        //仪器信息修改
        private void bt_alterinstrument_Click(object sender, EventArgs e)
        {
            //if (!FormValidation()) return;
            //if (!ins.TagId.Equals(tb_tagid.Text))
            //{
            //    InstrumentInterface dao = new InstrumentDataManipulation();
            //    DataTable dt = dao.TagIdQueryInstrument(GetInstrumentInformation());
            //    if (dt.Rows.Count != 0)
            //    {
            //        AutoClosingMessageBox.Show("已存在该仪器TagId，误重复添加", "仪器信息添加重复", 1000);
            //        return;
            //    }
            //}
            //WarehouseLocation wa1 = new WarehouseLocation();
            //string[] sArray1 = alterplaceidcoding.Split(new char[1] { '-' });
            //int alterplaceid = int.Parse(sArray1[3]);
            //wa1.id = alterplaceid;
            //wa1.IdAlterInstrument();
            //WarehouseLocation wa2 = new WarehouseLocation();
            //string[] sArray2 = placeidcoding.Split(new char[1] { '-' });
            //int placeid = int.Parse(sArray2[3]);
            //wa1.id = placeid;
            //wa1.instrumenttagid = tb_tagid.Text;
            //wa1.AddInstrument();
            //GetInstrumentInformation();
            //ins.UpdateInstrument();
            //getSetImagePath.SaveInstrumentImage(ins.TagId);
            //AutoClosingMessageBox.Show("仪器信息修改成功", "仪器信息修改", 1000);
            //GetWriteCardInformation();
            //fr.dgv_instrumentinformation.Rows.RemoveAt(index);
            //index = fr.dgv_instrumentinformation.Rows.Add();
            //AddOneEmployeeToTheDataGridView();
            //Close();
        }

        //选择货架位置
        private void bt_showshelves_Click(object sender, EventArgs e)
        {
            //ShelvesTreeView shelvesTreeView = new ShelvesTreeView();
            //if (shelvesTreeView.ShowDialog() == DialogResult.OK)
            //{
            //    tb_position.Text = shelvesTreeView.locationName;
            //    placeidcoding = shelvesTreeView.PlaceIdCoding;
            //}
        }

        //浏览图片
        private void pb_instrumentphoto_MouseClick(object sender, MouseEventArgs e)
        {
            //string imagepath = getSetImagePath.GetBrowseImagePath();
            //if (imagepath.Equals("")) return;
            //pb_instrumentphoto.Image.Dispose();
            //pb_instrumentphoto.Image = Image.FromFile(imagepath);
        }
    }
}
