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
            this.dgv_projectinformation = new System.Windows.Forms.DataGridView();
            this.项目名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目令号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update_ = new System.Windows.Forms.DataGridViewButtonColumn();
            this.项目Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.la_project = new System.Windows.Forms.Label();
            this.tb_project = new System.Windows.Forms.TextBox();
            this.la_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_queryproject = new System.Windows.Forms.Button();
            this.bt_addproject = new System.Windows.Forms.Button();
            this.bt_dgvchangeexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projectinformation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_projectinformation
            // 
            this.dgv_projectinformation.AllowUserToAddRows = false;
            this.dgv_projectinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_projectinformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.项目名称,
            this.项目令号,
            this.备注,
            this.del,
            this.update_,
            this.项目Id});
            this.dgv_projectinformation.Location = new System.Drawing.Point(27, 98);
            this.dgv_projectinformation.MultiSelect = false;
            this.dgv_projectinformation.Name = "dgv_projectinformation";
            this.dgv_projectinformation.RowTemplate.Height = 23;
            this.dgv_projectinformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_projectinformation.Size = new System.Drawing.Size(913, 644);
            this.dgv_projectinformation.TabIndex = 4;
            this.dgv_projectinformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_projectinformation_CellContentClick);
            // 
            // 项目名称
            // 
            this.项目名称.DataPropertyName = "01";
            this.项目名称.HeaderText = "项目名称";
            this.项目名称.Name = "项目名称";
            this.项目名称.ReadOnly = true;
            this.项目名称.ToolTipText = "01";
            this.项目名称.Width = 150;
            // 
            // 项目令号
            // 
            this.项目令号.HeaderText = "项目令号";
            this.项目令号.Name = "项目令号";
            this.项目令号.ReadOnly = true;
            this.项目令号.Width = 150;
            // 
            // 备注
            // 
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 400;
            // 
            // del
            // 
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.del.HeaderText = "删除";
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.del.Text = "删除";
            this.del.UseColumnTextForButtonValue = true;
            this.del.Width = 85;
            // 
            // update_
            // 
            this.update_.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.update_.HeaderText = "修改";
            this.update_.Name = "update_";
            this.update_.ReadOnly = true;
            this.update_.Text = "修改";
            this.update_.UseColumnTextForButtonValue = true;
            this.update_.Width = 85;
            // 
            // 项目Id
            // 
            this.项目Id.HeaderText = "项目Id";
            this.项目Id.Name = "项目Id";
            this.项目Id.ReadOnly = true;
            this.项目Id.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.la_project);
            this.groupBox1.Controls.Add(this.tb_project);
            this.groupBox1.Controls.Add(this.la_name);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.bt_queryproject);
            this.groupBox1.Location = new System.Drawing.Point(27, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目搜索";
            // 
            // la_project
            // 
            this.la_project.AutoSize = true;
            this.la_project.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_project.Location = new System.Drawing.Point(304, 20);
            this.la_project.Name = "la_project";
            this.la_project.Size = new System.Drawing.Size(79, 20);
            this.la_project.TabIndex = 73;
            this.la_project.Text = "项目命号：";
            // 
            // tb_project
            // 
            this.tb_project.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_project.Location = new System.Drawing.Point(389, 17);
            this.tb_project.Name = "tb_project";
            this.tb_project.Size = new System.Drawing.Size(126, 26);
            this.tb_project.TabIndex = 74;
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(44, 20);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(79, 20);
            this.la_name.TabIndex = 71;
            this.la_name.Text = "项目名称：";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(123, 17);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(126, 26);
            this.tb_name.TabIndex = 72;
            // 
            // bt_queryproject
            // 
            this.bt_queryproject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_queryproject.Location = new System.Drawing.Point(601, 16);
            this.bt_queryproject.Name = "bt_queryproject";
            this.bt_queryproject.Size = new System.Drawing.Size(79, 30);
            this.bt_queryproject.TabIndex = 3;
            this.bt_queryproject.Text = "搜索";
            this.bt_queryproject.UseVisualStyleBackColor = true;
            this.bt_queryproject.Click += new System.EventHandler(this.bt_queryproject_Click);
            // 
            // bt_addproject
            // 
            this.bt_addproject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_addproject.Location = new System.Drawing.Point(807, 39);
            this.bt_addproject.Name = "bt_addproject";
            this.bt_addproject.Size = new System.Drawing.Size(133, 30);
            this.bt_addproject.TabIndex = 7;
            this.bt_addproject.Text = "添加项目";
            this.bt_addproject.UseVisualStyleBackColor = true;
            this.bt_addproject.Click += new System.EventHandler(this.bt_addproject_Click);
            // 
            // bt_dgvchangeexcel
            // 
            this.bt_dgvchangeexcel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_dgvchangeexcel.Location = new System.Drawing.Point(860, 748);
            this.bt_dgvchangeexcel.Name = "bt_dgvchangeexcel";
            this.bt_dgvchangeexcel.Size = new System.Drawing.Size(80, 25);
            this.bt_dgvchangeexcel.TabIndex = 8;
            this.bt_dgvchangeexcel.Text = "导出Excel";
            this.bt_dgvchangeexcel.UseVisualStyleBackColor = true;
            this.bt_dgvchangeexcel.Click += new System.EventHandler(this.bt_dgvchangeexcel_Click);
            // 
            // ProjectManageme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 800);
            this.Controls.Add(this.bt_dgvchangeexcel);
            this.Controls.Add(this.bt_addproject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_projectinformation);
            this.Name = "ProjectManageme";
            this.Text = "ProjectManageme";
            this.Load += new System.EventHandler(this.ProjectManageme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projectinformation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_projectinformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目令号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.DataGridViewButtonColumn update_;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目Id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label la_project;
        private System.Windows.Forms.TextBox tb_project;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_queryproject;
        private System.Windows.Forms.Button bt_addproject;
        private System.Windows.Forms.Button bt_dgvchangeexcel;
    }
}