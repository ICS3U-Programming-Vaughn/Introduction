using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAppVaughnD
{
    public partial class frmGameApp : Form
    {
        public frmGameApp()
        {
            InitializeComponent();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
