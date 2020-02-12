using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolVaughn
{
    public partial class PerAreaVolfrm : Form
    {
        public PerAreaVolfrm()
        {
            InitializeComponent();
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            // calculate the area of a circle
            this.lblArea.Text = Convert.ToString(3.14*Math.Pow(8,2))+"km";
        }

        private void BtnPerimeter_Click(object sender, EventArgs e)
        {
            // calculate the perimeter of the rectangle
            this.lblPerimeter.Text = Convert.ToString(7 * 2 + 5 * 2)+"cm";
        }

        private void BtnVolume_Click(object sender, EventArgs e)
        {
            // calculate the volume of a sphere
            this.lblVolume.Text = Convert.ToString((double)4/(double)3 * Math.PI * Math.Pow(10, 3)) + "m";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
