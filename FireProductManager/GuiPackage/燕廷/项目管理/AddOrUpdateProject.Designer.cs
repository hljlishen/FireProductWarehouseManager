namespace FireProductManager.GuiPackage
{
    partial class AddOrUpdateProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateProject));
            this.bt_updateproject = new System.Windows.Forms.Button();
            this.bt_addproject = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_projectpassword = new System.Windows.Forms.TextBox();
            this.la_projectpassword = new System.Windows.Forms.Label();
            this.la_name = new System.Windows.Forms.Label();
            this.la_addoralter = new System.Windows.Forms.Label();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.la_note = new System.Windows.Forms.Label();
            this.la_errorname = new System.Windows.Forms.Label();
            this.la_errorprojectpassword = new System.Windows.Forms.Label();
            this.la_errornote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_updateproject
            // 
            this.bt_updateproject.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_updateproject.Location = new System.Drawing.Point(237, 536);
            this.bt_updateproject.Name = "bt_updateproject";
            this.bt_updateproject.Size = new System.Drawing.Size(80, 30);
            this.bt_updateproject.TabIndex = 99;
            this.bt_updateproject.Text = "修改";
            this.bt_updateproject.UseVisualStyleBackColor = true;
            this.bt_updateproject.Click += new System.EventHandler(this.bt_updateproject_Click);
            // 
            // bt_addproject
            // 
            this.bt_addproject.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_addproject.Location = new System.Drawing.Point(237, 536);
            this.bt_addproject.Name = "bt_addproject";
            this.bt_addproject.Size = new System.Drawing.Size(80, 30);
            this.bt_addproject.TabIndex = 91;
            this.bt_addproject.Text = "添加";
            this.bt_addproject.UseVisualStyleBackColor = true;
            this.bt_addproject.Click += new System.EventHandler(this.Bt_addproject_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(133, 107);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(106, 26);
            this.tb_name.TabIndex = 90;
            // 
            // tb_projectpassword
            // 
            this.tb_projectpassword.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_projectpassword.Location = new System.Drawing.Point(133, 162);
            this.tb_projectpassword.Name = "tb_projectpassword";
            this.tb_projectpassword.Size = new System.Drawing.Size(106, 26);
            this.tb_projectpassword.TabIndex = 89;
            // 
            // la_projectpassword
            // 
            this.la_projectpassword.AutoSize = true;
            this.la_projectpassword.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_projectpassword.Location = new System.Drawing.Point(54, 165);
            this.la_projectpassword.Name = "la_projectpassword";
            this.la_projectpassword.Size = new System.Drawing.Size(79, 20);
            this.la_projectpassword.TabIndex = 87;
            this.la_projectpassword.Text = "项目令号：";
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(54, 110);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(79, 20);
            this.la_name.TabIndex = 86;
            this.la_name.Text = "项目名称：";
            // 
            // la_addoralter
            // 
            this.la_addoralter.AutoSize = true;
            this.la_addoralter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_addoralter.Location = new System.Drawing.Point(233, 42);
            this.la_addoralter.Name = "la_addoralter";
            this.la_addoralter.Size = new System.Drawing.Size(0, 21);
            this.la_addoralter.TabIndex = 85;
            // 
            // tb_note
            // 
            this.tb_note.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_note.Location = new System.Drawing.Point(133, 222);
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(311, 229);
            this.tb_note.TabIndex = 101;
            // 
            // la_note
            // 
            this.la_note.AutoSize = true;
            this.la_note.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_note.Location = new System.Drawing.Point(54, 222);
            this.la_note.Name = "la_note";
            this.la_note.Size = new System.Drawing.Size(51, 20);
            this.la_note.TabIndex = 100;
            this.la_note.Text = "备注：";
            // 
            // la_errorname
            // 
            this.la_errorname.AutoSize = true;
            this.la_errorname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorname.ForeColor = System.Drawing.Color.Red;
            this.la_errorname.Location = new System.Drawing.Point(130, 136);
            this.la_errorname.Name = "la_errorname";
            this.la_errorname.Size = new System.Drawing.Size(109, 17);
            this.la_errorname.TabIndex = 102;
            this.la_errorname.Text = "*项目名称不能为空";
            this.la_errorname.Visible = false;
            // 
            // la_errorprojectpassword
            // 
            this.la_errorprojectpassword.AutoSize = true;
            this.la_errorprojectpassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorprojectpassword.ForeColor = System.Drawing.Color.Red;
            this.la_errorprojectpassword.Location = new System.Drawing.Point(130, 191);
            this.la_errorprojectpassword.Name = "la_errorprojectpassword";
            this.la_errorprojectpassword.Size = new System.Drawing.Size(109, 17);
            this.la_errorprojectpassword.TabIndex = 103;
            this.la_errorprojectpassword.Text = "*项目令号不能为空";
            this.la_errorprojectpassword.Visible = false;
            // 
            // la_errornote
            // 
            this.la_errornote.AutoSize = true;
            this.la_errornote.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errornote.ForeColor = System.Drawing.Color.Red;
            this.la_errornote.Location = new System.Drawing.Point(130, 454);
            this.la_errornote.Name = "la_errornote";
            this.la_errornote.Size = new System.Drawing.Size(73, 17);
            this.la_errornote.TabIndex = 104;
            this.la_errornote.Text = "*未填写备注";
            this.la_errornote.Visible = false;
            // 
            // AddOrUpdateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 583);
            this.Controls.Add(this.la_errornote);
            this.Controls.Add(this.la_errorprojectpassword);
            this.Controls.Add(this.la_errorname);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.la_note);
            this.Controls.Add(this.bt_updateproject);
            this.Controls.Add(this.bt_addproject);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_projectpassword);
            this.Controls.Add(this.la_projectpassword);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.la_addoralter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrUpdateProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑项目信息";
            this.Load += new System.EventHandler(this.AddOrUpdateProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_updateproject;
        private System.Windows.Forms.Button bt_addproject;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_projectpassword;
        private System.Windows.Forms.Label la_projectpassword;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.Label la_addoralter;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.Label la_note;
        private System.Windows.Forms.Label la_errorname;
        private System.Windows.Forms.Label la_errorprojectpassword;
        private System.Windows.Forms.Label la_errornote;
    }
}