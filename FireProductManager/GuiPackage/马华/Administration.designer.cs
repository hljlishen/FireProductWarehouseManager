namespace FireProductManager.GuiPackage
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.btn_logout = new System.Windows.Forms.Button();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.到期提醒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.器件管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仪器管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.器件出入记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锂合金ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccouuntShow = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_logout.Location = new System.Drawing.Point(1337, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "注销";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.AutoSize = false;
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            this.员工管理ToolStripMenuItem.Click += new System.EventHandler(this.员工管理ToolStripMenuItem_Click);
            // 
            // 仓库管理ToolStripMenuItem
            // 
            this.仓库管理ToolStripMenuItem.Name = "仓库管理ToolStripMenuItem";
            this.仓库管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.仓库管理ToolStripMenuItem.Text = "仓库管理";
            this.仓库管理ToolStripMenuItem.Click += new System.EventHandler(this.仓库管理ToolStripMenuItem_Click);
            // 
            // 到期提醒ToolStripMenuItem
            // 
            this.到期提醒ToolStripMenuItem.Name = "到期提醒ToolStripMenuItem";
            this.到期提醒ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.到期提醒ToolStripMenuItem.Text = "到期提醒";
            // 
            // 器件管理ToolStripMenuItem
            // 
            this.器件管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仪器管理ToolStripMenuItem});
            this.器件管理ToolStripMenuItem.Name = "器件管理ToolStripMenuItem";
            this.器件管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.器件管理ToolStripMenuItem.Text = "材料管理";
            // 
            // 仪器管理ToolStripMenuItem
            // 
            this.仪器管理ToolStripMenuItem.Name = "仪器管理ToolStripMenuItem";
            this.仪器管理ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.仪器管理ToolStripMenuItem.Text = "锂合金材料管理";
            // 
            // 器件出入记录ToolStripMenuItem
            // 
            this.器件出入记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.锂合金ToolStripMenuItem});
            this.器件出入记录ToolStripMenuItem.Name = "器件出入记录ToolStripMenuItem";
            this.器件出入记录ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.器件出入记录ToolStripMenuItem.Text = "材料出入记录";
            // 
            // 锂合金ToolStripMenuItem
            // 
            this.锂合金ToolStripMenuItem.Name = "锂合金ToolStripMenuItem";
            this.锂合金ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.锂合金ToolStripMenuItem.Text = "锂合金";
            this.锂合金ToolStripMenuItem.Click += new System.EventHandler(this.锂合金ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工管理ToolStripMenuItem,
            this.到期提醒ToolStripMenuItem,
            this.仓库管理ToolStripMenuItem,
            this.器件管理ToolStripMenuItem,
            this.器件出入记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1424, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccouuntShow
            // 
            this.AccouuntShow.AutoSize = true;
            this.AccouuntShow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccouuntShow.Location = new System.Drawing.Point(1243, 1);
            this.AccouuntShow.Name = "AccouuntShow";
            this.AccouuntShow.Size = new System.Drawing.Size(0, 21);
            this.AccouuntShow.TabIndex = 4;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 862);
            this.Controls.Add(this.AccouuntShow);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "管理员页面";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 到期提醒ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 器件管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仪器管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 器件出入记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锂合金ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label AccouuntShow;
    }
}