using FireProductManager.EntityPackage;
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

namespace FireProductManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //float[] f = DepartmentGateway.SubArray(new float[] { 1, 2, 3, 4 }, 0, 2);
            //Test[] i = DepartmentGateway.SubArray(new Test[] {new Test(), new Test() }, 0, 2);
        }
    }

    class Test
    {
        public int A { get; set; } = 0;
    }
}
