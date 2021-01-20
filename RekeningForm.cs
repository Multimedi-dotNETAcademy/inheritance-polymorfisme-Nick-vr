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
    public partial class RekeningForm : Form
    {
        private Rekening rekening = new Rekening("78782327-7378");
        private Spaarrekening spaarRekening = new Spaarrekening("453453-45345");
        private Zichtrekening zichtRekening = new Zichtrekening("888-453345");

        public RekeningForm()
        {
            InitializeComponent();
        }

        //rekening
        private void btnRekeningPlus_Click(object sender, EventArgs e)
        {
            double userInput = Convert.ToDouble(boxRekening.Text);
            rekening.Storten(userInput);
            txtRekening.Text = rekening.ToString();
        }

        private void btnRekeningMinus_Click(object sender, EventArgs e)
        {
            double userInput = Convert.ToDouble(boxRekening.Text);
            rekening.Afhalen(userInput);

            if (rekening.Saldo > 0)
            {
                txtRekening.Text = rekening.ToString();
            }
        }

        //spaarRekening
        private void btnSpaarrekeningPlus_Click(object sender, EventArgs e)
        {
            double userInput = Convert.ToDouble(boxSpaarrekening.Text);
            spaarRekening.Storten(userInput);
            txtSpaarrekening.Text = spaarRekening.ToString();
        }

        private void btnSpaarrekeningMinus_Click(object sender, EventArgs e)
        {
            double userInput = Convert.ToDouble(boxSpaarrekening.Text);
            spaarRekening.Afhalen(userInput);

            txtSpaarrekening.Text = spaarRekening.ToString();
        }

        private void btnRente_Click(object sender, EventArgs e)
        {
            double rente = spaarRekening.SchrijfRenteBij();
            spaarRekening.Saldo += rente;
            txtSpaarrekening.Text = spaarRekening.ToString();
        }

        //zichtRekening
        private void btnZichtrekeningPlus_Click(object sender, EventArgs e)
        {
            double userInput = Convert.ToDouble(boxZichtrekening.Text);
            zichtRekening.Storten(userInput);
            txtZichtrekening.Text = zichtRekening.ToString();
        }

        private void btnZichtrekeningMinus_Click(object sender, EventArgs e)
        {
            double userInput = Convert.ToDouble(boxZichtrekening.Text);
            zichtRekening.Afhalen(userInput);
            txtZichtrekening.Text = zichtRekening.ToString();
        }
    }
}