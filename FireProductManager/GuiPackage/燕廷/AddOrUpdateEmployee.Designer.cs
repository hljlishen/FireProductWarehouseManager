namespace cangku_01.view.EmployeesManagement
{
    partial class AddOrUpdateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateEmployee));
            this.La_addoralter = new System.Windows.Forms.Label();
            this.la_number = new System.Windows.Forms.Label();
            this.la_employeesname = new System.Windows.Forms.Label();
            this.la_employeessex = new System.Windows.Forms.Label();
            this.Rb_sexman = new System.Windows.Forms.RadioButton();
            this.Rb_sexwoman = new System.Windows.Forms.RadioButton();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_employeesnumber = new System.Windows.Forms.TextBox();
            this.Bt_addemployee = new System.Windows.Forms.Button();
            this.Gb_sex = new System.Windows.Forms.GroupBox();
            this.la_companyname = new System.Windows.Forms.Label();
            this.la_departmentname = new System.Windows.Forms.Label();
            this.la_groupname = new System.Windows.Forms.Label();
            this.la_company = new System.Windows.Forms.Label();
            this.la_department = new System.Windows.Forms.Label();
            this.la_group = new System.Windows.Forms.Label();
            this.bt_updateemployee = new System.Windows.Forms.Button();
            this.tv_departmentshow = new System.Windows.Forms.TreeView();
            this.la_errornumber = new System.Windows.Forms.Label();
            this.la_errorname = new System.Windows.Forms.Label();
            this.la_errorgroup = new System.Windows.Forms.Label();
            this.la_errorexistnumber = new System.Windows.Forms.Label();
            this.pb_employeephoto = new System.Windows.Forms.PictureBox();
            this.Gb_sex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employeephoto)).BeginInit();
            this.SuspendLayout();
            // 
            // La_addoralter
            // 
            this.La_addoralter.AutoSize = true;
            this.La_addoralter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_addoralter.Location = new System.Drawing.Point(230, 21);
            this.La_addoralter.Name = "La_addoralter";
            this.La_addoralter.Size = new System.Drawing.Size(74, 21);
            this.La_addoralter.TabIndex = 0;
            this.La_addoralter.Text = "添加员工";
            // 
            // la_number
            // 
            this.la_number.AutoSize = true;
            this.la_number.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_number.Location = new System.Drawing.Point(57, 246);
            this.la_number.Name = "la_number";
            this.la_number.Size = new System.Drawing.Size(51, 20);
            this.la_number.TabIndex = 1;
            this.la_number.Text = "编号：";
            // 
            // la_employeesname
            // 
            this.la_employeesname.AutoSize = true;
            this.la_employeesname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_employeesname.Location = new System.Drawing.Point(57, 295);
            this.la_employeesname.Name = "la_employeesname";
            this.la_employeesname.Size = new System.Drawing.Size(51, 20);
            this.la_employeesname.TabIndex = 2;
            this.la_employeesname.Text = "姓名：";
            // 
            // la_employeessex
            // 
            this.la_employeessex.AutoSize = true;
            this.la_employeessex.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_employeessex.Location = new System.Drawing.Point(57, 354);
            this.la_employeessex.Name = "la_employeessex";
            this.la_employeessex.Size = new System.Drawing.Size(51, 20);
            this.la_employeessex.TabIndex = 3;
            this.la_employeessex.Text = "性别：";
            // 
            // Rb_sexman
            // 
            this.Rb_sexman.AutoSize = true;
            this.Rb_sexman.Checked = true;
            this.Rb_sexman.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rb_sexman.Location = new System.Drawing.Point(7, 17);
            this.Rb_sexman.Name = "Rb_sexman";
            this.Rb_sexman.Size = new System.Drawing.Size(41, 24);
            this.Rb_sexman.TabIndex = 5;
            this.Rb_sexman.TabStop = true;
            this.Rb_sexman.Text = "男";
            this.Rb_sexman.UseVisualStyleBackColor = true;
            // 
            // Rb_sexwoman
            // 
            this.Rb_sexwoman.AutoSize = true;
            this.Rb_sexwoman.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rb_sexwoman.Location = new System.Drawing.Point(60, 17);
            this.Rb_sexwoman.Name = "Rb_sexwoman";
            this.Rb_sexwoman.Size = new System.Drawing.Size(41, 24);
            this.Rb_sexwoman.TabIndex = 6;
            this.Rb_sexwoman.Text = "女";
            this.Rb_sexwoman.UseVisualStyleBackColor = true;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(105, 292);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(106, 26);
            this.tb_name.TabIndex = 10;
            // 
            // tb_employeesnumber
            // 
            this.tb_employeesnumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_employeesnumber.Location = new System.Drawing.Point(105, 243);
            this.tb_employeesnumber.Name = "tb_employeesnumber";
            this.tb_employeesnumber.Size = new System.Drawing.Size(106, 26);
            this.tb_employeesnumber.TabIndex = 11;
            // 
            // Bt_addemployee
            // 
            this.Bt_addemployee.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bt_addemployee.Location = new System.Drawing.Point(234, 541);
            this.Bt_addemployee.Name = "Bt_addemployee";
            this.Bt_addemployee.Size = new System.Drawing.Size(80, 30);
            this.Bt_addemployee.TabIndex = 12;
            this.Bt_addemployee.Text = "添加";
            this.Bt_addemployee.UseVisualStyleBackColor = true;
            this.Bt_addemployee.Click += new System.EventHandler(this.Bt_addemployee_Click);
            // 
            // Gb_sex
            // 
            this.Gb_sex.Controls.Add(this.Rb_sexwoman);
            this.Gb_sex.Controls.Add(this.Rb_sexman);
            this.Gb_sex.Location = new System.Drawing.Point(105, 338);
            this.Gb_sex.Name = "Gb_sex";
            this.Gb_sex.Size = new System.Drawing.Size(106, 49);
            this.Gb_sex.TabIndex = 13;
            this.Gb_sex.TabStop = false;
            // 
            // la_companyname
            // 
            this.la_companyname.AutoSize = true;
            this.la_companyname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_companyname.Location = new System.Drawing.Point(57, 395);
            this.la_companyname.Name = "la_companyname";
            this.la_companyname.Size = new System.Drawing.Size(51, 20);
            this.la_companyname.TabIndex = 14;
            this.la_companyname.Text = "公司：";
            // 
            // la_departmentname
            // 
            this.la_departmentname.AutoSize = true;
            this.la_departmentname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_departmentname.Location = new System.Drawing.Point(57, 426);
            this.la_departmentname.Name = "la_departmentname";
            this.la_departmentname.Size = new System.Drawing.Size(51, 20);
            this.la_departmentname.TabIndex = 15;
            this.la_departmentname.Text = "部门：";
            // 
            // la_groupname
            // 
            this.la_groupname.AutoSize = true;
            this.la_groupname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_groupname.Location = new System.Drawing.Point(57, 456);
            this.la_groupname.Name = "la_groupname";
            this.la_groupname.Size = new System.Drawing.Size(51, 20);
            this.la_groupname.TabIndex = 16;
            this.la_groupname.Text = "小组：";
            // 
            // la_company
            // 
            this.la_company.AutoSize = true;
            this.la_company.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_company.Location = new System.Drawing.Point(117, 395);
            this.la_company.Name = "la_company";
            this.la_company.Size = new System.Drawing.Size(65, 20);
            this.la_company.TabIndex = 17;
            this.la_company.Text = "员工公司";
            // 
            // la_department
            // 
            this.la_department.AutoSize = true;
            this.la_department.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_department.Location = new System.Drawing.Point(117, 426);
            this.la_department.Name = "la_department";
            this.la_department.Size = new System.Drawing.Size(65, 20);
            this.la_department.TabIndex = 18;
            this.la_department.Text = "员工部门";
            // 
            // la_group
            // 
            this.la_group.AutoSize = true;
            this.la_group.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_group.Location = new System.Drawing.Point(117, 456);
            this.la_group.Name = "la_group";
            this.la_group.Size = new System.Drawing.Size(65, 20);
            this.la_group.TabIndex = 19;
            this.la_group.Text = "员工小组";
            // 
            // bt_updateemployee
            // 
            this.bt_updateemployee.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_updateemployee.Location = new System.Drawing.Point(234, 541);
            this.bt_updateemployee.Name = "bt_updateemployee";
            this.bt_updateemployee.Size = new System.Drawing.Size(80, 30);
            this.bt_updateemployee.TabIndex = 21;
            this.bt_updateemployee.Text = "修改";
            this.bt_updateemployee.UseVisualStyleBackColor = true;
            this.bt_updateemployee.Click += new System.EventHandler(this.bt_alteremployee_Click);
            // 
            // tv_departmentshow
            // 
            this.tv_departmentshow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tv_departmentshow.Location = new System.Drawing.Point(266, 59);
            this.tv_departmentshow.Name = "tv_departmentshow";
            this.tv_departmentshow.Size = new System.Drawing.Size(221, 446);
            this.tv_departmentshow.TabIndex = 22;
            this.tv_departmentshow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_departmentshow_AfterSelect);
            // 
            // la_errornumber
            // 
            this.la_errornumber.AutoSize = true;
            this.la_errornumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errornumber.ForeColor = System.Drawing.Color.Red;
            this.la_errornumber.Location = new System.Drawing.Point(102, 272);
            this.la_errornumber.Name = "la_errornumber";
            this.la_errornumber.Size = new System.Drawing.Size(109, 17);
            this.la_errornumber.TabIndex = 80;
            this.la_errornumber.Text = "*员工编号不能为空";
            this.la_errornumber.Visible = false;
            // 
            // la_errorname
            // 
            this.la_errorname.AutoSize = true;
            this.la_errorname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorname.ForeColor = System.Drawing.Color.Red;
            this.la_errorname.Location = new System.Drawing.Point(102, 322);
            this.la_errorname.Name = "la_errorname";
            this.la_errorname.Size = new System.Drawing.Size(85, 17);
            this.la_errorname.TabIndex = 81;
            this.la_errorname.Text = "*姓名不能为空";
            this.la_errorname.Visible = false;
            // 
            // la_errorgroup
            // 
            this.la_errorgroup.AutoSize = true;
            this.la_errorgroup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorgroup.ForeColor = System.Drawing.Color.Red;
            this.la_errorgroup.Location = new System.Drawing.Point(102, 488);
            this.la_errorgroup.Name = "la_errorgroup";
            this.la_errorgroup.Size = new System.Drawing.Size(121, 17);
            this.la_errorgroup.TabIndex = 82;
            this.la_errorgroup.Text = "*未选择员工所在小组";
            this.la_errorgroup.Visible = false;
            // 
            // la_errorexistnumber
            // 
            this.la_errorexistnumber.AutoSize = true;
            this.la_errorexistnumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_errorexistnumber.ForeColor = System.Drawing.Color.Red;
            this.la_errorexistnumber.Location = new System.Drawing.Point(102, 272);
            this.la_errorexistnumber.Name = "la_errorexistnumber";
            this.la_errorexistnumber.Size = new System.Drawing.Size(97, 17);
            this.la_errorexistnumber.TabIndex = 83;
            this.la_errorexistnumber.Text = "*员工编号已存在";
            this.la_errorexistnumber.Visible = false;
            // 
            // pb_employeephoto
            // 
            this.pb_employeephoto.Location = new System.Drawing.Point(61, 59);
            this.pb_employeephoto.Name = "pb_employeephoto";
            this.pb_employeephoto.Size = new System.Drawing.Size(148, 163);
            this.pb_employeephoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_employeephoto.TabIndex = 84;
            this.pb_employeephoto.TabStop = false;
            this.pb_employeephoto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_employeephoto_MouseClick);
            // 
            // AddOrUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 583);
            this.Controls.Add(this.pb_employeephoto);
            this.Controls.Add(this.la_errorexistnumber);
            this.Controls.Add(this.la_errorgroup);
            this.Controls.Add(this.la_errorname);
            this.Controls.Add(this.la_errornumber);
            this.Controls.Add(this.tv_departmentshow);
            this.Controls.Add(this.bt_updateemployee);
            this.Controls.Add(this.la_group);
            this.Controls.Add(this.la_department);
            this.Controls.Add(this.la_company);
            this.Controls.Add(this.la_groupname);
            this.Controls.Add(this.la_departmentname);
            this.Controls.Add(this.la_companyname);
            this.Controls.Add(this.Gb_sex);
            this.Controls.Add(this.Bt_addemployee);
            this.Controls.Add(this.tb_employeesnumber);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.la_employeessex);
            this.Controls.Add(this.la_employeesname);
            this.Controls.Add(this.la_number);
            this.Controls.Add(this.La_addoralter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOrUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑员工信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrUpdateEmployee_FormClosed);
            this.Load += new System.EventHandler(this.AddOrAlterEmployees_Load);
            this.Gb_sex.ResumeLayout(false);
            this.Gb_sex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employeephoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label La_addoralter;
        private System.Windows.Forms.Label la_number;
        private System.Windows.Forms.Label la_employeesname;
        private System.Windows.Forms.Label la_employeessex;
        private System.Windows.Forms.RadioButton Rb_sexman;
        private System.Windows.Forms.RadioButton Rb_sexwoman;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_employeesnumber;
        private System.Windows.Forms.Button Bt_addemployee;
        private System.Windows.Forms.GroupBox Gb_sex;
        private System.Windows.Forms.Label la_companyname;
        private System.Windows.Forms.Label la_departmentname;
        private System.Windows.Forms.Label la_groupname;
        private System.Windows.Forms.Label la_company;
        private System.Windows.Forms.Label la_department;
        private System.Windows.Forms.Label la_group;
        private System.Windows.Forms.Button bt_updateemployee;
        private System.Windows.Forms.TreeView tv_departmentshow;
        private System.Windows.Forms.Label la_errornumber;
        private System.Windows.Forms.Label la_errorname;
        private System.Windows.Forms.Label la_errorgroup;
        private System.Windows.Forms.Label la_errorexistnumber;
        private System.Windows.Forms.PictureBox pb_employeephoto;
    }
}