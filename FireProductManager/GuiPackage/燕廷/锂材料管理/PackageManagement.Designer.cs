namespace FireProductManager.GuiPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageManagement));
            this.bt_addpackage = new System.Windows.Forms.Button();
            this.la_barrrlid = new System.Windows.Forms.Label();
            this.tb_barrdlid = new System.Windows.Forms.TextBox();
            this.bt_querypackage = new System.Windows.Forms.Button();
            this.dgv_instrumentinformation = new System.Windows.Forms.DataGridView();
            this.材料名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产厂商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货架位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目令号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.在库状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.la_project = new System.Windows.Forms.Label();
            this.tb_project = new System.Windows.Forms.TextBox();
            this.la_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.la_model = new System.Windows.Forms.Label();
            this.cb_IsInWareHouse = new System.Windows.Forms.ComboBox();
            this.la_IsInWareHouse = new System.Windows.Forms.Label();
            this.bt_dgvchangeexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instrumentinformation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_addpackage
            // 
            this.bt_addpackage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_addpackage.Location = new System.Drawing.Point(1266, 33);
            this.bt_addpackage.Name = "bt_addpackage";
            this.bt_addpackage.Size = new System.Drawing.Size(80, 45);
            this.bt_addpackage.TabIndex = 0;
            this.bt_addpackage.Text = "添加仪器";
            this.bt_addpackage.UseVisualStyleBackColor = true;
            this.bt_addpackage.Click += new System.EventHandler(this.button1_Click);
            // 
            // la_barrrlid
            // 
            this.la_barrrlid.AutoSize = true;
            this.la_barrrlid.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_barrrlid.Location = new System.Drawing.Point(472, 20);
            this.la_barrrlid.Name = "la_barrrlid";
            this.la_barrrlid.Size = new System.Drawing.Size(65, 20);
            this.la_barrrlid.TabIndex = 1;
            this.la_barrrlid.Text = "所在桶：";
            // 
            // tb_barrdlid
            // 
            this.tb_barrdlid.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_barrdlid.Location = new System.Drawing.Point(551, 17);
            this.tb_barrdlid.Name = "tb_barrdlid";
            this.tb_barrdlid.Size = new System.Drawing.Size(120, 26);
            this.tb_barrdlid.TabIndex = 2;
            // 
            // bt_querypackage
            // 
            this.bt_querypackage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_querypackage.Location = new System.Drawing.Point(1091, 16);
            this.bt_querypackage.Name = "bt_querypackage";
            this.bt_querypackage.Size = new System.Drawing.Size(79, 30);
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
            this.材料名称,
            this.ID,
            this.name,
            this.型号规格,
            this.生产厂商,
            this.货架位置,
            this.项目令号,
            this.Column1,
            this.Column2,
            this.在库状态});
            this.dgv_instrumentinformation.Location = new System.Drawing.Point(73, 95);
            this.dgv_instrumentinformation.MultiSelect = false;
            this.dgv_instrumentinformation.Name = "dgv_instrumentinformation";
            this.dgv_instrumentinformation.RowTemplate.Height = 23;
            this.dgv_instrumentinformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_instrumentinformation.Size = new System.Drawing.Size(1273, 659);
            this.dgv_instrumentinformation.TabIndex = 4;
            this.dgv_instrumentinformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_instrumentinformation_CellContentClick);
            // 
            // 材料名称
            // 
            this.材料名称.HeaderText = "材料名称";
            this.材料名称.Name = "材料名称";
            this.材料名称.Width = 160;
            // 
            // ID
            // 
            this.ID.HeaderText = "材料型号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "重量（g）";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // 型号规格
            // 
            this.型号规格.HeaderText = "所在桶";
            this.型号规格.Name = "型号规格";
            this.型号规格.ReadOnly = true;
            // 
            // 生产厂商
            // 
            this.生产厂商.HeaderText = "在库状态";
            this.生产厂商.Name = "生产厂商";
            this.生产厂商.ReadOnly = true;
            this.生产厂商.Width = 130;
            // 
            // 货架位置
            // 
            this.货架位置.HeaderText = "入库时间";
            this.货架位置.Name = "货架位置";
            this.货架位置.ReadOnly = true;
            this.货架位置.Width = 200;
            // 
            // 项目令号
            // 
            this.项目令号.HeaderText = "项目令号";
            this.项目令号.Name = "项目令号";
            this.项目令号.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "删除";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "删除";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "修改";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "修改";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 120;
            // 
            // 在库状态
            // 
            this.在库状态.HeaderText = "材料ID";
            this.在库状态.Name = "在库状态";
            this.在库状态.ReadOnly = true;
            this.在库状态.Visible = false;
            this.在库状态.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.la_project);
            this.groupBox1.Controls.Add(this.tb_project);
            this.groupBox1.Controls.Add(this.la_name);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.tb_model);
            this.groupBox1.Controls.Add(this.la_model);
            this.groupBox1.Controls.Add(this.cb_IsInWareHouse);
            this.groupBox1.Controls.Add(this.la_IsInWareHouse);
            this.groupBox1.Controls.Add(this.bt_querypackage);
            this.groupBox1.Controls.Add(this.la_barrrlid);
            this.groupBox1.Controls.Add(this.tb_barrdlid);
            this.groupBox1.Location = new System.Drawing.Point(73, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仪器搜索";
            // 
            // la_project
            // 
            this.la_project.AutoSize = true;
            this.la_project.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_project.Location = new System.Drawing.Point(852, 20);
            this.la_project.Name = "la_project";
            this.la_project.Size = new System.Drawing.Size(79, 20);
            this.la_project.TabIndex = 73;
            this.la_project.Text = "项目命号：";
            // 
            // tb_project
            // 
            this.tb_project.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_project.Location = new System.Drawing.Point(937, 17);
            this.tb_project.Name = "tb_project";
            this.tb_project.Size = new System.Drawing.Size(126, 26);
            this.tb_project.TabIndex = 74;
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(44, 20);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(79, 20);
            this.la_name.TabIndex = 71;
            this.la_name.Text = "材料名称：";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(123, 17);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(126, 26);
            this.tb_name.TabIndex = 72;
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_model.Location = new System.Drawing.Point(346, 17);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(120, 26);
            this.tb_model.TabIndex = 22;
            // 
            // la_model
            // 
            this.la_model.AutoSize = true;
            this.la_model.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_model.Location = new System.Drawing.Point(261, 20);
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
            this.cb_IsInWareHouse.Location = new System.Drawing.Point(757, 20);
            this.cb_IsInWareHouse.Name = "cb_IsInWareHouse";
            this.cb_IsInWareHouse.Size = new System.Drawing.Size(66, 20);
            this.cb_IsInWareHouse.TabIndex = 19;
            // 
            // la_IsInWareHouse
            // 
            this.la_IsInWareHouse.AutoSize = true;
            this.la_IsInWareHouse.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_IsInWareHouse.Location = new System.Drawing.Point(677, 20);
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
            // PackageManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 840);
            this.Controls.Add(this.bt_dgvchangeexcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_instrumentinformation);
            this.Controls.Add(this.bt_addpackage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PackageManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InstrumentManagement";
            this.Load += new System.EventHandler(this.index_instrument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instrumentinformation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_addpackage;
        private System.Windows.Forms.Label la_barrrlid;
        private System.Windows.Forms.TextBox tb_barrdlid;
        private System.Windows.Forms.Button bt_querypackage;
        public System.Windows.Forms.DataGridView dgv_instrumentinformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label la_IsInWareHouse;
        private System.Windows.Forms.ComboBox cb_IsInWareHouse;
        private System.Windows.Forms.Label la_model;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_dgvchangeexcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产厂商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货架位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目令号;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 在库状态;
        private System.Windows.Forms.Label la_project;
        private System.Windows.Forms.TextBox tb_project;
    }
}