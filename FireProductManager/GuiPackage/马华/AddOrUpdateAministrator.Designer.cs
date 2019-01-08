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
            this.tb_accountnumber = new System.Windows.Forms.TextBox();
            this.la_authority = new System.Windows.Forms.Label();
            this.la_password = new System.Windows.Forms.Label();
            this.la_account = new System.Windows.Forms.Label();
            this.la_accountnumber = new System.Windows.Forms.Label();
            this.la_namecheck = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.la_name = new System.Windows.Forms.Label();
            this.picFPImg = new System.Windows.Forms.PictureBox();
            this.la_fin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).BeginInit();
            this.SuspendLayout();
            // 
            // la_authoritycheck
            // 
            this.la_authoritycheck.AutoSize = true;
            this.la_authoritycheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_authoritycheck.ForeColor = System.Drawing.Color.Red;
            this.la_authoritycheck.Location = new System.Drawing.Point(206, 464);
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
            this.la_passwordcheck.Location = new System.Drawing.Point(216, 386);
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
            this.la_accountcheck.Location = new System.Drawing.Point(196, 231);
            this.la_accountcheck.Name = "la_accountcheck";
            this.la_accountcheck.Size = new System.Drawing.Size(135, 20);
            this.la_accountcheck.TabIndex = 29;
            this.la_accountcheck.Text = "管理员编号不能为空";
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
            "1(超级管理员)",
            "2(普通管理员)",
            "3(其他人员)"});
            this.cb_authority.Location = new System.Drawing.Point(179, 431);
            this.cb_authority.Name = "cb_authority";
            this.cb_authority.Size = new System.Drawing.Size(162, 29);
            this.cb_authority.TabIndex = 25;
            this.cb_authority.SelectedIndexChanged += new System.EventHandler(this.cb_authority_SelectedIndexChanged);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_password.Location = new System.Drawing.Point(179, 353);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(162, 29);
            this.tb_password.TabIndex = 24;
            // 
            // tb_accountnumber
            // 
            this.tb_accountnumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_accountnumber.Location = new System.Drawing.Point(179, 198);
            this.tb_accountnumber.Name = "tb_accountnumber";
            this.tb_accountnumber.Size = new System.Drawing.Size(162, 29);
            this.tb_accountnumber.TabIndex = 23;
            this.tb_accountnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_accountnumber_KeyPress);
            // 
            // la_authority
            // 
            this.la_authority.AutoSize = true;
            this.la_authority.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_authority.Location = new System.Drawing.Point(72, 434);
            this.la_authority.Name = "la_authority";
            this.la_authority.Size = new System.Drawing.Size(105, 21);
            this.la_authority.TabIndex = 22;
            this.la_authority.Text = "权 限 级 别：";
            // 
            // la_password
            // 
            this.la_password.AutoSize = true;
            this.la_password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_password.Location = new System.Drawing.Point(72, 356);
            this.la_password.Name = "la_password";
            this.la_password.Size = new System.Drawing.Size(98, 21);
            this.la_password.TabIndex = 21;
            this.la_password.Text = "密        码：";
            // 
            // la_account
            // 
            this.la_account.AutoSize = true;
            this.la_account.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_account.Location = new System.Drawing.Point(72, 201);
            this.la_account.Name = "la_account";
            this.la_account.Size = new System.Drawing.Size(106, 21);
            this.la_account.TabIndex = 20;
            this.la_account.Text = "管理员编号：";
            // 
            // la_accountnumber
            // 
            this.la_accountnumber.AutoSize = true;
            this.la_accountnumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_accountnumber.ForeColor = System.Drawing.Color.Red;
            this.la_accountnumber.Location = new System.Drawing.Point(196, 231);
            this.la_accountnumber.Name = "la_accountnumber";
            this.la_accountnumber.Size = new System.Drawing.Size(121, 20);
            this.la_accountnumber.TabIndex = 32;
            this.la_accountnumber.Text = "管理员编号已存在";
            this.la_accountnumber.Visible = false;
            // 
            // la_namecheck
            // 
            this.la_namecheck.AutoSize = true;
            this.la_namecheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_namecheck.ForeColor = System.Drawing.Color.Red;
            this.la_namecheck.Location = new System.Drawing.Point(217, 306);
            this.la_namecheck.Name = "la_namecheck";
            this.la_namecheck.Size = new System.Drawing.Size(93, 20);
            this.la_namecheck.TabIndex = 35;
            this.la_namecheck.Text = "姓名不能为空";
            this.la_namecheck.Visible = false;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(180, 272);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(162, 29);
            this.tb_name.TabIndex = 34;
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(73, 275);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(98, 21);
            this.la_name.TabIndex = 33;
            this.la_name.Text = "姓        名：";
            // 
            // picFPImg
            // 
            this.picFPImg.Location = new System.Drawing.Point(66, 458);
            this.picFPImg.Name = "picFPImg";
            this.picFPImg.Size = new System.Drawing.Size(104, 154);
            this.picFPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFPImg.TabIndex = 36;
            this.picFPImg.TabStop = false;
            // 
            // la_fin
            // 
            this.la_fin.AutoSize = true;
            this.la_fin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_fin.ForeColor = System.Drawing.Color.Red;
            this.la_fin.Location = new System.Drawing.Point(83, 615);
            this.la_fin.Name = "la_fin";
            this.la_fin.Size = new System.Drawing.Size(65, 20);
            this.la_fin.TabIndex = 37;
            this.la_fin.Text = "请刷指纹";
            // 
            // AddOrUpdateAministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 634);
            this.Controls.Add(this.la_fin);
            this.Controls.Add(this.picFPImg);
            this.Controls.Add(this.la_namecheck);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.la_accountnumber);
            this.Controls.Add(this.la_authoritycheck);
            this.Controls.Add(this.la_passwordcheck);
            this.Controls.Add(this.la_accountcheck);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.la_title);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_authority);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_accountnumber);
            this.Controls.Add(this.la_authority);
            this.Controls.Add(this.la_password);
            this.Controls.Add(this.la_account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateAministrator";
            this.Text = "编辑管理员信息";
            this.Load += new System.EventHandler(this.AddOrUpdateAministrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).EndInit();
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
        private System.Windows.Forms.TextBox tb_accountnumber;
        private System.Windows.Forms.Label la_authority;
        private System.Windows.Forms.Label la_password;
        private System.Windows.Forms.Label la_account;
        private System.Windows.Forms.Label la_accountnumber;
        private System.Windows.Forms.Label la_namecheck;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.PictureBox picFPImg;
        private System.Windows.Forms.Label la_fin;
    }
}