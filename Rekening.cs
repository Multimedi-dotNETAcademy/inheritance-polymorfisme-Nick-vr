using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceEx
{
    public class Rekening
    {
        private double _minimum;

        public double Minimum
        {
            get { return _minimum; }
            set
            {
                _minimum = value;
            }
        }

        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < Minimum)
                {
                    MessageBox.Show($"Saldo onder 0", "Saldo ontoereikend", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        private string _rekeningnr;

        public string Rekeningnr
        {
            get { return _rekeningnr; }
            set { _rekeningnr = value; }
        }

        //Constructor
        public Rekening(string rekeningnr, double saldo = 0)
        {
            Rekeningnr = rekeningnr;
            Saldo = saldo;
            Minimum = 0;
        }

        //Methods
        public double Storten(double saldo)
        {
            return Saldo += saldo;
        }

        public double Afhalen(double saldo)
        {
            return Saldo -= saldo;
        }

        public override string ToString()
        {
            return $"Rekeningnummer  {Rekeningnr} met saldo {Saldo}";
        }
    }
}