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
            this.components = new System.ComponentModel.Container();
            this.dgv_existbarrelid = new System.Windows.Forms.DataGridView();
            this.桶编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.全重 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_return = new System.Windows.Forms.Button();
            this.dgv_package = new System.Windows.Forms.DataGridView();
            this.袋子编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existbarrelid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_package)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_existbarrelid
            // 
            this.dgv_existbarrelid.AllowUserToAddRows = false;
            this.dgv_existbarrelid.AllowUserToDeleteRows = false;
            this.dgv_existbarrelid.AllowUserToResizeColumns = false;
            this.dgv_existbarrelid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_existbarrelid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.桶编号,
            this.全重});
            this.dgv_existbarrelid.Location = new System.Drawing.Point(12, 12);
            this.dgv_existbarrelid.Name = "dgv_existbarrelid";
            this.dgv_existbarrelid.RowTemplate.Height = 23;
            this.dgv_existbarrelid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_existbarrelid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_existbarrelid.Size = new System.Drawing.Size(234, 474);
            this.dgv_existbarrelid.TabIndex = 0;
            this.dgv_existbarrelid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_existbarrelid_CellMouseClick);
            this.dgv_existbarrelid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_existbarrelid_CellMouseDoubleClick);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 选择ToolStripMenuItem
            // 
            this.选择ToolStripMenuItem.Name = "选择ToolStripMenuItem";
            this.选择ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.选择ToolStripMenuItem.Text = "选择";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(333, 492);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 1;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // dgv_package
            // 
            this.dgv_package.AllowUserToAddRows = false;
            this.dgv_package.AllowUserToDeleteRows = false;
            this.dgv_package.AllowUserToResizeColumns = false;
            this.dgv_package.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_package.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_package.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.袋子编号,
            this.类型,
            this.规格,
            this.重量});
            this.dgv_package.Location = new System.Drawing.Point(252, 12);
            this.dgv_package.Name = "dgv_package";
            this.dgv_package.RowTemplate.Height = 23;
            this.dgv_package.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_package.Size = new System.Drawing.Size(467, 474);
            this.dgv_package.TabIndex = 2;
            // 
            // 袋子编号
            // 
            this.袋子编号.HeaderText = "袋子编号";
            this.袋子编号.Name = "袋子编号";
            // 
            // 类型
            // 
            this.类型.HeaderText = "材料类型";
            this.类型.Name = "类型";
            // 
            // 规格
            // 
            this.规格.HeaderText = "规格（mm*mm）";
            this.规格.Name = "规格";
            // 
            // 重量
            // 
            this.重量.HeaderText = "重量（g）";
            this.重量.Name = "重量";
            // 
            // QueryBarrel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(724, 525);
            this.Controls.Add(this.dgv_package);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.dgv_existbarrelid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryBarrel";
            this.Text = "选择桶";
            this.Load += new System.EventHandler(this.QueryBarrel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_existbarrelid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_package)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_existbarrelid;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn 桶编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 全重;
        private System.Windows.Forms.DataGridView dgv_package;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选择ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 袋子编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量;
    }
}