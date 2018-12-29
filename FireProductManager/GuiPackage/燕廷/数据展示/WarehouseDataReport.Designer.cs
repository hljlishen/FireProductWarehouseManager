namespace FireProductManager.GuiPackage
{
    partial class WarehouseDataReport
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
            this.tp_warehousemargi = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wb_project = new System.Windows.Forms.WebBrowser();
            this.tp_warehouseprocurement = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wb_warehouse = new System.Windows.Forms.WebBrowser();
            this.tc_datareport = new System.Windows.Forms.TabControl();
            this.tp_warehousemargin = new System.Windows.Forms.TabPage();
            this.wb_warehousemargin = new System.Windows.Forms.WebBrowser();
            this.tp_projectdosage = new System.Windows.Forms.TabPage();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.bt_showbarrel = new System.Windows.Forms.Button();
            this.tb_project = new System.Windows.Forms.TextBox();
            this.tp_warehousemargi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tp_warehouseprocurement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tc_datareport.SuspendLayout();
            this.tp_warehousemargin.SuspendLayout();
            this.tp_projectdosage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_warehousemargi
            // 
            this.tp_warehousemargi.Controls.Add(this.comboBox1);
            this.tp_warehousemargi.Controls.Add(this.panel2);
            this.tp_warehousemargi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_warehousemargi.Location = new System.Drawing.Point(4, 34);
            this.tp_warehousemargi.Name = "tp_warehousemargi";
            this.tp_warehousemargi.Padding = new System.Windows.Forms.Padding(3);
            this.tp_warehousemargi.Size = new System.Drawing.Size(1372, 732);
            this.tp_warehousemargi.TabIndex = 2;
            this.tp_warehousemargi.Text = "仓库用量";
            this.tp_warehousemargi.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Controls.Add(this.wb_project);
            this.panel2.Location = new System.Drawing.Point(58, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 600);
            this.panel2.TabIndex = 26;
            // 
            // wb_project
            // 
            this.wb_project.Location = new System.Drawing.Point(0, 0);
            this.wb_project.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_project.Name = "wb_project";
            this.wb_project.ScrollBarsEnabled = false;
            this.wb_project.Size = new System.Drawing.Size(625, 600);
            this.wb_project.TabIndex = 0;
            // 
            // tp_warehouseprocurement
            // 
            this.tp_warehouseprocurement.Controls.Add(this.panel1);
            this.tp_warehouseprocurement.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_warehouseprocurement.Location = new System.Drawing.Point(4, 34);
            this.tp_warehouseprocurement.Name = "tp_warehouseprocurement";
            this.tp_warehouseprocurement.Padding = new System.Windows.Forms.Padding(3);
            this.tp_warehouseprocurement.Size = new System.Drawing.Size(1372, 732);
            this.tp_warehouseprocurement.TabIndex = 0;
            this.tp_warehouseprocurement.Text = "仓库采购";
            this.tp_warehouseprocurement.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wb_warehouse);
            this.panel1.Location = new System.Drawing.Point(58, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 600);
            this.panel1.TabIndex = 24;
            // 
            // wb_warehouse
            // 
            this.wb_warehouse.Location = new System.Drawing.Point(0, 0);
            this.wb_warehouse.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_warehouse.Name = "wb_warehouse";
            this.wb_warehouse.ScriptErrorsSuppressed = true;
            this.wb_warehouse.ScrollBarsEnabled = false;
            this.wb_warehouse.Size = new System.Drawing.Size(1250, 600);
            this.wb_warehouse.TabIndex = 1;
            // 
            // tc_datareport
            // 
            this.tc_datareport.Controls.Add(this.tp_warehouseprocurement);
            this.tc_datareport.Controls.Add(this.tp_warehousemargi);
            this.tc_datareport.Controls.Add(this.tp_warehousemargin);
            this.tc_datareport.Controls.Add(this.tp_projectdosage);
            this.tc_datareport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tc_datareport.ItemSize = new System.Drawing.Size(150, 30);
            this.tc_datareport.Location = new System.Drawing.Point(22, 18);
            this.tc_datareport.Name = "tc_datareport";
            this.tc_datareport.SelectedIndex = 0;
            this.tc_datareport.Size = new System.Drawing.Size(1380, 770);
            this.tc_datareport.TabIndex = 0;
            this.tc_datareport.SelectedIndexChanged += new System.EventHandler(this.tc_datareport_SelectedIndexChanged);
            // 
            // tp_warehousemargin
            // 
            this.tp_warehousemargin.Controls.Add(this.wb_warehousemargin);
            this.tp_warehousemargin.Location = new System.Drawing.Point(4, 34);
            this.tp_warehousemargin.Name = "tp_warehousemargin";
            this.tp_warehousemargin.Padding = new System.Windows.Forms.Padding(3);
            this.tp_warehousemargin.Size = new System.Drawing.Size(1372, 732);
            this.tp_warehousemargin.TabIndex = 3;
            this.tp_warehousemargin.Text = "仓库余量";
            this.tp_warehousemargin.UseVisualStyleBackColor = true;
            // 
            // wb_warehousemargin
            // 
            this.wb_warehousemargin.Location = new System.Drawing.Point(58, 82);
            this.wb_warehousemargin.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_warehousemargin.Name = "wb_warehousemargin";
            this.wb_warehousemargin.ScrollBarsEnabled = false;
            this.wb_warehousemargin.Size = new System.Drawing.Size(1250, 600);
            this.wb_warehousemargin.TabIndex = 1;
            // 
            // tp_projectdosage
            // 
            this.tp_projectdosage.Controls.Add(this.bt_showbarrel);
            this.tp_projectdosage.Controls.Add(this.tb_project);
            this.tp_projectdosage.Controls.Add(this.comboBox2);
            this.tp_projectdosage.Controls.Add(this.panel3);
            this.tp_projectdosage.Location = new System.Drawing.Point(4, 34);
            this.tp_projectdosage.Name = "tp_projectdosage";
            this.tp_projectdosage.Padding = new System.Windows.Forms.Padding(3);
            this.tp_projectdosage.Size = new System.Drawing.Size(1372, 732);
            this.tp_projectdosage.TabIndex = 4;
            this.tp_projectdosage.Text = "项目用量";
            this.tp_projectdosage.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(625, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(625, 600);
            this.webBrowser1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "已归还用量",
            "未归还材料"});
            this.comboBox1.Location = new System.Drawing.Point(58, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 28);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "已归还用量";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "已归还用量",
            "未归还材料"});
            this.comboBox2.Location = new System.Drawing.Point(259, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 28);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.Text = "已归还用量";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webBrowser2);
            this.panel3.Controls.Add(this.webBrowser3);
            this.panel3.Location = new System.Drawing.Point(60, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 600);
            this.panel3.TabIndex = 28;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(625, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(625, 600);
            this.webBrowser2.TabIndex = 1;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(0, 0);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.ScrollBarsEnabled = false;
            this.webBrowser3.Size = new System.Drawing.Size(625, 600);
            this.webBrowser3.TabIndex = 0;
            // 
            // bt_showbarrel
            // 
            this.bt_showbarrel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_showbarrel.Location = new System.Drawing.Point(213, 51);
            this.bt_showbarrel.Name = "bt_showbarrel";
            this.bt_showbarrel.Size = new System.Drawing.Size(30, 26);
            this.bt_showbarrel.TabIndex = 70;
            this.bt_showbarrel.Text = "...";
            this.bt_showbarrel.UseVisualStyleBackColor = true;
            this.bt_showbarrel.Click += new System.EventHandler(this.bt_showbarrel_Click);
            // 
            // tb_project
            // 
            this.tb_project.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_project.Location = new System.Drawing.Point(60, 51);
            this.tb_project.Name = "tb_project";
            this.tb_project.Size = new System.Drawing.Size(147, 26);
            this.tb_project.TabIndex = 69;
            // 
            // WarehouseDataReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 832);
            this.Controls.Add(this.tc_datareport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseDataReport";
            this.Text = "WarehouseDataReport";
            this.Load += new System.EventHandler(this.WarehouseDataReport_Load);
            this.tp_warehousemargi.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tp_warehouseprocurement.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tc_datareport.ResumeLayout(false);
            this.tp_warehousemargin.ResumeLayout(false);
            this.tp_projectdosage.ResumeLayout(false);
            this.tp_projectdosage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tp_warehousemargi;
        private System.Windows.Forms.TabPage tp_warehouseprocurement;
        private System.Windows.Forms.TabControl tc_datareport;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser wb_project;
        private System.Windows.Forms.WebBrowser wb_warehouse;
        private System.Windows.Forms.TabPage tp_warehousemargin;
        private System.Windows.Forms.TabPage tp_projectdosage;
        private System.Windows.Forms.WebBrowser wb_warehousemargin;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.Button bt_showbarrel;
        private System.Windows.Forms.TextBox tb_project;
    }
}