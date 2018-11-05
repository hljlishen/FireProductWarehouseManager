namespace cangku_01.view.AdminPage
{
    partial class AutoCloseMassageBox
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
            this.la_massageshow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // la_massageshow
            // 
            this.la_massageshow.AutoSize = true;
            this.la_massageshow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_massageshow.Location = new System.Drawing.Point(42, 35);
            this.la_massageshow.Name = "la_massageshow";
            this.la_massageshow.Size = new System.Drawing.Size(0, 21);
            this.la_massageshow.TabIndex = 0;
            // 
            // AutoCloseMassageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(342, 89);
            this.Controls.Add(this.la_massageshow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoCloseMassageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCloseMassageBox";
            this.Load += new System.EventHandler(this.AutoCloseMassageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_massageshow;
    }
}