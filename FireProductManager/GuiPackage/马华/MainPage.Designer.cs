namespace FireProductManager.GuiPackage
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btn_packageid = new System.Windows.Forms.Button();
            this.la_borrow = new System.Windows.Forms.Label();
            this.btn_borrowemployee = new System.Windows.Forms.Button();
            this.la_packagewigth = new System.Windows.Forms.Label();
            this.tb_packageid = new System.Windows.Forms.TextBox();
            this.tb_borrowName = new System.Windows.Forms.TextBox();
            this.tb_direction = new System.Windows.Forms.TextBox();
            this.tb_packageweight = new System.Windows.Forms.TextBox();
            this.tb_projectpassword = new System.Windows.Forms.TextBox();
            this.tb_packagemodel = new System.Windows.Forms.TextBox();
            this.tb_barrelid = new System.Windows.Forms.TextBox();
            this.tb_packagename = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Hum_num = new System.Windows.Forms.Label();
            this.Tem_num = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lv_inoroutrecord = new System.Windows.Forms.ListView();
            this.序号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_projectPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_packageid
            // 
            this.btn_packageid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_packageid.Location = new System.Drawing.Point(679, 304);
            this.btn_packageid.Name = "btn_packageid";
            this.btn_packageid.Size = new System.Drawing.Size(92, 23);
            this.btn_packageid.TabIndex = 37;
            this.btn_packageid.Text = "生成新二维码";
            this.btn_packageid.UseVisualStyleBackColor = true;
            this.btn_packageid.Click += new System.EventHandler(this.btn_packageid_Click);
            // 
            // la_borrow
            // 
            this.la_borrow.AutoSize = true;
            this.la_borrow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_borrow.ForeColor = System.Drawing.Color.Red;
            this.la_borrow.Location = new System.Drawing.Point(186, 214);
            this.la_borrow.Name = "la_borrow";
            this.la_borrow.Size = new System.Drawing.Size(92, 17);
            this.la_borrow.TabIndex = 36;
            this.la_borrow.Text = "领用人不能为空";
            // 
            // btn_borrowemployee
            // 
            this.btn_borrowemployee.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_borrowemployee.Location = new System.Drawing.Point(317, 184);
            this.btn_borrowemployee.Name = "btn_borrowemployee";
            this.btn_borrowemployee.Size = new System.Drawing.Size(28, 23);
            this.btn_borrowemployee.TabIndex = 35;
            this.btn_borrowemployee.Text = "...";
            this.btn_borrowemployee.UseVisualStyleBackColor = true;
            this.btn_borrowemployee.Click += new System.EventHandler(this.btn_borrowemployee_Click);
            // 
            // la_packagewigth
            // 
            this.la_packagewigth.AutoSize = true;
            this.la_packagewigth.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_packagewigth.ForeColor = System.Drawing.Color.Red;
            this.la_packagewigth.Location = new System.Drawing.Point(216, 144);
            this.la_packagewigth.Name = "la_packagewigth";
            this.la_packagewigth.Size = new System.Drawing.Size(80, 17);
            this.la_packagewigth.TabIndex = 34;
            this.la_packagewigth.Text = "重量不能为空";
            // 
            // tb_packageid
            // 
            this.tb_packageid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_packageid.Location = new System.Drawing.Point(557, 253);
            this.tb_packageid.Name = "tb_packageid";
            this.tb_packageid.Size = new System.Drawing.Size(140, 23);
            this.tb_packageid.TabIndex = 16;
            this.tb_packageid.TextChanged += new System.EventHandler(this.tb_packageid_TextChanged);
            // 
            // tb_borrowName
            // 
            this.tb_borrowName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_borrowName.Location = new System.Drawing.Point(162, 184);
            this.tb_borrowName.Name = "tb_borrowName";
            this.tb_borrowName.ReadOnly = true;
            this.tb_borrowName.Size = new System.Drawing.Size(140, 23);
            this.tb_borrowName.TabIndex = 15;
            // 
            // tb_direction
            // 
            this.tb_direction.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_direction.Location = new System.Drawing.Point(533, 114);
            this.tb_direction.Name = "tb_direction";
            this.tb_direction.ReadOnly = true;
            this.tb_direction.Size = new System.Drawing.Size(140, 23);
            this.tb_direction.TabIndex = 14;
            // 
            // tb_packageweight
            // 
            this.tb_packageweight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_packageweight.Location = new System.Drawing.Point(181, 116);
            this.tb_packageweight.Name = "tb_packageweight";
            this.tb_packageweight.ReadOnly = true;
            this.tb_packageweight.Size = new System.Drawing.Size(140, 23);
            this.tb_packageweight.TabIndex = 13;
            // 
            // tb_projectpassword
            // 
            this.tb_projectpassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_projectpassword.Location = new System.Drawing.Point(557, 184);
            this.tb_projectpassword.Name = "tb_projectpassword";
            this.tb_projectpassword.ReadOnly = true;
            this.tb_projectpassword.Size = new System.Drawing.Size(140, 23);
            this.tb_projectpassword.TabIndex = 12;
            // 
            // tb_packagemodel
            // 
            this.tb_packagemodel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_packagemodel.Location = new System.Drawing.Point(232, 253);
            this.tb_packagemodel.Name = "tb_packagemodel";
            this.tb_packagemodel.ReadOnly = true;
            this.tb_packagemodel.Size = new System.Drawing.Size(140, 23);
            this.tb_packagemodel.TabIndex = 11;
            // 
            // tb_barrelid
            // 
            this.tb_barrelid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_barrelid.Location = new System.Drawing.Point(529, 44);
            this.tb_barrelid.Name = "tb_barrelid";
            this.tb_barrelid.ReadOnly = true;
            this.tb_barrelid.Size = new System.Drawing.Size(140, 23);
            this.tb_barrelid.TabIndex = 10;
            // 
            // tb_packagename
            // 
            this.tb_packagename.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_packagename.Location = new System.Drawing.Point(171, 46);
            this.tb_packagename.Name = "tb_packagename";
            this.tb_packagename.ReadOnly = true;
            this.tb_packagename.Size = new System.Drawing.Size(140, 23);
            this.tb_packagename.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(472, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "袋子编号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(476, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "方向：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(472, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "项目令号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(472, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "桶号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(91, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "领用人：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(89, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "重量（g）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(89, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "规格（mm*mm）：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(89, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "材料名称：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(359, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "仓库湿度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(109, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "仓库温度";
            // 
            // Hum_num
            // 
            this.Hum_num.AutoSize = true;
            this.Hum_num.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Hum_num.Location = new System.Drawing.Point(369, 62);
            this.Hum_num.Name = "Hum_num";
            this.Hum_num.Size = new System.Drawing.Size(28, 26);
            this.Hum_num.TabIndex = 13;
            this.Hum_num.Text = "--";
            // 
            // Tem_num
            // 
            this.Tem_num.AutoSize = true;
            this.Tem_num.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tem_num.Location = new System.Drawing.Point(119, 63);
            this.Tem_num.Name = "Tem_num";
            this.Tem_num.Size = new System.Drawing.Size(28, 26);
            this.Tem_num.TabIndex = 12;
            this.Tem_num.Text = "--";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(298, 61);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(45, 62);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // lv_inoroutrecord
            // 
            this.lv_inoroutrecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.序号,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6});
            this.lv_inoroutrecord.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lv_inoroutrecord.Location = new System.Drawing.Point(6, 19);
            this.lv_inoroutrecord.Name = "lv_inoroutrecord";
            this.lv_inoroutrecord.Size = new System.Drawing.Size(774, 307);
            this.lv_inoroutrecord.TabIndex = 0;
            this.lv_inoroutrecord.UseCompatibleStateImageBehavior = false;
            this.lv_inoroutrecord.View = System.Windows.Forms.View.Details;
            // 
            // 序号
            // 
            this.序号.Text = "序号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "材料名称";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "规格（mm*mm）";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "重量（g）";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "桶号";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "项目令号";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "方向";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "时间";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "领用人";
            this.columnHeader6.Width = 85;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_projectPassword);
            this.groupBox1.Controls.Add(this.tb_borrowName);
            this.groupBox1.Controls.Add(this.btn_packageid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_packagename);
            this.groupBox1.Controls.Add(this.la_borrow);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_barrelid);
            this.groupBox1.Controls.Add(this.btn_borrowemployee);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.la_packagewigth);
            this.groupBox1.Controls.Add(this.tb_packagemodel);
            this.groupBox1.Controls.Add(this.tb_projectpassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_packageid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_packageweight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_direction);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(54, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 338);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出入库信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_inoroutrecord);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(54, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 333);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出入库记录";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.Hum_num);
            this.groupBox3.Controls.Add(this.Tem_num);
            this.groupBox3.Location = new System.Drawing.Point(881, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 174);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "温湿度记录";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Location = new System.Drawing.Point(881, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(483, 501);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "余量提醒";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 475);
            this.panel1.TabIndex = 0;
            // 
            // btn_projectPassword
            // 
            this.btn_projectPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_projectPassword.Location = new System.Drawing.Point(703, 184);
            this.btn_projectPassword.Name = "btn_projectPassword";
            this.btn_projectPassword.Size = new System.Drawing.Size(28, 23);
            this.btn_projectPassword.TabIndex = 38;
            this.btn_projectPassword.Text = "...";
            this.btn_projectPassword.UseVisualStyleBackColor = true;
            this.btn_projectPassword.Click += new System.EventHandler(this.btn_projectPassword_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 832);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_packageid;
        private System.Windows.Forms.TextBox tb_borrowName;
        private System.Windows.Forms.TextBox tb_direction;
        private System.Windows.Forms.TextBox tb_packageweight;
        private System.Windows.Forms.TextBox tb_projectpassword;
        private System.Windows.Forms.TextBox tb_packagemodel;
        private System.Windows.Forms.TextBox tb_barrelid;
        private System.Windows.Forms.TextBox tb_packagename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Hum_num;
        private System.Windows.Forms.Label Tem_num;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label la_packagewigth;
        private System.Windows.Forms.ListView lv_inoroutrecord;
        private System.Windows.Forms.ColumnHeader 序号;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_borrowemployee;
        private System.Windows.Forms.Label la_borrow;
        private System.Windows.Forms.Button btn_packageid;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_projectPassword;
    }
}