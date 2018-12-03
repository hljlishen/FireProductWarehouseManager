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
            this.dgv_administrator = new System.Windows.Forms.DataGridView();
            this.用户id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.权限级别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_addaccount = new System.Windows.Forms.Button();
            this.pa_addorupdate = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_administrator)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_administrator
            // 
            this.dgv_administrator.AllowUserToAddRows = false;
            this.dgv_administrator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_administrator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_administrator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.用户id,
            this.用户名,
            this.密码,
            this.权限级别,
            this.删除,
            this.修改});
            this.dgv_administrator.Location = new System.Drawing.Point(558, 99);
            this.dgv_administrator.Name = "dgv_administrator";
            this.dgv_administrator.RowTemplate.Height = 23;
            this.dgv_administrator.Size = new System.Drawing.Size(780, 669);
            this.dgv_administrator.TabIndex = 1;
            this.dgv_administrator.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_administrator_CellContentClick);
            // 
            // 用户id
            // 
            this.用户id.HeaderText = "用户id";
            this.用户id.Name = "用户id";
            this.用户id.Visible = false;
            // 
            // 用户名
            // 
            this.用户名.FillWeight = 85.5619F;
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            this.用户名.Width = 179;
            // 
            // 密码
            // 
            this.密码.FillWeight = 85.5619F;
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            this.密码.Width = 179;
            // 
            // 权限级别
            // 
            this.权限级别.FillWeight = 85.5619F;
            this.权限级别.HeaderText = "权限级别";
            this.权限级别.Name = "权限级别";
            this.权限级别.Width = 179;
            // 
            // 删除
            // 
            this.删除.FillWeight = 116.4108F;
            this.删除.HeaderText = "删除";
            this.删除.Name = "删除";
            this.删除.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.删除.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.删除.Text = "删除";
            this.删除.UseColumnTextForButtonValue = true;
            // 
            // 修改
            // 
            this.修改.FillWeight = 126.9036F;
            this.修改.HeaderText = "修改";
            this.修改.Name = "修改";
            this.修改.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.修改.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.修改.Text = "修改";
            this.修改.UseColumnTextForButtonValue = true;
            // 
            // btn_addaccount
            // 
            this.btn_addaccount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addaccount.Location = new System.Drawing.Point(558, 53);
            this.btn_addaccount.Name = "btn_addaccount";
            this.btn_addaccount.Size = new System.Drawing.Size(83, 23);
            this.btn_addaccount.TabIndex = 3;
            this.btn_addaccount.Text = "添加管理员";
            this.btn_addaccount.UseVisualStyleBackColor = true;
            this.btn_addaccount.Click += new System.EventHandler(this.btn_addaccount_Click);
            // 
            // pa_addorupdate
            // 
            this.pa_addorupdate.Location = new System.Drawing.Point(75, 65);
            this.pa_addorupdate.Name = "pa_addorupdate";
            this.pa_addorupdate.Size = new System.Drawing.Size(401, 703);
            this.pa_addorupdate.TabIndex = 4;
            // 
            // AdministratorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.pa_addorupdate);
            this.Controls.Add(this.btn_addaccount);
            this.Controls.Add(this.dgv_administrator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministratorManagement";
            this.Text = "AdministratorManagement";
            this.Load += new System.EventHandler(this.AdministratorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_administrator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_addaccount;
        private System.Windows.Forms.Panel pa_addorupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 权限级别;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.DataGridView dgv_administrator;
    }
}