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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_addbarrel = new System.Windows.Forms.Button();
            this.tb_showaddbarrelid = new System.Windows.Forms.TextBox();
            this.btn_removebarrel1 = new System.Windows.Forms.Button();
            this.dgv_packageshow1 = new System.Windows.Forms.DataGridView();
            this.包id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_packageshow2 = new System.Windows.Forms.DataGridView();
            this.包id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_querybarrel1 = new System.Windows.Forms.Button();
            this.btn_querybarrel2 = new System.Windows.Forms.Button();
            this.lab_showbarrelid1 = new System.Windows.Forms.Label();
            this.lab_showbarrelid2 = new System.Windows.Forms.Label();
            this.btn_exchangepackageid1 = new System.Windows.Forms.Button();
            this.btn_exchangepackageid2 = new System.Windows.Forms.Button();
            this.btn_removebarrel2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_packageshow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_packageshow2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addbarrel
            // 
            this.btn_addbarrel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addbarrel.Location = new System.Drawing.Point(58, 43);
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
            this.tb_showaddbarrelid.Location = new System.Drawing.Point(159, 43);
            this.tb_showaddbarrelid.Name = "tb_showaddbarrelid";
            this.tb_showaddbarrelid.Size = new System.Drawing.Size(100, 23);
            this.tb_showaddbarrelid.TabIndex = 26;
            // 
            // btn_removebarrel1
            // 
            this.btn_removebarrel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_removebarrel1.Location = new System.Drawing.Point(538, 731);
            this.btn_removebarrel1.Name = "btn_removebarrel1";
            this.btn_removebarrel1.Size = new System.Drawing.Size(75, 23);
            this.btn_removebarrel1.TabIndex = 27;
            this.btn_removebarrel1.Text = "删除桶";
            this.btn_removebarrel1.UseVisualStyleBackColor = true;
            this.btn_removebarrel1.Click += new System.EventHandler(this.btn_removebarrel_Click);
            // 
            // dgv_packageshow1
            // 
            this.dgv_packageshow1.AllowUserToAddRows = false;
            this.dgv_packageshow1.AllowUserToDeleteRows = false;
            this.dgv_packageshow1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_packageshow1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_packageshow1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_packageshow1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_packageshow1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.包id1,
            this.类型1,
            this.规格1,
            this.重量1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_packageshow1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_packageshow1.Location = new System.Drawing.Point(253, 158);
            this.dgv_packageshow1.Name = "dgv_packageshow1";
            this.dgv_packageshow1.RowTemplate.Height = 23;
            this.dgv_packageshow1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_packageshow1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_packageshow1.Size = new System.Drawing.Size(364, 558);
            this.dgv_packageshow1.TabIndex = 28;
            // 
            // 包id1
            // 
            this.包id1.HeaderText = "袋子id";
            this.包id1.Name = "包id1";
            this.包id1.ReadOnly = true;
            this.包id1.Visible = false;
            // 
            // 类型1
            // 
            this.类型1.HeaderText = "类型";
            this.类型1.Name = "类型1";
            this.类型1.ReadOnly = true;
            this.类型1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 规格1
            // 
            this.规格1.HeaderText = "规格（mm*mm）";
            this.规格1.Name = "规格1";
            this.规格1.ReadOnly = true;
            // 
            // 重量1
            // 
            this.重量1.HeaderText = "重量";
            this.重量1.Name = "重量1";
            this.重量1.ReadOnly = true;
            // 
            // dgv_packageshow2
            // 
            this.dgv_packageshow2.AllowUserToAddRows = false;
            this.dgv_packageshow2.AllowUserToDeleteRows = false;
            this.dgv_packageshow2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_packageshow2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_packageshow2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_packageshow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_packageshow2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.包id2,
            this.类型2,
            this.规格2,
            this.重量2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_packageshow2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_packageshow2.Location = new System.Drawing.Point(762, 158);
            this.dgv_packageshow2.Name = "dgv_packageshow2";
            this.dgv_packageshow2.RowTemplate.Height = 23;
            this.dgv_packageshow2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_packageshow2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_packageshow2.Size = new System.Drawing.Size(364, 558);
            this.dgv_packageshow2.TabIndex = 29;
            // 
            // 包id2
            // 
            this.包id2.HeaderText = "袋子id";
            this.包id2.Name = "包id2";
            this.包id2.ReadOnly = true;
            this.包id2.Visible = false;
            // 
            // 类型2
            // 
            this.类型2.HeaderText = "类型";
            this.类型2.Name = "类型2";
            this.类型2.ReadOnly = true;
            this.类型2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 规格2
            // 
            this.规格2.HeaderText = "规格（mm*mm）";
            this.规格2.Name = "规格2";
            this.规格2.ReadOnly = true;
            // 
            // 重量2
            // 
            this.重量2.HeaderText = "重量";
            this.重量2.Name = "重量2";
            this.重量2.ReadOnly = true;
            // 
            // btn_querybarrel1
            // 
            this.btn_querybarrel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_querybarrel1.Location = new System.Drawing.Point(253, 129);
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
            this.btn_querybarrel2.Location = new System.Drawing.Point(762, 129);
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
            this.lab_showbarrelid1.Location = new System.Drawing.Point(405, 133);
            this.lab_showbarrelid1.Name = "lab_showbarrelid1";
            this.lab_showbarrelid1.Size = new System.Drawing.Size(0, 21);
            this.lab_showbarrelid1.TabIndex = 32;
            // 
            // lab_showbarrelid2
            // 
            this.lab_showbarrelid2.AutoSize = true;
            this.lab_showbarrelid2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_showbarrelid2.Location = new System.Drawing.Point(913, 134);
            this.lab_showbarrelid2.Name = "lab_showbarrelid2";
            this.lab_showbarrelid2.Size = new System.Drawing.Size(0, 21);
            this.lab_showbarrelid2.TabIndex = 33;
            // 
            // btn_exchangepackageid1
            // 
            this.btn_exchangepackageid1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exchangepackageid1.Location = new System.Drawing.Point(674, 383);
            this.btn_exchangepackageid1.Name = "btn_exchangepackageid1";
            this.btn_exchangepackageid1.Size = new System.Drawing.Size(37, 37);
            this.btn_exchangepackageid1.TabIndex = 34;
            this.btn_exchangepackageid1.Text = ">>";
            this.btn_exchangepackageid1.UseVisualStyleBackColor = true;
            this.btn_exchangepackageid1.Click += new System.EventHandler(this.btn_exchangepackageid1_Click);
            // 
            // btn_exchangepackageid2
            // 
            this.btn_exchangepackageid2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exchangepackageid2.Location = new System.Drawing.Point(674, 478);
            this.btn_exchangepackageid2.Name = "btn_exchangepackageid2";
            this.btn_exchangepackageid2.Size = new System.Drawing.Size(37, 37);
            this.btn_exchangepackageid2.TabIndex = 35;
            this.btn_exchangepackageid2.Text = "<<";
            this.btn_exchangepackageid2.UseVisualStyleBackColor = true;
            this.btn_exchangepackageid2.Click += new System.EventHandler(this.btn_exchangepackageid2_Click);
            // 
            // btn_removebarrel2
            // 
            this.btn_removebarrel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_removebarrel2.Location = new System.Drawing.Point(1051, 731);
            this.btn_removebarrel2.Name = "btn_removebarrel2";
            this.btn_removebarrel2.Size = new System.Drawing.Size(75, 23);
            this.btn_removebarrel2.TabIndex = 36;
            this.btn_removebarrel2.Text = "删除桶";
            this.btn_removebarrel2.UseVisualStyleBackColor = true;
            this.btn_removebarrel2.Click += new System.EventHandler(this.btn_removebarrel2_Click);
            // 
            // BarrelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.btn_removebarrel2);
            this.Controls.Add(this.btn_exchangepackageid2);
            this.Controls.Add(this.btn_exchangepackageid1);
            this.Controls.Add(this.lab_showbarrelid2);
            this.Controls.Add(this.lab_showbarrelid1);
            this.Controls.Add(this.btn_querybarrel2);
            this.Controls.Add(this.btn_querybarrel1);
            this.Controls.Add(this.dgv_packageshow2);
            this.Controls.Add(this.dgv_packageshow1);
            this.Controls.Add(this.btn_removebarrel1);
            this.Controls.Add(this.tb_showaddbarrelid);
            this.Controls.Add(this.btn_addbarrel);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarrelManagement";
            this.Text = " ";
            this.Load += new System.EventHandler(this.BarrelManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_packageshow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_packageshow2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addbarrel;
        private System.Windows.Forms.TextBox tb_showaddbarrelid;
        private System.Windows.Forms.Button btn_removebarrel1;
        private System.Windows.Forms.DataGridView dgv_packageshow1;
        private System.Windows.Forms.DataGridView dgv_packageshow2;
        private System.Windows.Forms.Button btn_querybarrel1;
        private System.Windows.Forms.Button btn_querybarrel2;
        private System.Windows.Forms.Label lab_showbarrelid1;
        private System.Windows.Forms.Label lab_showbarrelid2;
        private System.Windows.Forms.Button btn_exchangepackageid1;
        private System.Windows.Forms.Button btn_exchangepackageid2;
        private System.Windows.Forms.Button btn_removebarrel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 包id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 包id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量2;
    }
}