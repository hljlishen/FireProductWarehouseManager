namespace FireProductManager.GuiPackage
{
    partial class BarrelManagement
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
            this.btn_addbarrel = new System.Windows.Forms.Button();
            this.tb_showaddbarrelid = new System.Windows.Forms.TextBox();
            this.btn_removebarrel = new System.Windows.Forms.Button();
            this.dgv_packageshow1 = new System.Windows.Forms.DataGridView();
            this.类型1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_packageshow2 = new System.Windows.Forms.DataGridView();
            this.类型2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_querybarrel1 = new System.Windows.Forms.Button();
            this.btn_querybarrel2 = new System.Windows.Forms.Button();
            this.lab_showbarrelid1 = new System.Windows.Forms.Label();
            this.lab_showbarrelid2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_packageshow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_packageshow2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addbarrel
            // 
            this.btn_addbarrel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addbarrel.Location = new System.Drawing.Point(38, 41);
            this.btn_addbarrel.Name = "btn_addbarrel";
            this.btn_addbarrel.Size = new System.Drawing.Size(75, 23);
            this.btn_addbarrel.TabIndex = 25;
            this.btn_addbarrel.Text = "新建桶";
            this.btn_addbarrel.UseVisualStyleBackColor = true;
            this.btn_addbarrel.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_showaddbarrelid
            // 
            this.tb_showaddbarrelid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_showaddbarrelid.Location = new System.Drawing.Point(138, 43);
            this.tb_showaddbarrelid.Name = "tb_showaddbarrelid";
            this.tb_showaddbarrelid.Size = new System.Drawing.Size(100, 23);
            this.tb_showaddbarrelid.TabIndex = 26;
            // 
            // btn_removebarrel
            // 
            this.btn_removebarrel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_removebarrel.Location = new System.Drawing.Point(343, 589);
            this.btn_removebarrel.Name = "btn_removebarrel";
            this.btn_removebarrel.Size = new System.Drawing.Size(75, 23);
            this.btn_removebarrel.TabIndex = 27;
            this.btn_removebarrel.Text = "删除桶";
            this.btn_removebarrel.UseVisualStyleBackColor = true;
            this.btn_removebarrel.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_packageshow1
            // 
            this.dgv_packageshow1.AllowUserToAddRows = false;
            this.dgv_packageshow1.AllowUserToDeleteRows = false;
            this.dgv_packageshow1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_packageshow1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_packageshow1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_packageshow1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.类型1,
            this.规格1,
            this.重量1});
            this.dgv_packageshow1.Location = new System.Drawing.Point(58, 195);
            this.dgv_packageshow1.Name = "dgv_packageshow1";
            this.dgv_packageshow1.RowTemplate.Height = 23;
            this.dgv_packageshow1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_packageshow1.Size = new System.Drawing.Size(364, 374);
            this.dgv_packageshow1.TabIndex = 28;
            // 
            // 类型1
            // 
            this.类型1.HeaderText = "类型";
            this.类型1.Name = "类型1";
            // 
            // 规格1
            // 
            this.规格1.HeaderText = "规格（mm*mm）";
            this.规格1.Name = "规格1";
            // 
            // 重量1
            // 
            this.重量1.HeaderText = "重量";
            this.重量1.Name = "重量1";
            // 
            // dgv_packageshow2
            // 
            this.dgv_packageshow2.AllowUserToAddRows = false;
            this.dgv_packageshow2.AllowUserToDeleteRows = false;
            this.dgv_packageshow2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_packageshow2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_packageshow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_packageshow2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.类型2,
            this.规格2,
            this.重量2});
            this.dgv_packageshow2.Location = new System.Drawing.Point(567, 195);
            this.dgv_packageshow2.Name = "dgv_packageshow2";
            this.dgv_packageshow2.RowTemplate.Height = 23;
            this.dgv_packageshow2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_packageshow2.Size = new System.Drawing.Size(364, 374);
            this.dgv_packageshow2.TabIndex = 29;
            // 
            // 类型2
            // 
            this.类型2.HeaderText = "类型";
            this.类型2.Name = "类型2";
            // 
            // 规格2
            // 
            this.规格2.HeaderText = "规格（mm*mm）";
            this.规格2.Name = "规格2";
            // 
            // 重量2
            // 
            this.重量2.HeaderText = "重量";
            this.重量2.Name = "重量2";
            // 
            // btn_querybarrel1
            // 
            this.btn_querybarrel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_querybarrel1.Location = new System.Drawing.Point(58, 166);
            this.btn_querybarrel1.Name = "btn_querybarrel1";
            this.btn_querybarrel1.Size = new System.Drawing.Size(75, 23);
            this.btn_querybarrel1.TabIndex = 30;
            this.btn_querybarrel1.Text = "选择桶";
            this.btn_querybarrel1.UseVisualStyleBackColor = true;
            this.btn_querybarrel1.Click += new System.EventHandler(this.btn_querybarrel1_Click);
            // 
            // btn_querybarrel2
            // 
            this.btn_querybarrel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_querybarrel2.Location = new System.Drawing.Point(567, 166);
            this.btn_querybarrel2.Name = "btn_querybarrel2";
            this.btn_querybarrel2.Size = new System.Drawing.Size(75, 23);
            this.btn_querybarrel2.TabIndex = 31;
            this.btn_querybarrel2.Text = "选择桶";
            this.btn_querybarrel2.UseVisualStyleBackColor = true;
            this.btn_querybarrel2.Click += new System.EventHandler(this.btn_querybarrel2_Click);
            // 
            // lab_showbarrelid1
            // 
            this.lab_showbarrelid1.AutoSize = true;
            this.lab_showbarrelid1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_showbarrelid1.Location = new System.Drawing.Point(210, 170);
            this.lab_showbarrelid1.Name = "lab_showbarrelid1";
            this.lab_showbarrelid1.Size = new System.Drawing.Size(0, 21);
            this.lab_showbarrelid1.TabIndex = 32;
            // 
            // lab_showbarrelid2
            // 
            this.lab_showbarrelid2.AutoSize = true;
            this.lab_showbarrelid2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_showbarrelid2.Location = new System.Drawing.Point(718, 171);
            this.lab_showbarrelid2.Name = "lab_showbarrelid2";
            this.lab_showbarrelid2.Size = new System.Drawing.Size(0, 21);
            this.lab_showbarrelid2.TabIndex = 33;
            // 
            // BarrelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.lab_showbarrelid2);
            this.Controls.Add(this.lab_showbarrelid1);
            this.Controls.Add(this.btn_querybarrel2);
            this.Controls.Add(this.btn_querybarrel1);
            this.Controls.Add(this.dgv_packageshow2);
            this.Controls.Add(this.dgv_packageshow1);
            this.Controls.Add(this.btn_removebarrel);
            this.Controls.Add(this.tb_showaddbarrelid);
            this.Controls.Add(this.btn_addbarrel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BarrelManagement";
            this.Text = "管理桶";
            this.Load += new System.EventHandler(this.BarrelManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_packageshow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_packageshow2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addbarrel;
        private System.Windows.Forms.TextBox tb_showaddbarrelid;
        private System.Windows.Forms.Button btn_removebarrel;
        private System.Windows.Forms.DataGridView dgv_packageshow1;
        private System.Windows.Forms.DataGridView dgv_packageshow2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量2;
        private System.Windows.Forms.Button btn_querybarrel1;
        private System.Windows.Forms.Button btn_querybarrel2;
        private System.Windows.Forms.Label lab_showbarrelid1;
        private System.Windows.Forms.Label lab_showbarrelid2;
    }
}