using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceEx
{
    public partial class DierForm : Form
    {
        private Dier huidigDier;

        public DierForm()
        {
            InitializeComponent();
        }

        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            string dierNaam = textBoxDierNaam.Text;

            if (radioKat.Checked == true)
            {
                huidigDier = new Kat(dierNaam);
            }
            else if (radioPapegaai.Checked == true)
            {
                huidigDier = new Papegaai(dierNaam);
            }
            else
            {
                huidigDier = new Mens(dierNaam);
            }
        }

        private void textBoxDierNaam_TextChanged(object sender, EventArgs e)
        {
            btnAanmaken.Enabled = true;
        }

        private void listBoxZin_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPraten.Enabled = true;
        }

        private void btnPraten_Click(object sender, EventArgs e)
        {
            MessageBox.Show(huidigDier.Praten(listBoxVragen.SelectedItem.ToString()));
        }

        private void btnStrelen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(huidigDier.Strelen());
        }

        private void btnEten_Click(object sender, EventArgs e)
        {
            MessageBox.Show(huidigDier.Eten());
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}