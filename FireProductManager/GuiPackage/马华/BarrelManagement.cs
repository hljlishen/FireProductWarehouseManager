using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    public partial class BarrelManagement : Form
    {
        public BarrelManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_showaddbarrelid.Text = BarrelGateway.RecordNewBarrel().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BarrelGateway.RemoveBarrel(barrelid);
        }
    }
}
