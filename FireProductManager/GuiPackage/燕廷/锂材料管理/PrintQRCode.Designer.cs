namespace FireProductManager.GuiPackage
{
    partial class PrintQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintQRCode));
            this.pb_qrcode = new System.Windows.Forms.PictureBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.la_nametext = new System.Windows.Forms.Label();
            this.la_modeltext = new System.Windows.Forms.Label();
            this.la_purchaseTimetext = new System.Windows.Forms.Label();
            this.la_purchaseTime = new System.Windows.Forms.Label();
            this.la_model = new System.Windows.Forms.Label();
            this.la_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_qrcode
            // 
            this.pb_qrcode.Location = new System.Drawing.Point(122, 12);
            this.pb_qrcode.Name = "pb_qrcode";
            this.pb_qrcode.Size = new System.Drawing.Size(231, 245);
            this.pb_qrcode.TabIndex = 1;
            this.pb_qrcode.TabStop = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // la_nametext
            // 
            this.la_nametext.AutoSize = true;
            this.la_nametext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_nametext.Location = new System.Drawing.Point(101, 294);
            this.la_nametext.Name = "la_nametext";
            this.la_nametext.Size = new System.Drawing.Size(90, 21);
            this.la_nametext.TabIndex = 2;
            this.la_nametext.Text = "材料名称：";
            // 
            // la_modeltext
            // 
            this.la_modeltext.AutoSize = true;
            this.la_modeltext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_modeltext.Location = new System.Drawing.Point(101, 334);
            this.la_modeltext.Name = "la_modeltext";
            this.la_modeltext.Size = new System.Drawing.Size(90, 21);
            this.la_modeltext.TabIndex = 3;
            this.la_modeltext.Text = "型号规格：";
            // 
            // la_purchaseTimetext
            // 
            this.la_purchaseTimetext.AutoSize = true;
            this.la_purchaseTimetext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_purchaseTimetext.Location = new System.Drawing.Point(101, 378);
            this.la_purchaseTimetext.Name = "la_purchaseTimetext";
            this.la_purchaseTimetext.Size = new System.Drawing.Size(90, 21);
            this.la_purchaseTimetext.TabIndex = 4;
            this.la_purchaseTimetext.Text = "入库时间：";
            // 
            // la_purchaseTime
            // 
            this.la_purchaseTime.AutoSize = true;
            this.la_purchaseTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_purchaseTime.Location = new System.Drawing.Point(203, 378);
            this.la_purchaseTime.Name = "la_purchaseTime";
            this.la_purchaseTime.Size = new System.Drawing.Size(55, 21);
            this.la_purchaseTime.TabIndex = 7;
            this.la_purchaseTime.Text = "label4";
            // 
            // la_model
            // 
            this.la_model.AutoSize = true;
            this.la_model.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_model.Location = new System.Drawing.Point(203, 334);
            this.la_model.Name = "la_model";
            this.la_model.Size = new System.Drawing.Size(55, 21);
            this.la_model.TabIndex = 6;
            this.la_model.Text = "label5";
            // 
            // la_name
            // 
            this.la_name.AutoSize = true;
            this.la_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_name.Location = new System.Drawing.Point(203, 294);
            this.la_name.Name = "la_name";
            this.la_name.Size = new System.Drawing.Size(55, 21);
            this.la_name.TabIndex = 5;
            this.la_name.Text = "label6";
            // 
            // PrintQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 488);
            this.Controls.Add(this.la_purchaseTime);
            this.Controls.Add(this.la_model);
            this.Controls.Add(this.la_name);
            this.Controls.Add(this.la_purchaseTimetext);
            this.Controls.Add(this.la_modeltext);
            this.Controls.Add(this.la_nametext);
            this.Controls.Add(this.pb_qrcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintQRCode";
            this.Text = "打印二维码";
            this.Load += new System.EventHandler(this.PrintQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_qrcode;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label la_nametext;
        private System.Windows.Forms.Label la_modeltext;
        private System.Windows.Forms.Label la_purchaseTimetext;
        private System.Windows.Forms.Label la_purchaseTime;
        private System.Windows.Forms.Label la_model;
        private System.Windows.Forms.Label la_name;
    }
}