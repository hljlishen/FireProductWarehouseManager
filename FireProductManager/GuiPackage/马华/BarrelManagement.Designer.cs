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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.la_barrelLoadingCapacity = new System.Windows.Forms.Label();
            this.tb_barrelLoadingCapacity = new System.Windows.Forms.TextBox();
            this.btn_barrelLoadingCapacity = new System.Windows.Forms.Button();
            this.tb_delectbarrelLoadingCapacity1 = new System.Windows.Forms.TextBox();
            this.tb_delectbarrelLoadingCapacity2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delectbarrelLoadingCapacity1 = new System.Windows.Forms.Button();
            this.btn_delectbarrelLoadingCapacity2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.la_number1 = new System.Windows.Forms.Label();
            this.la_number2 = new System.Windows.Forms.Label();
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
            this.tb_showaddbarrelid.ReadOnly = true;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_packageshow1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_packageshow1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_packageshow1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.包id1,
            this.类型1,
            this.规格1,
            this.重量1});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_packageshow1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_packageshow1.Location = new System.Drawing.Point(253, 158);
            this.dgv_packageshow1.Name = "dgv_packageshow1";
            this.dgv_packageshow1.RowTemplate.Height = 23;
            this.dgv_packageshow1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            this.类型1.HeaderText = "材料类型";
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_packageshow2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_packageshow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_packageshow2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.包id2,
            this.类型2,
            this.规格2,
            this.重量2});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_packageshow2.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_packageshow2.Location = new System.Drawing.Point(762, 158);
            this.dgv_packageshow2.Name = "dgv_packageshow2";
            this.dgv_packageshow2.RowTemplate.Height = 23;
            this.dgv_packageshow2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            this.类型2.HeaderText = "材料类型";
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
            this.lab_showbarrelid1.Location = new System.Drawing.Point(396, 130);
            this.lab_showbarrelid1.Name = "lab_showbarrelid1";
            this.lab_showbarrelid1.Size = new System.Drawing.Size(0, 21);
            this.lab_showbarrelid1.TabIndex = 32;
            // 
            // lab_showbarrelid2
            // 
            this.lab_showbarrelid2.AutoSize = true;
            this.lab_showbarrelid2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_showbarrelid2.Location = new System.Drawing.Point(904, 131);
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
            // la_barrelLoadingCapacity
            // 
            this.la_barrelLoadingCapacity.AutoSize = true;
            this.la_barrelLoadingCapacity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_barrelLoadingCapacity.Location = new System.Drawing.Point(269, 46);
            this.la_barrelLoadingCapacity.Name = "la_barrelLoadingCapacity";
            this.la_barrelLoadingCapacity.Size = new System.Drawing.Size(68, 17);
            this.la_barrelLoadingCapacity.TabIndex = 37;
            this.la_barrelLoadingCapacity.Text = "存储数量：";
            // 
            // tb_barrelLoadingCapacity
            // 
            this.tb_barrelLoadingCapacity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_barrelLoadingCapacity.Location = new System.Drawing.Point(340, 43);
            this.tb_barrelLoadingCapacity.Name = "tb_barrelLoadingCapacity";
            this.tb_barrelLoadingCapacity.Size = new System.Drawing.Size(100, 23);
            this.tb_barrelLoadingCapacity.TabIndex = 38;
            this.tb_barrelLoadingCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_barrelLoadingCapacity_KeyPress);
            // 
            // btn_barrelLoadingCapacity
            // 
            this.btn_barrelLoadingCapacity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_barrelLoadingCapacity.Location = new System.Drawing.Point(459, 43);
            this.btn_barrelLoadingCapacity.Name = "btn_barrelLoadingCapacity";
            this.btn_barrelLoadingCapacity.Size = new System.Drawing.Size(91, 23);
            this.btn_barrelLoadingCapacity.TabIndex = 39;
            this.btn_barrelLoadingCapacity.Text = "设置存储数量";
            this.btn_barrelLoadingCapacity.UseVisualStyleBackColor = true;
            this.btn_barrelLoadingCapacity.Click += new System.EventHandler(this.btn_barrelLoadingCapacity_Click);
            // 
            // tb_delectbarrelLoadingCapacity1
            // 
            this.tb_delectbarrelLoadingCapacity1.Location = new System.Drawing.Point(320, 731);
            this.tb_delectbarrelLoadingCapacity1.Name = "tb_delectbarrelLoadingCapacity1";
            this.tb_delectbarrelLoadingCapacity1.Size = new System.Drawing.Size(75, 21);
            this.tb_delectbarrelLoadingCapacity1.TabIndex = 41;
            this.tb_delectbarrelLoadingCapacity1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_delectbarrelLoadingCapacity1_KeyPress);
            // 
            // tb_delectbarrelLoadingCapacity2
            // 
            this.tb_delectbarrelLoadingCapacity2.Location = new System.Drawing.Point(835, 731);
            this.tb_delectbarrelLoadingCapacity2.Name = "tb_delectbarrelLoadingCapacity2";
            this.tb_delectbarrelLoadingCapacity2.Size = new System.Drawing.Size(75, 21);
            this.tb_delectbarrelLoadingCapacity2.TabIndex = 42;
            this.tb_delectbarrelLoadingCapacity2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_delectbarrelLoadingCapacity2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(249, 734);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "存储数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(763, 733);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "存储数量：";
            // 
            // btn_delectbarrelLoadingCapacity1
            // 
            this.btn_delectbarrelLoadingCapacity1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delectbarrelLoadingCapacity1.Location = new System.Drawing.Point(402, 730);
            this.btn_delectbarrelLoadingCapacity1.Name = "btn_delectbarrelLoadingCapacity1";
            this.btn_delectbarrelLoadingCapacity1.Size = new System.Drawing.Size(75, 23);
            this.btn_delectbarrelLoadingCapacity1.TabIndex = 45;
            this.btn_delectbarrelLoadingCapacity1.Text = "修改";
            this.btn_delectbarrelLoadingCapacity1.UseVisualStyleBackColor = true;
            this.btn_delectbarrelLoadingCapacity1.Click += new System.EventHandler(this.btn_delectbarrelLoadingCapacity1_Click);
            // 
            // btn_delectbarrelLoadingCapacity2
            // 
            this.btn_delectbarrelLoadingCapacity2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delectbarrelLoadingCapacity2.Location = new System.Drawing.Point(917, 729);
            this.btn_delectbarrelLoadingCapacity2.Name = "btn_delectbarrelLoadingCapacity2";
            this.btn_delectbarrelLoadingCapacity2.Size = new System.Drawing.Size(75, 23);
            this.btn_delectbarrelLoadingCapacity2.TabIndex = 46;
            this.btn_delectbarrelLoadingCapacity2.Text = "修改";
            this.btn_delectbarrelLoadingCapacity2.UseVisualStyleBackColor = true;
            this.btn_delectbarrelLoadingCapacity2.Click += new System.EventHandler(this.btn_delectbarrelLoadingCapacity2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(501, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "当前桶内存储数量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1010, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "当前桶内存储数量：";
            // 
            // la_number1
            // 
            this.la_number1.AutoSize = true;
            this.la_number1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_number1.Location = new System.Drawing.Point(623, 132);
            this.la_number1.Name = "la_number1";
            this.la_number1.Size = new System.Drawing.Size(0, 17);
            this.la_number1.TabIndex = 49;
            // 
            // la_number2
            // 
            this.la_number2.AutoSize = true;
            this.la_number2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_number2.Location = new System.Drawing.Point(1132, 132);
            this.la_number2.Name = "la_number2";
            this.la_number2.Size = new System.Drawing.Size(0, 17);
            this.la_number2.TabIndex = 50;
            // 
            // BarrelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 832);
            this.Controls.Add(this.la_number2);
            this.Controls.Add(this.la_number1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_delectbarrelLoadingCapacity2);
            this.Controls.Add(this.btn_delectbarrelLoadingCapacity1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_delectbarrelLoadingCapacity2);
            this.Controls.Add(this.tb_delectbarrelLoadingCapacity1);
            this.Controls.Add(this.btn_barrelLoadingCapacity);
            this.Controls.Add(this.tb_barrelLoadingCapacity);
            this.Controls.Add(this.la_barrelLoadingCapacity);
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
        private System.Windows.Forms.Label la_barrelLoadingCapacity;
        private System.Windows.Forms.TextBox tb_barrelLoadingCapacity;
        private System.Windows.Forms.Button btn_barrelLoadingCapacity;
        private System.Windows.Forms.TextBox tb_delectbarrelLoadingCapacity1;
        private System.Windows.Forms.TextBox tb_delectbarrelLoadingCapacity2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delectbarrelLoadingCapacity1;
        private System.Windows.Forms.Button btn_delectbarrelLoadingCapacity2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label la_number1;
        private System.Windows.Forms.Label la_number2;
    }
}