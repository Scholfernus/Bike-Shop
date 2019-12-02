using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelLeft.Height = btnSzosowe.Height;
            rowwerySzosowe1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnSzosowe.Height;
            panelLeft.Top = btnSzosowe.Top;
            rowwerySzosowe1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnSzosowe.Height;
            panelLeft.Top = button2.Top;
            rowery_Szosowe_budżetowe1.BringToFront();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przenosisz się na stronę Facebook\nczy jesteś pewny?");
         
        }
    }
}
