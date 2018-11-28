namespace FireProductManager.GuiPackage
{
    partial class AddOrUpdateAministrator
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
            this.la_authoritycheck = new System.Windows.Forms.Label();
            this.la_passwordcheck = new System.Windows.Forms.Label();
            this.la_accountcheck = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.la_title = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_authority = new System.Windows.Forms.ComboBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.la_authority = new System.Windows.Forms.Label();
            this.la_password = new System.Windows.Forms.Label();
            this.la_account = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // la_authoritycheck
            // 
            this.la_authoritycheck.AutoSize = true;
            this.la_authoritycheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_authoritycheck.ForeColor = System.Drawing.Color.Red;
            this.la_authoritycheck.Location = new System.Drawing.Point(185, 434);
            this.la_authoritycheck.Name = "la_authoritycheck";
            this.la_authoritycheck.Size = new System.Drawing.Size(107, 20);
            this.la_authoritycheck.TabIndex = 31;
            this.la_authoritycheck.Text = "未选择权限级别";
            // 
            // la_passwordcheck
            // 
            this.la_passwordcheck.AutoSize = true;
            this.la_passwordcheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_passwordcheck.ForeColor = System.Drawing.Color.Red;
            this.la_passwordcheck.Location = new System.Drawing.Point(193, 331);
            this.la_passwordcheck.Name = "la_passwordcheck";
            this.la_passwordcheck.Size = new System.Drawing.Size(93, 20);
            this.la_passwordcheck.TabIndex = 30;
            this.la_passwordcheck.Text = "密码不能为空";
            // 
            // la_accountcheck
            // 
            this.la_accountcheck.AutoSize = true;
            this.la_accountcheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_accountcheck.ForeColor = System.Drawing.Color.Red;
            this.la_accountcheck.Location = new System.Drawing.Point(186, 229);
            this.la_accountcheck.Name = "la_accountcheck";
            this.la_accountcheck.Size = new System.Drawing.Size(107, 20);
            this.la_accountcheck.TabIndex = 29;
            this.la_accountcheck.Text = "用户名不能为空";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_update.Location = new System.Drawing.Point(232, 518);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(97, 34);
            this.btn_update.TabIndex = 28;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // la_title
            // 
            this.la_title.AutoSize = true;
            this.la_title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_title.Location = new System.Drawing.Point(122, 103);
            this.la_title.Name = "la_title";
            this.la_title.Size = new System.Drawing.Size(0, 27);
            this.la_title.TabIndex = 27;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(232, 518);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 34);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_authority
            // 
            this.cb_authority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_authority.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_authority.FormattingEnabled = true;
            this.cb_authority.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_authority.Location = new System.Drawing.Point(158, 403);
            this.cb_authority.Name = "cb_authority";
            this.cb_authority.Size = new System.Drawing.Size(162, 29);
            this.cb_authority.TabIndex = 25;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_password.Location = new System.Drawing.Point(158, 300);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(162, 29);
            this.tb_password.TabIndex = 24;
            // 
            // tb_account
            // 
            this.tb_account.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_account.Location = new System.Drawing.Point(158, 198);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(162, 29);
            this.tb_account.TabIndex = 23;
            // 
            // la_authority
            // 
            this.la_authority.AutoSize = true;
            this.la_authority.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_authority.Location = new System.Drawing.Point(72, 405);
            this.la_authority.Name = "la_authority";
            this.la_authority.Size = new System.Drawing.Size(90, 21);
            this.la_authority.TabIndex = 22;
            this.la_authority.Text = "权限级别：";
            // 
            // la_password
            // 
            this.la_password.AutoSize = true;
            this.la_password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_password.Location = new System.Drawing.Point(72, 303);
            this.la_password.Name = "la_password";
            this.la_password.Size = new System.Drawing.Size(78, 21);
            this.la_password.TabIndex = 21;
            this.la_password.Text = "密    码：";
            // 
            // la_account
            // 
            this.la_account.AutoSize = true;
            this.la_account.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_account.Location = new System.Drawing.Point(72, 201);
            this.la_account.Name = "la_account";
            this.la_account.Size = new System.Drawing.Size(84, 21);
            this.la_account.TabIndex = 20;
            this.la_account.Text = "用 户 名：";
            // 
            // AddOrUpdateAministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 587);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateAministrator";
            this.Text = "编辑管理员信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_authoritycheck;
        private System.Windows.Forms.Label la_passwordcheck;
        private System.Windows.Forms.Label la_accountcheck;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label la_title;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_authority;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.Label la_authority;
        private System.Windows.Forms.Label la_password;
        private System.Windows.Forms.Label la_account;
    }
}