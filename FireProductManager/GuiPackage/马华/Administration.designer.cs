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
            this.项目令号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仪器管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材料出入记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锂合金ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.出入库登记ToolStripMenultem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccouuntShow = new System.Windows.Forms.Label();
            this.la_account = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // 项目令号ToolStripMenuItem
            // 
            this.项目令号ToolStripMenuItem.Name = "项目令号ToolStripMenuItem";
            this.项目令号ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.项目令号ToolStripMenuItem.Text = "项目令号";
            this.项目令号ToolStripMenuItem.Click += new System.EventHandler(this.项目令号ToolStripMenuItem_Click);
            // 
            // 材料管理ToolStripMenuItem
            // 
            this.材料管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仪器管理ToolStripMenuItem});
            this.材料管理ToolStripMenuItem.Name = "材料管理ToolStripMenuItem";
            this.材料管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.材料管理ToolStripMenuItem.Text = "材料管理";
            // 
            // 仪器管理ToolStripMenuItem
            // 
            this.仪器管理ToolStripMenuItem.Name = "仪器管理ToolStripMenuItem";
            this.仪器管理ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.仪器管理ToolStripMenuItem.Text = "锂合金材料管理";
            this.仪器管理ToolStripMenuItem.Click += new System.EventHandler(this.锂合金材料管理ToolStripMenuItem_Click);
            // 
            // 材料出入记录ToolStripMenuItem
            // 
            this.材料出入记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.锂合金ToolStripMenuItem});
            this.材料出入记录ToolStripMenuItem.Name = "材料出入记录ToolStripMenuItem";
            this.材料出入记录ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.材料出入记录ToolStripMenuItem.Text = "材料出入记录";
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
            this.出入库登记ToolStripMenultem,
            this.员工管理ToolStripMenuItem,
            this.项目令号ToolStripMenuItem,
            this.仓库管理ToolStripMenuItem,
            this.材料管理ToolStripMenuItem,
            this.材料出入记录ToolStripMenuItem,
            this.管理员ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1424, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 出入库登记ToolStripMenultem
            // 
            this.出入库登记ToolStripMenultem.Name = "出入库登记ToolStripMenultem";
            this.出入库登记ToolStripMenultem.Size = new System.Drawing.Size(80, 21);
            this.出入库登记ToolStripMenultem.Text = "出入库登记";
            this.出入库登记ToolStripMenultem.Click += new System.EventHandler(this.出入库登记ToolStripMenultem_Click);
            // 
            // 管理员ToolStripMenuItem
            // 
            this.管理员ToolStripMenuItem.Name = "管理员ToolStripMenuItem";
            this.管理员ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.管理员ToolStripMenuItem.Text = "管理员";
            this.管理员ToolStripMenuItem.Click += new System.EventHandler(this.管理员ToolStripMenuItem_Click);
            // 
            // AccouuntShow
            // 
            this.AccouuntShow.AutoSize = true;
            this.AccouuntShow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccouuntShow.Location = new System.Drawing.Point(1272, 1);
            this.AccouuntShow.Name = "AccouuntShow";
            this.AccouuntShow.Size = new System.Drawing.Size(0, 21);
            this.AccouuntShow.TabIndex = 4;
            // 
            // la_account
            // 
            this.la_account.AutoSize = true;
            this.la_account.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_account.Location = new System.Drawing.Point(1278, 8);
            this.la_account.Name = "la_account";
            this.la_account.Size = new System.Drawing.Size(0, 17);
            this.la_account.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1217, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户名:";
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 862);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.la_account);
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
        private System.Windows.Forms.ToolStripMenuItem 项目令号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仪器管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料出入记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锂合金ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label AccouuntShow;
        private System.Windows.Forms.ToolStripMenuItem 管理员ToolStripMenuItem;
        private System.Windows.Forms.Label la_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 出入库登记ToolStripMenultem;
    }
}