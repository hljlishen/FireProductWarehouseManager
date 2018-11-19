namespace FireProductManager.GuiPackage
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.AdminName = new System.Windows.Forms.Label();
            this.AdminPassWord = new System.Windows.Forms.Label();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.but_login = new System.Windows.Forms.Button();
            this.lab_tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminName
            // 
            this.AdminName.AutoSize = true;
            this.AdminName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AdminName.Location = new System.Drawing.Point(78, 79);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(74, 21);
            this.AdminName.TabIndex = 0;
            this.AdminName.Text = "用户名：";
            // 
            // AdminPassWord
            // 
            this.AdminPassWord.AutoSize = true;
            this.AdminPassWord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AdminPassWord.Location = new System.Drawing.Point(78, 142);
            this.AdminPassWord.Name = "AdminPassWord";
            this.AdminPassWord.Size = new System.Drawing.Size(58, 21);
            this.AdminPassWord.TabIndex = 1;
            this.AdminPassWord.Text = "密码：";
            // 
            // tb_account
            // 
            this.tb_account.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_account.Location = new System.Drawing.Point(152, 79);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(156, 29);
            this.tb_account.TabIndex = 2;
            this.tb_account.Text = "1";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_password.Location = new System.Drawing.Point(152, 139);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(156, 29);
            this.tb_password.TabIndex = 3;
            this.tb_password.Text = "1";
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // but_login
            // 
            this.but_login.Location = new System.Drawing.Point(129, 241);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(113, 30);
            this.but_login.TabIndex = 4;
            this.but_login.Text = "登   录";
            this.but_login.UseVisualStyleBackColor = true;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // lab_tip
            // 
            this.lab_tip.AutoSize = true;
            this.lab_tip.ForeColor = System.Drawing.Color.Red;
            this.lab_tip.Location = new System.Drawing.Point(150, 203);
            this.lab_tip.Name = "lab_tip";
            this.lab_tip.Size = new System.Drawing.Size(0, 12);
            this.lab_tip.TabIndex = 5;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 343);
            this.Controls.Add(this.lab_tip);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.AdminPassWord);
            this.Controls.Add(this.AdminName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员登录";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Label AdminName;
        private System.Windows.Forms.Label AdminPassWord;
        private System.Windows.Forms.Label lab_tip;
    }
}