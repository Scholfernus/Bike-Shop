using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_Shop
{
    public partial class Rowery_Szosowe_budżetowe : UserControl
    {
        public Rowery_Szosowe_budżetowe()
        {
            InitializeComponent();
        }

        private void btnGiant_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giant - nowy model roweru\n z widelcami karbonowymi \nSzczegóły na\"Giant.com\"");
        }

        private void btnKross_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kross - jedyny na rynku model\nz przerzutkami w piaście\nSzczegóły na\"Kross.pl\"");
        }

        private void btnSpecialized_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spec - model 2020\nSzczegóły na\"Specialized.com\"");
        }
    }
        
}
