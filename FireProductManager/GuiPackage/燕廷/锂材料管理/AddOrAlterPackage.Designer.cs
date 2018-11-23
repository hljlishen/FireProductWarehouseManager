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
            this.tb_weigth = new System.Windows.Forms.TextBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.la_barrel = new System.Windows.Forms.Label();
            this.la_purchaseTime = new System.Windows.Forms.Label();
            this.la_weigth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.la_name = new System.Windows.Forms.Label();
            this.bt_alterinstrument = new System.Windows.Forms.Button();
            this.cb_isInWareHouse = new System.Windows.Forms.ComboBox();
            this.bt_showbarrel = new System.Windows.Forms.Button();
            this.tb_projectId = new System.Windows.Forms.TextBox();
            this.la_projectId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time_purchaseTime
            // 
            this.time_purchaseTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time_purchaseTime.Location = new System.Drawing.Point(511, 260);
            this.time_purchaseTime.Name = "time_purchaseTime";
            this.time_purchaseTime.Size = new System.Drawing.Size(170, 26);
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
            this.bt_close.Location = new System.Drawing.Point(446, 435);
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
            this.bt_addinstrument.Location = new System.Drawing.Point(236, 435);
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
            this.tb_barrel.Location = new System.Drawing.Point(511, 185);
            this.tb_barrel.Name = "tb_barrel";
            this.tb_barrel.ReadOnly = true;
            this.tb_barrel.Size = new System.Drawing.Size(127, 26);
            this.tb_barrel.TabIndex = 47;
            // 
            // tb_weigth
            // 
            this.tb_weigth.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_weigth.Location = new System.Drawing.Point(180, 184);
            this.tb_weigth.Name = "tb_weigth";
            this.tb_weigth.Size = new System.Drawing.Size(183, 26);
            this.tb_weigth.TabIndex = 46;
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_model.Location = new System.Drawing.Point(498, 111);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(183, 26);
            this.tb_model.TabIndex = 44;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(180, 111);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(183, 26);
            this.tb_name.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(95, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "在库状态：";
            // 
            // la_barrel
            // 
            this.la_barrel.AutoSize = true;
            this.la_barrel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_barrel.Location = new System.Drawing.Point(413, 188);
            this.la_barrel.Name = "la_barrel";
            this.la_barrel.Size = new System.Drawing.Size(93, 20);
            this.la_barrel.TabIndex = 37;
            this.la_barrel.Text = "所在桶位置：";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(413, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "型号规格：";
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(95, 114);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(79, 20);
            this.la_name.TabIndex = 32;
            this.la_name.Text = "材料名称：";
            // 
            // bt_alterinstrument
            // 
            this.bt_alterinstrument.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_alterinstrument.Location = new System.Drawing.Point(236, 435);
            this.bt_alterinstrument.Name = "bt_alterinstrument";
            this.bt_alterinstrument.Size = new System.Drawing.Size(80, 30);
            this.bt_alterinstrument.TabIndex = 58;
            this.bt_alterinstrument.Text = "修改";
            this.bt_alterinstrument.UseVisualStyleBackColor = true;
            this.bt_alterinstrument.Click += new System.EventHandler(this.bt_alterinstrument_Click);
            // 
            // cb_isInWareHouse
            // 
            this.cb_isInWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_isInWareHouse.FormattingEnabled = true;
            this.cb_isInWareHouse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_isInWareHouse.Items.AddRange(new object[] {
            "在库",
            "不在库"});
            this.cb_isInWareHouse.Location = new System.Drawing.Point(181, 268);
            this.cb_isInWareHouse.Name = "cb_isInWareHouse";
            this.cb_isInWareHouse.Size = new System.Drawing.Size(84, 20);
            this.cb_isInWareHouse.TabIndex = 59;
            // 
            // bt_showbarrel
            // 
            this.bt_showbarrel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_showbarrel.Location = new System.Drawing.Point(651, 185);
            this.bt_showbarrel.Name = "bt_showbarrel";
            this.bt_showbarrel.Size = new System.Drawing.Size(30, 26);
            this.bt_showbarrel.TabIndex = 68;
            this.bt_showbarrel.Text = "...";
            this.bt_showbarrel.UseVisualStyleBackColor = true;
            this.bt_showbarrel.Click += new System.EventHandler(this.bt_showshelves_Click);
            // 
            // tb_projectId
            // 
            this.tb_projectId.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_projectId.Location = new System.Drawing.Point(181, 342);
            this.tb_projectId.Name = "tb_projectId";
            this.tb_projectId.Size = new System.Drawing.Size(182, 26);
            this.tb_projectId.TabIndex = 89;
            // 
            // la_projectId
            // 
            this.la_projectId.AutoSize = true;
            this.la_projectId.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_projectId.Location = new System.Drawing.Point(95, 345);
            this.la_projectId.Name = "la_projectId";
            this.la_projectId.Size = new System.Drawing.Size(79, 20);
            this.la_projectId.TabIndex = 88;
            this.la_projectId.Text = "项目令号：";
            // 
            // AddOrUpdatePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 513);
            this.Controls.Add(this.tb_projectId);
            this.Controls.Add(this.la_projectId);
            this.Controls.Add(this.bt_showbarrel);
            this.Controls.Add(this.cb_isInWareHouse);
            this.Controls.Add(this.bt_alterinstrument);
            this.Controls.Add(this.time_purchaseTime);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_addinstrument);
            this.Controls.Add(this.tb_barrel);
            this.Controls.Add(this.tb_weigth);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.la_barrel);
            this.Controls.Add(this.la_purchaseTime);
            this.Controls.Add(this.la_weigth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.la_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox tb_weigth;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label la_barrel;
        private System.Windows.Forms.Label la_purchaseTime;
        private System.Windows.Forms.Label la_weigth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.Button bt_alterinstrument;
        private System.Windows.Forms.ComboBox cb_isInWareHouse;
        private System.Windows.Forms.Button bt_showbarrel;
        private System.Windows.Forms.TextBox tb_projectId;
        private System.Windows.Forms.Label la_projectId;
    }
}