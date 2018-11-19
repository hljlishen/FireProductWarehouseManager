namespace FireProductManager.GuiPackage
{
    partial class CreateDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDepartment));
            this.bt_alter = new System.Windows.Forms.Button();
            this.tb_nodename = new System.Windows.Forms.TextBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_sure = new System.Windows.Forms.Button();
            this.la_nodenametext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_alter
            // 
            this.bt_alter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_alter.Location = new System.Drawing.Point(133, 94);
            this.bt_alter.Name = "bt_alter";
            this.bt_alter.Size = new System.Drawing.Size(75, 30);
            this.bt_alter.TabIndex = 10;
            this.bt_alter.Text = "修改";
            this.bt_alter.UseVisualStyleBackColor = true;
            this.bt_alter.Click += new System.EventHandler(this.bt_alter_Click);
            // 
            // tb_nodename
            // 
            this.tb_nodename.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_nodename.Location = new System.Drawing.Point(214, 39);
            this.tb_nodename.Name = "tb_nodename";
            this.tb_nodename.Size = new System.Drawing.Size(170, 26);
            this.tb_nodename.TabIndex = 9;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_cancel.Location = new System.Drawing.Point(268, 94);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 30);
            this.bt_cancel.TabIndex = 8;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_sure
            // 
            this.bt_sure.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_sure.Location = new System.Drawing.Point(133, 94);
            this.bt_sure.Name = "bt_sure";
            this.bt_sure.Size = new System.Drawing.Size(75, 30);
            this.bt_sure.TabIndex = 7;
            this.bt_sure.Text = "确认";
            this.bt_sure.UseVisualStyleBackColor = true;
            this.bt_sure.Click += new System.EventHandler(this.bt_sure_Click);
            // 
            // la_nodenametext
            // 
            this.la_nodenametext.AutoSize = true;
            this.la_nodenametext.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_nodenametext.Location = new System.Drawing.Point(101, 42);
            this.la_nodenametext.Name = "la_nodenametext";
            this.la_nodenametext.Size = new System.Drawing.Size(107, 20);
            this.la_nodenametext.TabIndex = 6;
            this.la_nodenametext.Text = "输入节点名称：";
            // 
            // CreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(484, 162);
            this.Controls.Add(this.bt_alter);
            this.Controls.Add(this.tb_nodename);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_sure);
            this.Controls.Add(this.la_nodenametext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门编辑";
            this.Load += new System.EventHandler(this.GetDepartmentNodeName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_alter;
        private System.Windows.Forms.TextBox tb_nodename;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_sure;
        private System.Windows.Forms.Label la_nodenametext;
    }
}