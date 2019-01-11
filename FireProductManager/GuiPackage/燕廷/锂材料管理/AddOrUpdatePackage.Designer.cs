namespace FireProductManager.GuiPackage
{
    partial class AddOrUpdatePackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdatePackage));
            this.time_purchaseTime = new System.Windows.Forms.DateTimePicker();
            this.title = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_addinstrument = new System.Windows.Forms.Button();
            this.tb_barrel = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_specifications = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.la_isInWareHouse = new System.Windows.Forms.Label();
            this.la_barrel = new System.Windows.Forms.Label();
            this.la_purchaseTime = new System.Windows.Forms.Label();
            this.la_weigth = new System.Windows.Forms.Label();
            this.la_specifications = new System.Windows.Forms.Label();
            this.la_type = new System.Windows.Forms.Label();
            this.bt_alterinstrument = new System.Windows.Forms.Button();
            this.cb_isInWareHouse = new System.Windows.Forms.ComboBox();
            this.bt_showbarrel = new System.Windows.Forms.Button();
            this.la_errortype = new System.Windows.Forms.Label();
            this.la_errorspecifications = new System.Windows.Forms.Label();
            this.la_errorweigth = new System.Windows.Forms.Label();
            this.la_errorbarrel = new System.Windows.Forms.Label();
            this.la_errorproductioncompany = new System.Windows.Forms.Label();
            this.tb_productioncompany = new System.Windows.Forms.TextBox();
            this.la_productioncompany = new System.Windows.Forms.Label();
            this.tb_beginningweight = new System.Windows.Forms.TextBox();
            this.la_beginningweight = new System.Windows.Forms.Label();
            this.tb_packageweight = new System.Windows.Forms.TextBox();
            this.la_packageweight = new System.Windows.Forms.Label();
            this.la_errorpackageweight = new System.Windows.Forms.Label();
            this.la_errorpackageweightnull = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time_purchaseTime
            // 
            this.time_purchaseTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time_purchaseTime.Location = new System.Drawing.Point(498, 260);
            this.time_purchaseTime.Name = "time_purchaseTime";
            this.time_purchaseTime.Size = new System.Drawing.Size(183, 26);
            this.time_purchaseTime.TabIndex = 54;
            this.time_purchaseTime.Value = new System.DateTime(2018, 7, 19, 11, 11, 56, 0);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(336, 34);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 21);
            this.title.TabIndex = 53;
            // 
            // bt_close
            // 
            this.bt_close.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(446, 484);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(80, 30);
            this.bt_close.TabIndex = 52;
            this.bt_close.Text = "退出";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click_1);
            // 
            // bt_addinstrument
            // 
            this.bt_addinstrument.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_addinstrument.Location = new System.Drawing.Point(236, 484);
            this.bt_addinstrument.Name = "bt_addinstrument";
            this.bt_addinstrument.Size = new System.Drawing.Size(80, 30);
            this.bt_addinstrument.TabIndex = 51;
            this.bt_addinstrument.Text = "添加";
            this.bt_addinstrument.UseVisualStyleBackColor = true;
            this.bt_addinstrument.Click += new System.EventHandler(this.bt_addinstrument_Click);
            // 
            // tb_barrel
            // 
            this.tb_barrel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_barrel.Location = new System.Drawing.Point(498, 184);
            this.tb_barrel.Name = "tb_barrel";
            this.tb_barrel.ReadOnly = true;
            this.tb_barrel.Size = new System.Drawing.Size(147, 26);
            this.tb_barrel.TabIndex = 47;
            // 
            // tb_weight
            // 
            this.tb_weight.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_weight.Location = new System.Drawing.Point(180, 184);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.ReadOnly = true;
            this.tb_weight.Size = new System.Drawing.Size(183, 26);
            this.tb_weight.TabIndex = 46;
            // 
            // tb_specifications
            // 
            this.tb_specifications.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_specifications.Location = new System.Drawing.Point(498, 111);
            this.tb_specifications.Name = "tb_specifications";
            this.tb_specifications.Size = new System.Drawing.Size(183, 26);
            this.tb_specifications.TabIndex = 44;
            // 
            // tb_type
            // 
            this.tb_type.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_type.Location = new System.Drawing.Point(180, 111);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(183, 26);
            this.tb_type.TabIndex = 43;
            // 
            // la_isInWareHouse
            // 
            this.la_isInWareHouse.AutoSize = true;
            this.la_isInWareHouse.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_isInWareHouse.Location = new System.Drawing.Point(95, 350);
            this.la_isInWareHouse.Name = "la_isInWareHouse";
            this.la_isInWareHouse.Size = new System.Drawing.Size(79, 20);
            this.la_isInWareHouse.TabIndex = 38;
            this.la_isInWareHouse.Text = "在库状态：";
            // 
            // la_barrel
            // 
            this.la_barrel.AutoSize = true;
            this.la_barrel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_barrel.Location = new System.Drawing.Point(413, 188);
            this.la_barrel.Name = "la_barrel";
            this.la_barrel.Size = new System.Drawing.Size(79, 20);
            this.la_barrel.TabIndex = 37;
            this.la_barrel.Text = "所属桶号：";
            // 
            // la_purchaseTime
            // 
            this.la_purchaseTime.AutoSize = true;
            this.la_purchaseTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_purchaseTime.Location = new System.Drawing.Point(413, 265);
            this.la_purchaseTime.Name = "la_purchaseTime";
            this.la_purchaseTime.Size = new System.Drawing.Size(79, 20);
            this.la_purchaseTime.TabIndex = 36;
            this.la_purchaseTime.Text = "生产日期：";
            // 
            // la_weigth
            // 
            this.la_weigth.AutoSize = true;
            this.la_weigth.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_weigth.Location = new System.Drawing.Point(95, 187);
            this.la_weigth.Name = "la_weigth";
            this.la_weigth.Size = new System.Drawing.Size(88, 20);
            this.la_weigth.TabIndex = 34;
            this.la_weigth.Text = "质量（g）：";
            // 
            // la_specifications
            // 
            this.la_specifications.AutoSize = true;
            this.la_specifications.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_specifications.Location = new System.Drawing.Point(413, 114);
            this.la_specifications.Name = "la_specifications";
            this.la_specifications.Size = new System.Drawing.Size(79, 20);
            this.la_specifications.TabIndex = 33;
            this.la_specifications.Text = "材料规格：";
            // 
            // la_type
            // 
            this.la_type.AutoSize = true;
            this.la_type.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_type.Location = new System.Drawing.Point(95, 114);
            this.la_type.Name = "la_type";
            this.la_type.Size = new System.Drawing.Size(79, 20);
            this.la_type.TabIndex = 32;
            this.la_type.Text = "材料类型：";
            // 
            // bt_alterinstrument
            // 
            this.bt_alterinstrument.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_alterinstrument.Location = new System.Drawing.Point(236, 484);
            this.bt_alterinstrument.Name = "bt_alterinstrument";
            this.bt_alterinstrument.Size = new System.Drawing.Size(80, 30);
            this.bt_alterinstrument.TabIndex = 58;
            this.bt_alterinstrument.Text = "修改";
            this.bt_alterinstrument.UseVisualStyleBackColor = true;
            this.bt_alterinstrument.Click += new System.EventHandler(this.bt_alterpackage_Click);
            // 
            // cb_isInWareHouse
            // 
            this.cb_isInWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_isInWareHouse.FormattingEnabled = true;
            this.cb_isInWareHouse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_isInWareHouse.Items.AddRange(new object[] {
            "在库",
            "不在库"});
            this.cb_isInWareHouse.Location = new System.Drawing.Point(180, 350);
            this.cb_isInWareHouse.Name = "cb_isInWareHouse";
            this.cb_isInWareHouse.Size = new System.Drawing.Size(84, 20);
            this.cb_isInWareHouse.TabIndex = 59;
            // 
            // bt_showbarrel
            // 
            this.bt_showbarrel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_showbarrel.Location = new System.Drawing.Point(651, 184);
            this.bt_showbarrel.Name = "bt_showbarrel";
            this.bt_showbarrel.Size = new System.Drawing.Size(30, 26);
            this.bt_showbarrel.TabIndex = 68;
            this.bt_showbarrel.Text = "...";
            this.bt_showbarrel.UseVisualStyleBackColor = true;
            this.bt_showbarrel.Click += new System.EventHandler(this.bt_showshelves_Click);
            // 
            // la_errortype
            // 
            this.la_errortype.AutoSize = true;
            this.la_errortype.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errortype.ForeColor = System.Drawing.Color.Red;
            this.la_errortype.Location = new System.Drawing.Point(177, 140);
            this.la_errortype.Name = "la_errortype";
            this.la_errortype.Size = new System.Drawing.Size(97, 17);
            this.la_errortype.TabIndex = 103;
            this.la_errortype.Text = "*材料名不能为空";
            this.la_errortype.Visible = false;
            // 
            // la_errorspecifications
            // 
            this.la_errorspecifications.AutoSize = true;
            this.la_errorspecifications.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorspecifications.ForeColor = System.Drawing.Color.Red;
            this.la_errorspecifications.Location = new System.Drawing.Point(495, 140);
            this.la_errorspecifications.Name = "la_errorspecifications";
            this.la_errorspecifications.Size = new System.Drawing.Size(109, 17);
            this.la_errorspecifications.TabIndex = 104;
            this.la_errorspecifications.Text = "*规格型号不能为空";
            this.la_errorspecifications.Visible = false;
            // 
            // la_errorweigth
            // 
            this.la_errorweigth.AutoSize = true;
            this.la_errorweigth.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorweigth.ForeColor = System.Drawing.Color.Red;
            this.la_errorweigth.Location = new System.Drawing.Point(178, 213);
            this.la_errorweigth.Name = "la_errorweigth";
            this.la_errorweigth.Size = new System.Drawing.Size(97, 17);
            this.la_errorweigth.TabIndex = 105;
            this.la_errorweigth.Text = "*未获得材料重量";
            this.la_errorweigth.Visible = false;
            // 
            // la_errorbarrel
            // 
            this.la_errorbarrel.AutoSize = true;
            this.la_errorbarrel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorbarrel.ForeColor = System.Drawing.Color.Red;
            this.la_errorbarrel.Location = new System.Drawing.Point(495, 213);
            this.la_errorbarrel.Name = "la_errorbarrel";
            this.la_errorbarrel.Size = new System.Drawing.Size(73, 17);
            this.la_errorbarrel.TabIndex = 106;
            this.la_errorbarrel.Text = "*未选择桶号";
            this.la_errorbarrel.Visible = false;
            // 
            // la_errorproductioncompany
            // 
            this.la_errorproductioncompany.AutoSize = true;
            this.la_errorproductioncompany.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorproductioncompany.ForeColor = System.Drawing.Color.Red;
            this.la_errorproductioncompany.Location = new System.Drawing.Point(178, 291);
            this.la_errorproductioncompany.Name = "la_errorproductioncompany";
            this.la_errorproductioncompany.Size = new System.Drawing.Size(109, 17);
            this.la_errorproductioncompany.TabIndex = 112;
            this.la_errorproductioncompany.Text = "*生产公司不能为空";
            this.la_errorproductioncompany.Visible = false;
            // 
            // tb_productioncompany
            // 
            this.tb_productioncompany.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_productioncompany.Location = new System.Drawing.Point(180, 262);
            this.tb_productioncompany.Name = "tb_productioncompany";
            this.tb_productioncompany.Size = new System.Drawing.Size(183, 26);
            this.tb_productioncompany.TabIndex = 111;
            // 
            // la_productioncompany
            // 
            this.la_productioncompany.AutoSize = true;
            this.la_productioncompany.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_productioncompany.Location = new System.Drawing.Point(95, 265);
            this.la_productioncompany.Name = "la_productioncompany";
            this.la_productioncompany.Size = new System.Drawing.Size(79, 20);
            this.la_productioncompany.TabIndex = 110;
            this.la_productioncompany.Text = "生产公司：";
            // 
            // tb_beginningweight
            // 
            this.tb_beginningweight.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_beginningweight.Location = new System.Drawing.Point(217, 416);
            this.tb_beginningweight.Name = "tb_beginningweight";
            this.tb_beginningweight.Size = new System.Drawing.Size(146, 26);
            this.tb_beginningweight.TabIndex = 114;
            // 
            // la_beginningweight
            // 
            this.la_beginningweight.AutoSize = true;
            this.la_beginningweight.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_beginningweight.Location = new System.Drawing.Point(95, 419);
            this.la_beginningweight.Name = "la_beginningweight";
            this.la_beginningweight.Size = new System.Drawing.Size(116, 20);
            this.la_beginningweight.TabIndex = 113;
            this.la_beginningweight.Text = "初始质量（g）：";
            // 
            // tb_packageweight
            // 
            this.tb_packageweight.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_packageweight.Location = new System.Drawing.Point(535, 347);
            this.tb_packageweight.Name = "tb_packageweight";
            this.tb_packageweight.Size = new System.Drawing.Size(146, 26);
            this.tb_packageweight.TabIndex = 116;
            // 
            // la_packageweight
            // 
            this.la_packageweight.AutoSize = true;
            this.la_packageweight.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_packageweight.Location = new System.Drawing.Point(413, 350);
            this.la_packageweight.Name = "la_packageweight";
            this.la_packageweight.Size = new System.Drawing.Size(116, 20);
            this.la_packageweight.TabIndex = 115;
            this.la_packageweight.Text = "袋子皮重（g）：";
            // 
            // la_errorpackageweight
            // 
            this.la_errorpackageweight.AutoSize = true;
            this.la_errorpackageweight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorpackageweight.ForeColor = System.Drawing.Color.Red;
            this.la_errorpackageweight.Location = new System.Drawing.Point(532, 376);
            this.la_errorpackageweight.Name = "la_errorpackageweight";
            this.la_errorpackageweight.Size = new System.Drawing.Size(73, 17);
            this.la_errorpackageweight.TabIndex = 117;
            this.la_errorpackageweight.Text = "*请输入数字";
            this.la_errorpackageweight.Visible = false;
            // 
            // la_errorpackageweightnull
            // 
            this.la_errorpackageweightnull.AutoSize = true;
            this.la_errorpackageweightnull.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorpackageweightnull.ForeColor = System.Drawing.Color.Red;
            this.la_errorpackageweightnull.Location = new System.Drawing.Point(536, 376);
            this.la_errorpackageweightnull.Name = "la_errorpackageweightnull";
            this.la_errorpackageweightnull.Size = new System.Drawing.Size(109, 17);
            this.la_errorpackageweightnull.TabIndex = 118;
            this.la_errorpackageweightnull.Text = "*袋子重量不能为空";
            this.la_errorpackageweightnull.Visible = false;
            // 
            // AddOrUpdatePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 548);
            this.Controls.Add(this.la_errorpackageweightnull);
            this.Controls.Add(this.la_errorpackageweight);
            this.Controls.Add(this.tb_packageweight);
            this.Controls.Add(this.la_packageweight);
            this.Controls.Add(this.tb_beginningweight);
            this.Controls.Add(this.la_beginningweight);
            this.Controls.Add(this.la_errorproductioncompany);
            this.Controls.Add(this.tb_productioncompany);
            this.Controls.Add(this.la_productioncompany);
            this.Controls.Add(this.la_errorbarrel);
            this.Controls.Add(this.la_errorweigth);
            this.Controls.Add(this.la_errorspecifications);
            this.Controls.Add(this.la_errortype);
            this.Controls.Add(this.bt_showbarrel);
            this.Controls.Add(this.cb_isInWareHouse);
            this.Controls.Add(this.bt_alterinstrument);
            this.Controls.Add(this.time_purchaseTime);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_addinstrument);
            this.Controls.Add(this.tb_barrel);
            this.Controls.Add(this.tb_weight);
            this.Controls.Add(this.tb_specifications);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.la_isInWareHouse);
            this.Controls.Add(this.la_barrel);
            this.Controls.Add(this.la_purchaseTime);
            this.Controls.Add(this.la_weigth);
            this.Controls.Add(this.la_specifications);
            this.Controls.Add(this.la_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrUpdatePackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑仪器信息";
            this.Load += new System.EventHandler(this.AddOrModifyInstrument_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker time_purchaseTime;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_addinstrument;
        private System.Windows.Forms.TextBox tb_barrel;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.TextBox tb_specifications;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label la_isInWareHouse;
        private System.Windows.Forms.Label la_barrel;
        private System.Windows.Forms.Label la_purchaseTime;
        private System.Windows.Forms.Label la_weigth;
        private System.Windows.Forms.Label la_specifications;
        private System.Windows.Forms.Label la_type;
        private System.Windows.Forms.Button bt_alterinstrument;
        private System.Windows.Forms.ComboBox cb_isInWareHouse;
        private System.Windows.Forms.Button bt_showbarrel;
        private System.Windows.Forms.Label la_errortype;
        private System.Windows.Forms.Label la_errorspecifications;
        private System.Windows.Forms.Label la_errorweigth;
        private System.Windows.Forms.Label la_errorbarrel;
        private System.Windows.Forms.Label la_errorproductioncompany;
        private System.Windows.Forms.TextBox tb_productioncompany;
        private System.Windows.Forms.Label la_productioncompany;
        private System.Windows.Forms.TextBox tb_beginningweight;
        private System.Windows.Forms.Label la_beginningweight;
        private System.Windows.Forms.TextBox tb_packageweight;
        private System.Windows.Forms.Label la_packageweight;
        private System.Windows.Forms.Label la_errorpackageweight;
        private System.Windows.Forms.Label la_errorpackageweightnull;
    }
}