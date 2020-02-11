/*
 * Created by: Vaughn Donohue
 * Created on: 11-February-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - NHello World! International
 * This program displays 4 radio and when the user clicks on 
 * each radio button the greeting changes according to the language
 * of the radio button.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloIntVaughn
{
    public partial class frmHelloInt : Form
    {
        public frmHelloInt()
        {
            InitializeComponent();
        }

        private void FrmHelloInt_Load(object sender, EventArgs e)
        {
           
        }

        private void GrbRadioButtons_Enter(object sender, EventArgs e)
        {

        }

        private void RadFrench_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to French
            this.lblGreeting.Text = "Bonjour le monde!";
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            // change greeting to English
            this.lblGreeting.Text = "Hello World!";
        }

        private void RadGerman_CheckedChanged(object sender, EventArgs e)
        {
            // change greeting to Deutsche
            this.lblGreeting.Text = "Hallo Welt!";
        }

        private void RadJapanese_CheckedChanged(object sender, EventArgs e)
        {
            // change greeting to Japanese
            this.lblGreeting.Text = "Kon'nichiwa sekai";
        }

        private void LblGreeting_Click(object sender, EventArgs e)
        {

        }
    }
}
