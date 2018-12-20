﻿namespace FireProductManager.GuiPackage
{
    partial class PackageManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageManagement));
            this.la_barrrlid = new System.Windows.Forms.Label();
            this.tb_barrelid = new System.Windows.Forms.TextBox();
            this.bt_querypackage = new System.Windows.Forms.Button();
            this.dgv_instrumentinformation = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_changebarrel = new System.Windows.Forms.Button();
            this.la_productioncompany = new System.Windows.Forms.Label();
            this.tb_productioncompany = new System.Windows.Forms.TextBox();
            this.la_type = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.la_model = new System.Windows.Forms.Label();
            this.cb_IsInWareHouse = new System.Windows.Forms.ComboBox();
            this.la_IsInWareHouse = new System.Windows.Forms.Label();
            this.bt_dgvchangeexcel = new System.Windows.Forms.Button();
            this.cms_packageoperation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_newpackage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_updatepackage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_deletepackage = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_newpackage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_new = new System.Windows.Forms.ToolStripMenuItem();
            this.材料类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材料规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产厂商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产公司 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货架位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.初始重量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.在库状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instrumentinformation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.cms_packageoperation.SuspendLayout();
            this.cms_newpackage.SuspendLayout();
            this.SuspendLayout();
            // 
            // la_barrrlid
            // 
            this.la_barrrlid.AutoSize = true;
            this.la_barrrlid.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_barrrlid.Location = new System.Drawing.Point(523, 20);
            this.la_barrrlid.Name = "la_barrrlid";
            this.la_barrrlid.Size = new System.Drawing.Size(65, 20);
            this.la_barrrlid.TabIndex = 1;
            this.la_barrrlid.Text = "所在桶：";
            // 
            // tb_barrelid
            // 
            this.tb_barrelid.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_barrelid.Location = new System.Drawing.Point(594, 17);
            this.tb_barrelid.Name = "tb_barrelid";
            this.tb_barrelid.Size = new System.Drawing.Size(80, 26);
            this.tb_barrelid.TabIndex = 2;
            // 
            // bt_querypackage
            // 
            this.bt_querypackage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_querypackage.Location = new System.Drawing.Point(1187, 18);
            this.bt_querypackage.Name = "bt_querypackage";
            this.bt_querypackage.Size = new System.Drawing.Size(80, 26);
            this.bt_querypackage.TabIndex = 3;
            this.bt_querypackage.Text = "搜索";
            this.bt_querypackage.UseVisualStyleBackColor = true;
            this.bt_querypackage.Click += new System.EventHandler(this.bt_querypackage_Click);
            // 
            // dgv_instrumentinformation
            // 
            this.dgv_instrumentinformation.AllowUserToAddRows = false;
            this.dgv_instrumentinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_instrumentinformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.材料类型,
            this.材料规格,
            this.name,
            this.型号规格,
            this.生产厂商,
            this.生产公司,
            this.货架位置,
            this.初始重量,
            this.在库状态});
            this.dgv_instrumentinformation.Location = new System.Drawing.Point(73, 95);
            this.dgv_instrumentinformation.MultiSelect = false;
            this.dgv_instrumentinformation.Name = "dgv_instrumentinformation";
            this.dgv_instrumentinformation.RowTemplate.Height = 23;
            this.dgv_instrumentinformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_instrumentinformation.Size = new System.Drawing.Size(1273, 659);
            this.dgv_instrumentinformation.TabIndex = 4;
            this.dgv_instrumentinformation.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_instrumentinformation_CellMouseDoubleClick);
            this.dgv_instrumentinformation.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_instrumentinformation_CellMouseDown);
            this.dgv_instrumentinformation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_instrumentinformation_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_changebarrel);
            this.groupBox1.Controls.Add(this.la_productioncompany);
            this.groupBox1.Controls.Add(this.tb_productioncompany);
            this.groupBox1.Controls.Add(this.la_type);
            this.groupBox1.Controls.Add(this.tb_type);
            this.groupBox1.Controls.Add(this.tb_model);
            this.groupBox1.Controls.Add(this.la_model);
            this.groupBox1.Controls.Add(this.cb_IsInWareHouse);
            this.groupBox1.Controls.Add(this.la_IsInWareHouse);
            this.groupBox1.Controls.Add(this.bt_querypackage);
            this.groupBox1.Controls.Add(this.la_barrrlid);
            this.groupBox1.Controls.Add(this.tb_barrelid);
            this.groupBox1.Location = new System.Drawing.Point(73, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1273, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "材料搜索";
            // 
            // bt_changebarrel
            // 
            this.bt_changebarrel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_changebarrel.Location = new System.Drawing.Point(682, 18);
            this.bt_changebarrel.Name = "bt_changebarrel";
            this.bt_changebarrel.Size = new System.Drawing.Size(30, 26);
            this.bt_changebarrel.TabIndex = 78;
            this.bt_changebarrel.Text = "...";
            this.bt_changebarrel.UseVisualStyleBackColor = true;
            this.bt_changebarrel.Click += new System.EventHandler(this.bt_changebarrel_Click);
            // 
            // la_productioncompany
            // 
            this.la_productioncompany.AutoSize = true;
            this.la_productioncompany.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_productioncompany.Location = new System.Drawing.Point(759, 20);
            this.la_productioncompany.Name = "la_productioncompany";
            this.la_productioncompany.Size = new System.Drawing.Size(79, 20);
            this.la_productioncompany.TabIndex = 75;
            this.la_productioncompany.Text = "生产公司：";
            // 
            // tb_productioncompany
            // 
            this.tb_productioncompany.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_productioncompany.Location = new System.Drawing.Point(844, 17);
            this.tb_productioncompany.Name = "tb_productioncompany";
            this.tb_productioncompany.Size = new System.Drawing.Size(120, 26);
            this.tb_productioncompany.TabIndex = 76;
            // 
            // la_type
            // 
            this.la_type.AutoSize = true;
            this.la_type.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_type.Location = new System.Drawing.Point(47, 20);
            this.la_type.Name = "la_type";
            this.la_type.Size = new System.Drawing.Size(79, 20);
            this.la_type.TabIndex = 71;
            this.la_type.Text = "材料类型：";
            // 
            // tb_type
            // 
            this.tb_type.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_type.Location = new System.Drawing.Point(132, 17);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(110, 26);
            this.tb_type.TabIndex = 72;
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_model.Location = new System.Drawing.Point(370, 17);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(110, 26);
            this.tb_model.TabIndex = 22;
            // 
            // la_model
            // 
            this.la_model.AutoSize = true;
            this.la_model.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_model.Location = new System.Drawing.Point(286, 20);
            this.la_model.Name = "la_model";
            this.la_model.Size = new System.Drawing.Size(79, 20);
            this.la_model.TabIndex = 21;
            this.la_model.Text = "材料规格：";
            // 
            // cb_IsInWareHouse
            // 
            this.cb_IsInWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IsInWareHouse.FormattingEnabled = true;
            this.cb_IsInWareHouse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_IsInWareHouse.Items.AddRange(new object[] {
            "全部",
            "在库",
            "不在库"});
            this.cb_IsInWareHouse.Location = new System.Drawing.Point(1082, 20);
            this.cb_IsInWareHouse.Name = "cb_IsInWareHouse";
            this.cb_IsInWareHouse.Size = new System.Drawing.Size(58, 20);
            this.cb_IsInWareHouse.TabIndex = 19;
            // 
            // la_IsInWareHouse
            // 
            this.la_IsInWareHouse.AutoSize = true;
            this.la_IsInWareHouse.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_IsInWareHouse.Location = new System.Drawing.Point(1002, 20);
            this.la_IsInWareHouse.Name = "la_IsInWareHouse";
            this.la_IsInWareHouse.Size = new System.Drawing.Size(79, 20);
            this.la_IsInWareHouse.TabIndex = 6;
            this.la_IsInWareHouse.Text = "在库状态：";
            // 
            // bt_dgvchangeexcel
            // 
            this.bt_dgvchangeexcel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_dgvchangeexcel.Location = new System.Drawing.Point(1266, 760);
            this.bt_dgvchangeexcel.Name = "bt_dgvchangeexcel";
            this.bt_dgvchangeexcel.Size = new System.Drawing.Size(80, 25);
            this.bt_dgvchangeexcel.TabIndex = 6;
            this.bt_dgvchangeexcel.Text = "导出Excel";
            this.bt_dgvchangeexcel.UseVisualStyleBackColor = true;
            this.bt_dgvchangeexcel.Click += new System.EventHandler(this.bt_dgvchangeexcel_Click);
            // 
            // cms_packageoperation
            // 
            this.cms_packageoperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_newpackage,
            this.tsm_updatepackage,
            this.tsm_deletepackage});
            this.cms_packageoperation.Name = "cms_packageoperation";
            this.cms_packageoperation.Size = new System.Drawing.Size(101, 70);
            // 
            // tsm_newpackage
            // 
            this.tsm_newpackage.Name = "tsm_newpackage";
            this.tsm_newpackage.Size = new System.Drawing.Size(100, 22);
            this.tsm_newpackage.Text = "添加";
            this.tsm_newpackage.Click += new System.EventHandler(this.tsm_newpackage_Click);
            // 
            // tsm_updatepackage
            // 
            this.tsm_updatepackage.Name = "tsm_updatepackage";
            this.tsm_updatepackage.Size = new System.Drawing.Size(100, 22);
            this.tsm_updatepackage.Text = "修改";
            this.tsm_updatepackage.Click += new System.EventHandler(this.tsm_updatepackage_Click);
            // 
            // tsm_deletepackage
            // 
            this.tsm_deletepackage.Name = "tsm_deletepackage";
            this.tsm_deletepackage.Size = new System.Drawing.Size(100, 22);
            this.tsm_deletepackage.Text = "删除";
            this.tsm_deletepackage.Click += new System.EventHandler(this.tsm_deletepackage_Click);
            // 
            // cms_newpackage
            // 
            this.cms_newpackage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_new});
            this.cms_newpackage.Name = "cms_newpackage";
            this.cms_newpackage.Size = new System.Drawing.Size(101, 26);
            // 
            // tsm_new
            // 
            this.tsm_new.Name = "tsm_new";
            this.tsm_new.Size = new System.Drawing.Size(100, 22);
            this.tsm_new.Text = "添加";
            this.tsm_new.Click += new System.EventHandler(this.tsm_newpackage_Click);
            // 
            // 材料类型
            // 
            this.材料类型.HeaderText = "材料类型";
            this.材料类型.Name = "材料类型";
            this.材料类型.Width = 150;
            // 
            // 材料规格
            // 
            this.材料规格.HeaderText = "材料规格";
            this.材料规格.Name = "材料规格";
            this.材料规格.ReadOnly = true;
            this.材料规格.Width = 210;
            // 
            // name
            // 
            this.name.HeaderText = "重量（g）";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // 型号规格
            // 
            this.型号规格.HeaderText = "所在桶";
            this.型号规格.Name = "型号规格";
            this.型号规格.ReadOnly = true;
            this.型号规格.Width = 110;
            // 
            // 生产厂商
            // 
            this.生产厂商.HeaderText = "在库状态";
            this.生产厂商.Name = "生产厂商";
            this.生产厂商.ReadOnly = true;
            // 
            // 生产公司
            // 
            this.生产公司.HeaderText = "生产公司";
            this.生产公司.Name = "生产公司";
            this.生产公司.Width = 210;
            // 
            // 货架位置
            // 
            this.货架位置.HeaderText = "生产日期";
            this.货架位置.Name = "货架位置";
            this.货架位置.ReadOnly = true;
            this.货架位置.Width = 150;
            // 
            // 初始重量
            // 
            this.初始重量.HeaderText = "初始重量(g)";
            this.初始重量.Name = "初始重量";
            this.初始重量.Width = 150;
            // 
            // 在库状态
            // 
            this.在库状态.HeaderText = "材料ID";
            this.在库状态.Name = "在库状态";
            this.在库状态.ReadOnly = true;
            this.在库状态.Visible = false;
            this.在库状态.Width = 90;
            // 
            // PackageManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 832);
            this.Controls.Add(this.bt_dgvchangeexcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_instrumentinformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PackageManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InstrumentManagement";
            this.Load += new System.EventHandler(this.index_instrument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instrumentinformation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cms_packageoperation.ResumeLayout(false);
            this.cms_newpackage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label la_barrrlid;
        private System.Windows.Forms.TextBox tb_barrelid;
        private System.Windows.Forms.Button bt_querypackage;
        public System.Windows.Forms.DataGridView dgv_instrumentinformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label la_IsInWareHouse;
        private System.Windows.Forms.ComboBox cb_IsInWareHouse;
        private System.Windows.Forms.Label la_model;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label la_type;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Button bt_dgvchangeexcel;
        private System.Windows.Forms.ContextMenuStrip cms_packageoperation;
        private System.Windows.Forms.ToolStripMenuItem tsm_newpackage;
        private System.Windows.Forms.ToolStripMenuItem tsm_updatepackage;
        private System.Windows.Forms.ToolStripMenuItem tsm_deletepackage;
        private System.Windows.Forms.ContextMenuStrip cms_newpackage;
        private System.Windows.Forms.ToolStripMenuItem tsm_new;
        private System.Windows.Forms.Label la_productioncompany;
        private System.Windows.Forms.TextBox tb_productioncompany;
        private System.Windows.Forms.Button bt_changebarrel;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产厂商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产公司;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货架位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 初始重量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 在库状态;
    }
}