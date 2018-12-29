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
            this.tp_projectdata = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tp_warehousedata = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tc_datareport = new System.Windows.Forms.TabControl();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tp_projectdata.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tp_warehousedata.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tc_datareport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tp_projectdata
            // 
            this.tp_projectdata.Controls.Add(this.comboBox2);
            this.tp_projectdata.Controls.Add(this.panel2);
            this.tp_projectdata.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_projectdata.Location = new System.Drawing.Point(4, 34);
            this.tp_projectdata.Name = "tp_projectdata";
            this.tp_projectdata.Padding = new System.Windows.Forms.Padding(3);
            this.tp_projectdata.Size = new System.Drawing.Size(1372, 732);
            this.tp_projectdata.TabIndex = 2;
            this.tp_projectdata.Text = "单一项目用量";
            this.tp_projectdata.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "入库材料",
            "使用材料",
            "剩余材料"});
            this.comboBox2.Location = new System.Drawing.Point(58, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 28);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser2);
            this.panel2.Location = new System.Drawing.Point(58, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 600);
            this.panel2.TabIndex = 26;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(1250, 600);
            this.webBrowser2.TabIndex = 0;
            // 
            // tp_warehousedata
            // 
            this.tp_warehousedata.Controls.Add(this.comboBox1);
            this.tp_warehousedata.Controls.Add(this.panel1);
            this.tp_warehousedata.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_warehousedata.Location = new System.Drawing.Point(4, 34);
            this.tp_warehousedata.Name = "tp_warehousedata";
            this.tp_warehousedata.Padding = new System.Windows.Forms.Padding(3);
            this.tp_warehousedata.Size = new System.Drawing.Size(1372, 732);
            this.tp_warehousedata.TabIndex = 0;
            this.tp_warehousedata.Text = "仓库库存信息";
            this.tp_warehousedata.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "入库材料",
            "使用材料",
            "剩余材料"});
            this.comboBox1.Location = new System.Drawing.Point(58, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(58, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 600);
            this.panel1.TabIndex = 24;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1250, 600);
            this.webBrowser1.TabIndex = 0;
            // 
            // tc_datareport
            // 
            this.tc_datareport.Controls.Add(this.tp_warehousedata);
            this.tc_datareport.Controls.Add(this.tp_projectdata);
            this.tc_datareport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tc_datareport.ItemSize = new System.Drawing.Size(150, 30);
            this.tc_datareport.Location = new System.Drawing.Point(12, 12);
            this.tc_datareport.Name = "tc_datareport";
            this.tc_datareport.SelectedIndex = 0;
            this.tc_datareport.Size = new System.Drawing.Size(1380, 770);
            this.tc_datareport.TabIndex = 0;
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
            // WarehouseDataReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 794);
            this.Controls.Add(this.tc_datareport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseDataReport";
            this.Text = "WarehouseDataReport";
            this.tp_projectdata.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tp_warehousedata.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tc_datareport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tp_projectdata;
        private System.Windows.Forms.TabPage tp_warehousedata;
        private System.Windows.Forms.TabControl tc_datareport;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}