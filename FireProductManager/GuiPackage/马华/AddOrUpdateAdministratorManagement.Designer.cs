namespace FireProductManager.GuiPackage
{
    partial class AddOrUpdateAdministratorManagement
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
            this.la_title = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_authority = new System.Windows.Forms.ComboBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.la_authority = new System.Windows.Forms.Label();
            this.la_password = new System.Windows.Forms.Label();
            this.la_account = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.la_accountcheck = new System.Windows.Forms.Label();
            this.la_passwordcheck = new System.Windows.Forms.Label();
            this.la_authoritycheck = new System.Windows.Forms.Label();
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
            this.dgv_administrator.Location = new System.Drawing.Point(629, 99);
            this.dgv_administrator.Name = "dgv_administrator";
            this.dgv_administrator.RowTemplate.Height = 23;
            this.dgv_administrator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_administrator.Size = new System.Drawing.Size(709, 669);
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
            this.用户名.Width = 170;
            // 
            // 密码
            // 
            this.密码.FillWeight = 85.5619F;
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            this.密码.Width = 170;
            // 
            // 权限级别
            // 
            this.权限级别.FillWeight = 85.5619F;
            this.权限级别.HeaderText = "权限级别";
            this.权限级别.Name = "权限级别";
            this.权限级别.Width = 147;
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
            this.删除.Width = 90;
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
            this.修改.Width = 90;
            // 
            // btn_addaccount
            // 
            this.btn_addaccount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addaccount.Location = new System.Drawing.Point(629, 48);
            this.btn_addaccount.Name = "btn_addaccount";
            this.btn_addaccount.Size = new System.Drawing.Size(83, 23);
            this.btn_addaccount.TabIndex = 3;
            this.btn_addaccount.Text = "添加管理员";
            this.btn_addaccount.UseVisualStyleBackColor = true;
            this.btn_addaccount.Click += new System.EventHandler(this.btn_addaccount_Click);
            // 
            // la_title
            // 
            this.la_title.AutoSize = true;
            this.la_title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_title.Location = new System.Drawing.Point(241, 181);
            this.la_title.Name = "la_title";
            this.la_title.Size = new System.Drawing.Size(122, 21);
            this.la_title.TabIndex = 15;
            this.la_title.Text = "添加管理员信息";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(321, 598);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_authority
            // 
            this.cb_authority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_authority.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_authority.FormattingEnabled = true;
            this.cb_authority.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_authority.Location = new System.Drawing.Point(234, 476);
            this.cb_authority.Name = "cb_authority";
            this.cb_authority.Size = new System.Drawing.Size(162, 25);
            this.cb_authority.TabIndex = 13;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_password.Location = new System.Drawing.Point(234, 377);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(162, 23);
            this.tb_password.TabIndex = 12;
            // 
            // tb_account
            // 
            this.tb_account.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_account.Location = new System.Drawing.Point(234, 270);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(162, 23);
            this.tb_account.TabIndex = 11;
            // 
            // la_authority
            // 
            this.la_authority.AutoSize = true;
            this.la_authority.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_authority.Location = new System.Drawing.Point(172, 479);
            this.la_authority.Name = "la_authority";
            this.la_authority.Size = new System.Drawing.Size(68, 17);
            this.la_authority.TabIndex = 10;
            this.la_authority.Text = "权限级别：";
            // 
            // la_password
            // 
            this.la_password.AutoSize = true;
            this.la_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_password.Location = new System.Drawing.Point(172, 380);
            this.la_password.Name = "la_password";
            this.la_password.Size = new System.Drawing.Size(56, 17);
            this.la_password.TabIndex = 9;
            this.la_password.Text = "密   码：";
            // 
            // la_account
            // 
            this.la_account.AutoSize = true;
            this.la_account.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_account.Location = new System.Drawing.Point(172, 273);
            this.la_account.Name = "la_account";
            this.la_account.Size = new System.Drawing.Size(56, 17);
            this.la_account.TabIndex = 8;
            this.la_account.Text = "用户名：";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_update.Location = new System.Drawing.Point(321, 598);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // la_accountcheck
            // 
            this.la_accountcheck.AutoSize = true;
            this.la_accountcheck.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_accountcheck.ForeColor = System.Drawing.Color.Red;
            this.la_accountcheck.Location = new System.Drawing.Point(270, 300);
            this.la_accountcheck.Name = "la_accountcheck";
            this.la_accountcheck.Size = new System.Drawing.Size(92, 17);
            this.la_accountcheck.TabIndex = 17;
            this.la_accountcheck.Text = "用户名不能为空";
            // 
            // la_passwordcheck
            // 
            this.la_passwordcheck.AutoSize = true;
            this.la_passwordcheck.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_passwordcheck.ForeColor = System.Drawing.Color.Red;
            this.la_passwordcheck.Location = new System.Drawing.Point(273, 407);
            this.la_passwordcheck.Name = "la_passwordcheck";
            this.la_passwordcheck.Size = new System.Drawing.Size(80, 17);
            this.la_passwordcheck.TabIndex = 18;
            this.la_passwordcheck.Text = "密码不能为空";
            // 
            // la_authoritycheck
            // 
            this.la_authoritycheck.AutoSize = true;
            this.la_authoritycheck.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_authoritycheck.ForeColor = System.Drawing.Color.Red;
            this.la_authoritycheck.Location = new System.Drawing.Point(268, 508);
            this.la_authoritycheck.Name = "la_authoritycheck";
            this.la_authoritycheck.Size = new System.Drawing.Size(92, 17);
            this.la_authoritycheck.TabIndex = 19;
            this.la_authoritycheck.Text = "未选择权限级别";
            // 
            // AddOrUpdateAdministratorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.la_authoritycheck);
            this.Controls.Add(this.la_passwordcheck);
            this.Controls.Add(this.la_accountcheck);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.la_title);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_authority);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.la_authority);
            this.Controls.Add(this.la_password);
            this.Controls.Add(this.la_account);
            this.Controls.Add(this.btn_addaccount);
            this.Controls.Add(this.dgv_administrator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrUpdateAdministratorManagement";
            this.Text = "AdministratorManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_administrator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_administrator;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 权限级别;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
        private System.Windows.Forms.Button btn_addaccount;
        private System.Windows.Forms.Label la_title;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_authority;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.Label la_authority;
        private System.Windows.Forms.Label la_password;
        private System.Windows.Forms.Label la_account;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label la_accountcheck;
        private System.Windows.Forms.Label la_passwordcheck;
        private System.Windows.Forms.Label la_authoritycheck;
    }
}