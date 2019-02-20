namespace FireProductManager.GuiPackage
{
    partial class SystemDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemDictionary));
            this.dgv_manufacturername = new System.Windows.Forms.DataGridView();
            this.la_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂商名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manufacturername)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_manufacturername
            // 
            this.dgv_manufacturername.AllowUserToAddRows = false;
            this.dgv_manufacturername.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_manufacturername.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manufacturername.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.厂商名字,
            this.删除});
            this.dgv_manufacturername.Location = new System.Drawing.Point(13, 73);
            this.dgv_manufacturername.Name = "dgv_manufacturername";
            this.dgv_manufacturername.RowTemplate.Height = 23;
            this.dgv_manufacturername.Size = new System.Drawing.Size(305, 313);
            this.dgv_manufacturername.TabIndex = 0;
            this.dgv_manufacturername.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manufacturername_CellContentClick);
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(14, 31);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(79, 20);
            this.la_name.TabIndex = 1;
            this.la_name.Text = "厂商名字：";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(99, 28);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(138, 26);
            this.tb_name.TabIndex = 2;
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_add.Location = new System.Drawing.Point(243, 26);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 28);
            this.bt_add.TabIndex = 3;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // 编号
            // 
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.Width = 52;
            // 
            // 厂商名字
            // 
            this.厂商名字.HeaderText = "厂商名字";
            this.厂商名字.Name = "厂商名字";
            this.厂商名字.Width = 160;
            // 
            // 删除
            // 
            this.删除.HeaderText = "删除";
            this.删除.Name = "删除";
            this.删除.Text = "删除";
            this.删除.UseColumnTextForButtonValue = true;
            this.删除.Width = 50;
            // 
            // SystemDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 408);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.dgv_manufacturername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SystemDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑厂家名字";
            this.Load += new System.EventHandler(this.SystemDictionary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manufacturername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_manufacturername;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂商名字;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
    }
}