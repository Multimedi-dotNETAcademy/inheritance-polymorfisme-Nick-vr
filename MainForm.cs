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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRekening_Click(object sender, EventArgs e)
        {
            Form rekeningForm = new RekeningForm();
            rekeningForm.Show();
        }

        private void btnDieren_Click(object sender, EventArgs e)
        {
            Form dierForm = new DierForm();
            dierForm.Show();
        }

        private void btnCilinder_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}