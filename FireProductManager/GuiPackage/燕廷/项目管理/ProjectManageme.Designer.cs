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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManageme));
            this.dgv_projectinformation = new System.Windows.Forms.DataGridView();
            this.项目Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目令号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.la_project = new System.Windows.Forms.Label();
            this.tb_projectpassword = new System.Windows.Forms.TextBox();
            this.la_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_queryproject = new System.Windows.Forms.Button();
            this.bt_dgvchangeexcel = new System.Windows.Forms.Button();
            this.cms_projectoperation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_newproject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_updateproject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_deleteproject = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_newproject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_new = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projectinformation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.cms_projectoperation.SuspendLayout();
            this.cms_newproject.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_projectinformation
            // 
            this.dgv_projectinformation.AllowUserToAddRows = false;
            this.dgv_projectinformation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_projectinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_projectinformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.项目Id,
            this.项目名称,
            this.项目令号,
            this.备注});
            this.dgv_projectinformation.Location = new System.Drawing.Point(239, 98);
            this.dgv_projectinformation.MultiSelect = false;
            this.dgv_projectinformation.Name = "dgv_projectinformation";
            this.dgv_projectinformation.ReadOnly = true;
            this.dgv_projectinformation.RowTemplate.Height = 23;
            this.dgv_projectinformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_projectinformation.Size = new System.Drawing.Size(944, 644);
            this.dgv_projectinformation.TabIndex = 4;
            this.dgv_projectinformation.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_projectinformation_CellMouseDoubleClick);
            this.dgv_projectinformation.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_projectinformation_CellMouseDown);
            this.dgv_projectinformation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_projectinformation_MouseClick);
            // 
            // 项目Id
            // 
            this.项目Id.HeaderText = "项目Id";
            this.项目Id.Name = "项目Id";
            this.项目Id.ReadOnly = true;
            this.项目Id.Visible = false;
            // 
            // 项目名称
            // 
            this.项目名称.DataPropertyName = "01";
            this.项目名称.HeaderText = "项目名称";
            this.项目名称.Name = "项目名称";
            this.项目名称.ReadOnly = true;
            this.项目名称.ToolTipText = "01";
            this.项目名称.Width = 200;
            // 
            // 项目令号
            // 
            this.项目令号.HeaderText = "项目令号";
            this.项目令号.Name = "项目令号";
            this.项目令号.ReadOnly = true;
            this.项目令号.Width = 200;
            // 
            // 备注
            // 
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 500;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.la_project);
            this.groupBox1.Controls.Add(this.tb_projectpassword);
            this.groupBox1.Controls.Add(this.la_name);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.bt_queryproject);
            this.groupBox1.Location = new System.Drawing.Point(239, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目搜索";
            // 
            // la_project
            // 
            this.la_project.AutoSize = true;
            this.la_project.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_project.Location = new System.Drawing.Point(404, 20);
            this.la_project.Name = "la_project";
            this.la_project.Size = new System.Drawing.Size(79, 20);
            this.la_project.TabIndex = 73;
            this.la_project.Text = "项目命号：";
            // 
            // tb_projectpassword
            // 
            this.tb_projectpassword.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_projectpassword.Location = new System.Drawing.Point(489, 17);
            this.tb_projectpassword.Name = "tb_projectpassword";
            this.tb_projectpassword.Size = new System.Drawing.Size(150, 26);
            this.tb_projectpassword.TabIndex = 74;
            this.tb_projectpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_projectpassword_KeyDown);
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(52, 20);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(79, 20);
            this.la_name.TabIndex = 71;
            this.la_name.Text = "项目名称：";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(131, 17);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(150, 26);
            this.tb_name.TabIndex = 72;
            this.tb_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_name_KeyDown);
            // 
            // bt_queryproject
            // 
            this.bt_queryproject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_queryproject.Location = new System.Drawing.Point(837, 16);
            this.bt_queryproject.Name = "bt_queryproject";
            this.bt_queryproject.Size = new System.Drawing.Size(79, 30);
            this.bt_queryproject.TabIndex = 3;
            this.bt_queryproject.Text = "搜索";
            this.bt_queryproject.UseVisualStyleBackColor = true;
            this.bt_queryproject.Click += new System.EventHandler(this.bt_queryproject_Click);
            // 
            // bt_dgvchangeexcel
            // 
            this.bt_dgvchangeexcel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_dgvchangeexcel.Location = new System.Drawing.Point(1103, 757);
            this.bt_dgvchangeexcel.Name = "bt_dgvchangeexcel";
            this.bt_dgvchangeexcel.Size = new System.Drawing.Size(80, 25);
            this.bt_dgvchangeexcel.TabIndex = 8;
            this.bt_dgvchangeexcel.Text = "导出Excel";
            this.bt_dgvchangeexcel.UseVisualStyleBackColor = true;
            this.bt_dgvchangeexcel.Visible = false;
            this.bt_dgvchangeexcel.Click += new System.EventHandler(this.bt_dgvchangeexcel_Click);
            // 
            // cms_projectoperation
            // 
            this.cms_projectoperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_newproject,
            this.tsm_updateproject,
            this.tsm_deleteproject});
            this.cms_projectoperation.Name = "cms_projectoperation";
            this.cms_projectoperation.Size = new System.Drawing.Size(101, 70);
            // 
            // tsm_newproject
            // 
            this.tsm_newproject.Name = "tsm_newproject";
            this.tsm_newproject.Size = new System.Drawing.Size(100, 22);
            this.tsm_newproject.Text = "添加";
            this.tsm_newproject.Click += new System.EventHandler(this.tsm_newproject_Click);
            // 
            // tsm_updateproject
            // 
            this.tsm_updateproject.Name = "tsm_updateproject";
            this.tsm_updateproject.Size = new System.Drawing.Size(100, 22);
            this.tsm_updateproject.Text = "修改";
            this.tsm_updateproject.Click += new System.EventHandler(this.tsm_updateproject_Click);
            // 
            // tsm_deleteproject
            // 
            this.tsm_deleteproject.Name = "tsm_deleteproject";
            this.tsm_deleteproject.Size = new System.Drawing.Size(100, 22);
            this.tsm_deleteproject.Text = "删除";
            this.tsm_deleteproject.Click += new System.EventHandler(this.tsm_deleteproject_Click);
            // 
            // cms_newproject
            // 
            this.cms_newproject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_new});
            this.cms_newproject.Name = "cms_newproject";
            this.cms_newproject.Size = new System.Drawing.Size(101, 26);
            // 
            // tsm_new
            // 
            this.tsm_new.Name = "tsm_new";
            this.tsm_new.Size = new System.Drawing.Size(100, 22);
            this.tsm_new.Text = "添加";
            this.tsm_new.Click += new System.EventHandler(this.tsm_newproject_Click);
            // 
            // ProjectManageme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 832);
            this.Controls.Add(this.bt_dgvchangeexcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_projectinformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectManageme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "项目管理";
            this.Load += new System.EventHandler(this.ProjectManageme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projectinformation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cms_projectoperation.ResumeLayout(false);
            this.cms_newproject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_projectinformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label la_project;
        private System.Windows.Forms.TextBox tb_projectpassword;
        private System.Windows.Forms.Label la_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_queryproject;
        private System.Windows.Forms.Button bt_dgvchangeexcel;
        private System.Windows.Forms.ContextMenuStrip cms_projectoperation;
        private System.Windows.Forms.ContextMenuStrip cms_newproject;
        private System.Windows.Forms.ToolStripMenuItem tsm_new;
        private System.Windows.Forms.ToolStripMenuItem tsm_newproject;
        private System.Windows.Forms.ToolStripMenuItem tsm_updateproject;
        private System.Windows.Forms.ToolStripMenuItem tsm_deleteproject;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目令号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}