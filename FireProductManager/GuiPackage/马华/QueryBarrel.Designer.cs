namespace FireProductManager.GuiPackage
{
    partial class QueryBarrel
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
            this.dgv_existbarrelid = new System.Windows.Forms.DataGridView();
            this.桶编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.全重 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existbarrelid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_existbarrelid
            // 
            this.dgv_existbarrelid.AllowUserToAddRows = false;
            this.dgv_existbarrelid.AllowUserToDeleteRows = false;
            this.dgv_existbarrelid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_existbarrelid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_existbarrelid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.桶编号,
            this.全重});
            this.dgv_existbarrelid.Location = new System.Drawing.Point(12, 12);
            this.dgv_existbarrelid.MultiSelect = false;
            this.dgv_existbarrelid.Name = "dgv_existbarrelid";
            this.dgv_existbarrelid.RowTemplate.Height = 23;
            this.dgv_existbarrelid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_existbarrelid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_existbarrelid.Size = new System.Drawing.Size(234, 474);
            this.dgv_existbarrelid.TabIndex = 0;
            this.dgv_existbarrelid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_existbarrelid_CellDoubleClick);
            // 
            // 桶编号
            // 
            this.桶编号.HeaderText = "桶编号";
            this.桶编号.Name = "桶编号";
            this.桶编号.ReadOnly = true;
            this.桶编号.Width = 99;
            // 
            // 全重
            // 
            this.全重.HeaderText = "全重(g)";
            this.全重.Name = "全重";
            this.全重.ReadOnly = true;
            this.全重.Width = 98;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(97, 492);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 1;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // QueryBarrel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(258, 525);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.dgv_existbarrelid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QueryBarrel";
            this.Text = "QueryBarrel";
            this.Load += new System.EventHandler(this.QueryBarrel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existbarrelid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_existbarrelid;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn 桶编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 全重;
    }
}