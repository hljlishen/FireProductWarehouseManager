namespace FireProductManager.GuiPackage
{
    partial class AdministratorManagement
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
            this.dgv_administrator = new System.Windows.Forms.DataGridView();
            this.用户id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.权限级别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.DelectAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.pa_addorupdate = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_administrator)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_administrator
            // 
            this.dgv_administrator.AllowUserToAddRows = false;
            this.dgv_administrator.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_administrator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_administrator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_administrator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.用户id,
            this.用户名,
            this.姓名,
            this.密码,
            this.权限级别});
            this.dgv_administrator.Location = new System.Drawing.Point(558, 99);
            this.dgv_administrator.Name = "dgv_administrator";
            this.dgv_administrator.ReadOnly = true;
            this.dgv_administrator.RowTemplate.Height = 23;
            this.dgv_administrator.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_administrator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_administrator.Size = new System.Drawing.Size(780, 669);
            this.dgv_administrator.TabIndex = 1;
            this.dgv_administrator.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_administrator_CellMouseDown);
            this.dgv_administrator.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_administrator_MouseClick);
            // 
            // 用户id
            // 
            this.用户id.HeaderText = "用户id";
            this.用户id.Name = "用户id";
            this.用户id.ReadOnly = true;
            this.用户id.Visible = false;
            // 
            // 用户名
            // 
            this.用户名.FillWeight = 85.5619F;
            this.用户名.HeaderText = "管理员编号";
            this.用户名.Name = "用户名";
            this.用户名.ReadOnly = true;
            this.用户名.Width = 177;
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            this.姓名.Width = 206;
            // 
            // 密码
            // 
            this.密码.FillWeight = 85.5619F;
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            this.密码.ReadOnly = true;
            this.密码.Width = 177;
            // 
            // 权限级别
            // 
            this.权限级别.FillWeight = 85.5619F;
            this.权限级别.HeaderText = "权限级别";
            this.权限级别.Name = "权限级别";
            this.权限级别.ReadOnly = true;
            this.权限级别.Width = 177;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAccount,
            this.UpdateAccount,
            this.DelectAccount});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // AddAccount
            // 
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(100, 22);
            this.AddAccount.Text = "添加";
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // UpdateAccount
            // 
            this.UpdateAccount.Name = "UpdateAccount";
            this.UpdateAccount.Size = new System.Drawing.Size(100, 22);
            this.UpdateAccount.Text = "修改";
            this.UpdateAccount.Click += new System.EventHandler(this.UpdateAccount_Click);
            // 
            // DelectAccount
            // 
            this.DelectAccount.Name = "DelectAccount";
            this.DelectAccount.Size = new System.Drawing.Size(100, 22);
            this.DelectAccount.Text = "删除";
            this.DelectAccount.Click += new System.EventHandler(this.DelectAccount_Click);
            // 
            // pa_addorupdate
            // 
            this.pa_addorupdate.Location = new System.Drawing.Point(49, 65);
            this.pa_addorupdate.Name = "pa_addorupdate";
            this.pa_addorupdate.Size = new System.Drawing.Size(461, 703);
            this.pa_addorupdate.TabIndex = 4;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 26);
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 22);
            this.add.Text = "添加";
            this.add.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1017, 771);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "注：1级为超级管理员；2级为普通管理员 ；3级为其他人员";
            // 
            // AdministratorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 832);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_administrator);
            this.Controls.Add(this.pa_addorupdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministratorManagement";
            this.Text = "AdministratorManagement";
            this.Load += new System.EventHandler(this.AdministratorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_administrator)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pa_addorupdate;
        private System.Windows.Forms.DataGridView dgv_administrator;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddAccount;
        private System.Windows.Forms.ToolStripMenuItem UpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem DelectAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 权限级别;
    }
}