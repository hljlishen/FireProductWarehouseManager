namespace FireProductManager.GuiPackage
{
    partial class ProjectManageme
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
            this.dgv_employeeinformation = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小组 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update_ = new System.Windows.Forms.DataGridViewButtonColumn();
            this.员工Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeeinformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_employeeinformation
            // 
            this.dgv_employeeinformation.AllowUserToAddRows = false;
            this.dgv_employeeinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employeeinformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.姓名,
            this.性别,
            this.公司,
            this.部门,
            this.小组,
            this.del,
            this.update_,
            this.员工Id});
            this.dgv_employeeinformation.Location = new System.Drawing.Point(234, 72);
            this.dgv_employeeinformation.MultiSelect = false;
            this.dgv_employeeinformation.Name = "dgv_employeeinformation";
            this.dgv_employeeinformation.RowTemplate.Height = 23;
            this.dgv_employeeinformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employeeinformation.Size = new System.Drawing.Size(913, 657);
            this.dgv_employeeinformation.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "01";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ToolTipText = "01";
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // 性别
            // 
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            this.性别.Width = 60;
            // 
            // 公司
            // 
            this.公司.HeaderText = "公司";
            this.公司.Name = "公司";
            this.公司.ReadOnly = true;
            this.公司.Width = 131;
            // 
            // 部门
            // 
            this.部门.HeaderText = "部门";
            this.部门.Name = "部门";
            this.部门.ReadOnly = true;
            this.部门.Width = 131;
            // 
            // 小组
            // 
            this.小组.HeaderText = "小组";
            this.小组.Name = "小组";
            this.小组.ReadOnly = true;
            this.小组.Width = 131;
            // 
            // del
            // 
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.del.HeaderText = "删除";
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.del.Text = "删除";
            this.del.UseColumnTextForButtonValue = true;
            this.del.Width = 108;
            // 
            // update_
            // 
            this.update_.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.update_.HeaderText = "修改";
            this.update_.Name = "update_";
            this.update_.ReadOnly = true;
            this.update_.Text = "修改";
            this.update_.UseColumnTextForButtonValue = true;
            this.update_.Width = 108;
            // 
            // 员工Id
            // 
            this.员工Id.HeaderText = "员工Id";
            this.员工Id.Name = "员工Id";
            this.员工Id.ReadOnly = true;
            this.员工Id.Visible = false;
            // 
            // ProjectManageme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 800);
            this.Controls.Add(this.dgv_employeeinformation);
            this.Name = "ProjectManageme";
            this.Text = "ProjectManageme";
            this.Load += new System.EventHandler(this.ProjectManageme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeeinformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_employeeinformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小组;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.DataGridViewButtonColumn update_;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工Id;
    }
}