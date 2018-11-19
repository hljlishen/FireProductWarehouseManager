using System;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    public partial class Confirm : Form
    {
        public Confirm(string message)
        {
            InitializeComponent();
            la_text.Text = message;
        }

        private void Confirm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_yes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_no_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
