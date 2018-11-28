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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_selectprojectid = new System.Windows.Forms.Button();
            this.btn_selectbarrelid = new System.Windows.Forms.Button();
            this.tb_packageid = new System.Windows.Forms.TextBox();
            this.tb_borrowName = new System.Windows.Forms.TextBox();
            this.tb_direction = new System.Windows.Forms.TextBox();
            this.tb_packageweight = new System.Windows.Forms.TextBox();
            this.tb_projectid = new System.Windows.Forms.TextBox();
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
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Hum_num = new System.Windows.Forms.Label();
            this.Tem_num = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(32, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 464);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(32, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 328);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_selectprojectid);
            this.tabPage1.Controls.Add(this.btn_selectbarrelid);
            this.tabPage1.Controls.Add(this.tb_packageid);
            this.tabPage1.Controls.Add(this.tb_borrowName);
            this.tabPage1.Controls.Add(this.tb_direction);
            this.tabPage1.Controls.Add(this.tb_packageweight);
            this.tabPage1.Controls.Add(this.tb_projectid);
            this.tabPage1.Controls.Add(this.tb_packagemodel);
            this.tabPage1.Controls.Add(this.tb_barrelid);
            this.tabPage1.Controls.Add(this.tb_packagename);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "出入库信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_selectprojectid
            // 
            this.btn_selectprojectid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_selectprojectid.Location = new System.Drawing.Point(744, 108);
            this.btn_selectprojectid.Name = "btn_selectprojectid";
            this.btn_selectprojectid.Size = new System.Drawing.Size(28, 23);
            this.btn_selectprojectid.TabIndex = 29;
            this.btn_selectprojectid.Text = "...";
            this.btn_selectprojectid.UseVisualStyleBackColor = true;
            // 
            // btn_selectbarrelid
            // 
            this.btn_selectbarrelid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_selectbarrelid.Location = new System.Drawing.Point(716, 38);
            this.btn_selectbarrelid.Name = "btn_selectbarrelid";
            this.btn_selectbarrelid.Size = new System.Drawing.Size(28, 23);
            this.btn_selectbarrelid.TabIndex = 28;
            this.btn_selectbarrelid.Text = "...";
            this.btn_selectbarrelid.UseVisualStyleBackColor = true;
            this.btn_selectbarrelid.Click += new System.EventHandler(this.btn_selectbarrelid_Click);
            // 
            // tb_packageid
            // 
            this.tb_packageid.Location = new System.Drawing.Point(582, 223);
            this.tb_packageid.Name = "tb_packageid";
            this.tb_packageid.Size = new System.Drawing.Size(156, 23);
            this.tb_packageid.TabIndex = 16;
            this.tb_packageid.TextChanged += new System.EventHandler(this.tb_packageid_TextChanged);
            // 
            // tb_borrowName
            // 
            this.tb_borrowName.Location = new System.Drawing.Point(115, 223);
            this.tb_borrowName.Name = "tb_borrowName";
            this.tb_borrowName.ReadOnly = true;
            this.tb_borrowName.Size = new System.Drawing.Size(156, 23);
            this.tb_borrowName.TabIndex = 15;
            // 
            // tb_direction
            // 
            this.tb_direction.Location = new System.Drawing.Point(554, 166);
            this.tb_direction.Name = "tb_direction";
            this.tb_direction.ReadOnly = true;
            this.tb_direction.Size = new System.Drawing.Size(156, 23);
            this.tb_direction.TabIndex = 14;
            // 
            // tb_packageweight
            // 
            this.tb_packageweight.Location = new System.Drawing.Point(138, 166);
            this.tb_packageweight.Name = "tb_packageweight";
            this.tb_packageweight.ReadOnly = true;
            this.tb_packageweight.Size = new System.Drawing.Size(156, 23);
            this.tb_packageweight.TabIndex = 13;
            // 
            // tb_projectid
            // 
            this.tb_projectid.Location = new System.Drawing.Point(582, 108);
            this.tb_projectid.Name = "tb_projectid";
            this.tb_projectid.ReadOnly = true;
            this.tb_projectid.Size = new System.Drawing.Size(156, 23);
            this.tb_projectid.TabIndex = 12;
            // 
            // tb_packagemodel
            // 
            this.tb_packagemodel.Location = new System.Drawing.Point(187, 105);
            this.tb_packagemodel.Name = "tb_packagemodel";
            this.tb_packagemodel.ReadOnly = true;
            this.tb_packagemodel.Size = new System.Drawing.Size(156, 23);
            this.tb_packagemodel.TabIndex = 11;
            // 
            // tb_barrelid
            // 
            this.tb_barrelid.Location = new System.Drawing.Point(554, 38);
            this.tb_barrelid.Name = "tb_barrelid";
            this.tb_barrelid.ReadOnly = true;
            this.tb_barrelid.Size = new System.Drawing.Size(156, 23);
            this.tb_barrelid.TabIndex = 10;
            // 
            // tb_packagename
            // 
            this.tb_packagename.Location = new System.Drawing.Point(101, 40);
            this.tb_packagename.Name = "tb_packagename";
            this.tb_packagename.ReadOnly = true;
            this.tb_packagename.Size = new System.Drawing.Size(156, 23);
            this.tb_packagename.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(497, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "袋子编号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(497, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "方向：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(497, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "项目令号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(497, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "桶号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(44, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "领用人：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(44, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "重量（g）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(44, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "规格（mm*mm）：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型：";
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Location = new System.Drawing.Point(942, 34);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(420, 189);
            this.tabControl4.TabIndex = 30;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.Hum_num);
            this.tabPage4.Controls.Add(this.Tem_num);
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Controls.Add(this.pictureBox5);
            this.tabPage4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage4.Size = new System.Drawing.Size(412, 163);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "温湿度监控信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(258, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "仓库湿度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(92, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "仓库温度";
            // 
            // Hum_num
            // 
            this.Hum_num.AutoSize = true;
            this.Hum_num.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Hum_num.Location = new System.Drawing.Point(268, 58);
            this.Hum_num.Name = "Hum_num";
            this.Hum_num.Size = new System.Drawing.Size(28, 26);
            this.Hum_num.TabIndex = 13;
            this.Hum_num.Text = "--";
            // 
            // Tem_num
            // 
            this.Tem_num.AutoSize = true;
            this.Tem_num.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tem_num.Location = new System.Drawing.Point(102, 58);
            this.Tem_num.Name = "Tem_num";
            this.Tem_num.Size = new System.Drawing.Size(28, 26);
            this.Tem_num.TabIndex = 12;
            this.Tem_num.Text = "--";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(197, 57);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(28, 57);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.tabControl4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TextBox tb_projectid;
        private System.Windows.Forms.TextBox tb_packagemodel;
        private System.Windows.Forms.TextBox tb_barrelid;
        private System.Windows.Forms.TextBox tb_packagename;
        private System.Windows.Forms.Button btn_selectbarrelid;
        private System.Windows.Forms.Button btn_selectprojectid;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Hum_num;
        private System.Windows.Forms.Label Tem_num;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}