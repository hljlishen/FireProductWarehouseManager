namespace FireProductManager.GuiPackage
{
    partial class PackageBorrowRecord
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
            this.La_TimeQuery = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.la_to = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dgv_PackageInAndOutrecord = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_directquery = new System.Windows.Forms.ComboBox();
            this.cb_choicetime = new System.Windows.Forms.CheckBox();
            this.btn_selectpackageid = new System.Windows.Forms.Button();
            this.tb_packageid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_employeeid = new System.Windows.Forms.TextBox();
            this.btn_selectemployee = new System.Windows.Forms.Button();
            this.gb_foundrecord = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_projectid = new System.Windows.Forms.TextBox();
            this.btn_selectprojectid = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exceloperator = new System.Windows.Forms.Button();
            this.袋子id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.桶号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.方向 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.领用人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.领用项目令号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.管理员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PackageInAndOutrecord)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gb_foundrecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // La_TimeQuery
            // 
            this.La_TimeQuery.AutoSize = true;
            this.La_TimeQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_TimeQuery.Location = new System.Drawing.Point(861, 34);
            this.La_TimeQuery.Name = "La_TimeQuery";
            this.La_TimeQuery.Size = new System.Drawing.Size(79, 20);
            this.La_TimeQuery.TabIndex = 4;
            this.La_TimeQuery.Text = "时间查询：";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(1192, 32);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dtp_begin
            // 
            this.dtp_begin.Enabled = false;
            this.dtp_begin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_begin.Location = new System.Drawing.Point(944, 32);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(103, 23);
            this.dtp_begin.TabIndex = 7;
            // 
            // la_to
            // 
            this.la_to.AutoSize = true;
            this.la_to.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_to.Location = new System.Drawing.Point(1053, 33);
            this.la_to.Name = "la_to";
            this.la_to.Size = new System.Drawing.Size(23, 20);
            this.la_to.TabIndex = 8;
            this.la_to.Text = "至";
            // 
            // dtp_end
            // 
            this.dtp_end.Enabled = false;
            this.dtp_end.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_end.Location = new System.Drawing.Point(1080, 32);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(103, 23);
            this.dtp_end.TabIndex = 9;
            // 
            // dgv_PackageInAndOutrecord
            // 
            this.dgv_PackageInAndOutrecord.AllowUserToAddRows = false;
            this.dgv_PackageInAndOutrecord.AllowUserToDeleteRows = false;
            this.dgv_PackageInAndOutrecord.AllowUserToResizeColumns = false;
            this.dgv_PackageInAndOutrecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PackageInAndOutrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PackageInAndOutrecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.袋子id,
            this.桶号,
            this.类型,
            this.规格,
            this.方向,
            this.日期,
            this.领用人,
            this.领用项目令号,
            this.重量,
            this.生产单位,
            this.生产日期,
            this.管理员,
            this.项目id});
            this.dgv_PackageInAndOutrecord.Location = new System.Drawing.Point(69, 97);
            this.dgv_PackageInAndOutrecord.Name = "dgv_PackageInAndOutrecord";
            this.dgv_PackageInAndOutrecord.ReadOnly = true;
            this.dgv_PackageInAndOutrecord.RowTemplate.Height = 23;
            this.dgv_PackageInAndOutrecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_PackageInAndOutrecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PackageInAndOutrecord.Size = new System.Drawing.Size(1279, 657);
            this.dgv_PackageInAndOutrecord.TabIndex = 0;
            this.dgv_PackageInAndOutrecord.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_PackageInAndOutrecord_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 选择ToolStripMenuItem
            // 
            this.选择ToolStripMenuItem.Name = "选择ToolStripMenuItem";
            this.选择ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.选择ToolStripMenuItem.Text = "选择";
            // 
            // cb_directquery
            // 
            this.cb_directquery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_directquery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_directquery.FormattingEnabled = true;
            this.cb_directquery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_directquery.Items.AddRange(new object[] {
            "出入库",
            "出库",
            "入库"});
            this.cb_directquery.Location = new System.Drawing.Point(716, 32);
            this.cb_directquery.Name = "cb_directquery";
            this.cb_directquery.Size = new System.Drawing.Size(100, 25);
            this.cb_directquery.TabIndex = 17;
            // 
            // cb_choicetime
            // 
            this.cb_choicetime.AutoSize = true;
            this.cb_choicetime.Location = new System.Drawing.Point(843, 39);
            this.cb_choicetime.Name = "cb_choicetime";
            this.cb_choicetime.Size = new System.Drawing.Size(15, 14);
            this.cb_choicetime.TabIndex = 21;
            this.cb_choicetime.UseVisualStyleBackColor = true;
            // 
            // btn_selectpackageid
            // 
            this.btn_selectpackageid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_selectpackageid.Location = new System.Drawing.Point(160, 32);
            this.btn_selectpackageid.Name = "btn_selectpackageid";
            this.btn_selectpackageid.Size = new System.Drawing.Size(28, 23);
            this.btn_selectpackageid.TabIndex = 22;
            this.btn_selectpackageid.Text = "...";
            this.btn_selectpackageid.UseVisualStyleBackColor = true;
            this.btn_selectpackageid.Click += new System.EventHandler(this.btn_selectpackageid_Click);
            // 
            // tb_packageid
            // 
            this.tb_packageid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_packageid.Location = new System.Drawing.Point(83, 32);
            this.tb_packageid.Name = "tb_packageid";
            this.tb_packageid.ReadOnly = true;
            this.tb_packageid.Size = new System.Drawing.Size(72, 23);
            this.tb_packageid.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "袋子编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(207, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "领用人编号：";
            // 
            // tb_employeeid
            // 
            this.tb_employeeid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_employeeid.Location = new System.Drawing.Point(301, 33);
            this.tb_employeeid.Name = "tb_employeeid";
            this.tb_employeeid.ReadOnly = true;
            this.tb_employeeid.Size = new System.Drawing.Size(68, 23);
            this.tb_employeeid.TabIndex = 25;
            // 
            // btn_selectemployee
            // 
            this.btn_selectemployee.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_selectemployee.Location = new System.Drawing.Point(371, 33);
            this.btn_selectemployee.Name = "btn_selectemployee";
            this.btn_selectemployee.Size = new System.Drawing.Size(28, 23);
            this.btn_selectemployee.TabIndex = 26;
            this.btn_selectemployee.Text = "...";
            this.btn_selectemployee.UseVisualStyleBackColor = true;
            this.btn_selectemployee.Click += new System.EventHandler(this.btn_selectemployee_Click);
            // 
            // gb_foundrecord
            // 
            this.gb_foundrecord.Controls.Add(this.label4);
            this.gb_foundrecord.Controls.Add(this.tb_projectid);
            this.gb_foundrecord.Controls.Add(this.btn_selectprojectid);
            this.gb_foundrecord.Controls.Add(this.label3);
            this.gb_foundrecord.Controls.Add(this.cb_choicetime);
            this.gb_foundrecord.Controls.Add(this.btn_search);
            this.gb_foundrecord.Controls.Add(this.label1);
            this.gb_foundrecord.Controls.Add(this.btn_selectemployee);
            this.gb_foundrecord.Controls.Add(this.dtp_end);
            this.gb_foundrecord.Controls.Add(this.cb_directquery);
            this.gb_foundrecord.Controls.Add(this.la_to);
            this.gb_foundrecord.Controls.Add(this.dtp_begin);
            this.gb_foundrecord.Controls.Add(this.tb_packageid);
            this.gb_foundrecord.Controls.Add(this.La_TimeQuery);
            this.gb_foundrecord.Controls.Add(this.tb_employeeid);
            this.gb_foundrecord.Controls.Add(this.btn_selectpackageid);
            this.gb_foundrecord.Controls.Add(this.label2);
            this.gb_foundrecord.Location = new System.Drawing.Point(69, 15);
            this.gb_foundrecord.Name = "gb_foundrecord";
            this.gb_foundrecord.Size = new System.Drawing.Size(1279, 76);
            this.gb_foundrecord.TabIndex = 27;
            this.gb_foundrecord.TabStop = false;
            this.gb_foundrecord.Text = "搜索记录";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(424, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "领用项目编号：";
            // 
            // tb_projectid
            // 
            this.tb_projectid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_projectid.Location = new System.Drawing.Point(533, 33);
            this.tb_projectid.Name = "tb_projectid";
            this.tb_projectid.ReadOnly = true;
            this.tb_projectid.Size = new System.Drawing.Size(72, 23);
            this.tb_projectid.TabIndex = 30;
            // 
            // btn_selectprojectid
            // 
            this.btn_selectprojectid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_selectprojectid.Location = new System.Drawing.Point(610, 33);
            this.btn_selectprojectid.Name = "btn_selectprojectid";
            this.btn_selectprojectid.Size = new System.Drawing.Size(28, 23);
            this.btn_selectprojectid.TabIndex = 29;
            this.btn_selectprojectid.Text = "...";
            this.btn_selectprojectid.UseVisualStyleBackColor = true;
            this.btn_selectprojectid.Click += new System.EventHandler(this.btn_selectprojectid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(663, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "方向：";
            // 
            // btn_exceloperator
            // 
            this.btn_exceloperator.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exceloperator.Location = new System.Drawing.Point(1261, 760);
            this.btn_exceloperator.Name = "btn_exceloperator";
            this.btn_exceloperator.Size = new System.Drawing.Size(75, 23);
            this.btn_exceloperator.TabIndex = 28;
            this.btn_exceloperator.Text = "导出Excel";
            this.btn_exceloperator.UseVisualStyleBackColor = true;
            this.btn_exceloperator.Click += new System.EventHandler(this.btn_exceloperator_Click);
            // 
            // 袋子id
            // 
            this.袋子id.HeaderText = "袋子编号";
            this.袋子id.Name = "袋子id";
            this.袋子id.ReadOnly = true;
            this.袋子id.Visible = false;
            // 
            // 桶号
            // 
            this.桶号.HeaderText = "所在桶";
            this.桶号.Name = "桶号";
            this.桶号.ReadOnly = true;
            this.桶号.Width = 102;
            // 
            // 类型
            // 
            this.类型.HeaderText = "材料类型";
            this.类型.Name = "类型";
            this.类型.ReadOnly = true;
            this.类型.Width = 113;
            // 
            // 规格
            // 
            this.规格.HeaderText = "规格（mm*mm）";
            this.规格.Name = "规格";
            this.规格.ReadOnly = true;
            this.规格.Width = 112;
            // 
            // 方向
            // 
            this.方向.HeaderText = "方向";
            this.方向.Name = "方向";
            this.方向.ReadOnly = true;
            this.方向.Width = 112;
            // 
            // 日期
            // 
            this.日期.HeaderText = "领用日期（归还日期）";
            this.日期.Name = "日期";
            this.日期.ReadOnly = true;
            this.日期.Width = 155;
            // 
            // 领用人
            // 
            this.领用人.HeaderText = "领用人";
            this.领用人.Name = "领用人";
            this.领用人.ReadOnly = true;
            this.领用人.Width = 112;
            // 
            // 领用项目令号
            // 
            this.领用项目令号.HeaderText = "领用项目令号";
            this.领用项目令号.Name = "领用项目令号";
            this.领用项目令号.ReadOnly = true;
            this.领用项目令号.Width = 103;
            // 
            // 重量
            // 
            this.重量.HeaderText = "重量(g)";
            this.重量.Name = "重量";
            this.重量.ReadOnly = true;
            this.重量.Width = 112;
            // 
            // 生产单位
            // 
            this.生产单位.HeaderText = "生产单位";
            this.生产单位.Name = "生产单位";
            this.生产单位.ReadOnly = true;
            this.生产单位.Width = 112;
            // 
            // 生产日期
            // 
            this.生产日期.HeaderText = "生产日期";
            this.生产日期.Name = "生产日期";
            this.生产日期.ReadOnly = true;
            this.生产日期.Width = 113;
            // 
            // 管理员
            // 
            this.管理员.HeaderText = "管理员编号";
            this.管理员.Name = "管理员";
            this.管理员.ReadOnly = true;
            this.管理员.Width = 90;
            // 
            // 项目id
            // 
            this.项目id.HeaderText = "项目id";
            this.项目id.Name = "项目id";
            this.项目id.ReadOnly = true;
            this.项目id.Visible = false;
            // 
            // PackageBorrowRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 832);
            this.Controls.Add(this.btn_exceloperator);
            this.Controls.Add(this.gb_foundrecord);
            this.Controls.Add(this.dgv_PackageInAndOutrecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PackageBorrowRecord";
            this.Text = "出入库记录";
            this.Load += new System.EventHandler(this.PackageBorrowRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PackageInAndOutrecord)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gb_foundrecord.ResumeLayout(false);
            this.gb_foundrecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label La_TimeQuery;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Label la_to;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DataGridView dgv_PackageInAndOutrecord;
        private System.Windows.Forms.ComboBox cb_directquery;
        private System.Windows.Forms.CheckBox cb_choicetime;
        private System.Windows.Forms.Button btn_selectpackageid;
        private System.Windows.Forms.TextBox tb_packageid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_employeeid;
        private System.Windows.Forms.Button btn_selectemployee;
        private System.Windows.Forms.GroupBox gb_foundrecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_exceloperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_projectid;
        private System.Windows.Forms.Button btn_selectprojectid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选择ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 袋子id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 桶号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 方向;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 领用人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 领用项目令号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 管理员;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目id;
    }
}