using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceEx
{
    public class Spaarrekening : Rekening
    {
        private double _percentage { get; set; }
        public double Percentage { get; set; }

        public Spaarrekening(string rekeningnr, double percentage = 5, double saldo = 0)
            : base(rekeningnr, saldo)
        {
            Percentage = percentage;
        }

        //Methods
        public double SchrijfRenteBij()
        {
            double rente = Saldo * 0.05;
            return rente;
        }

        public override string ToString()
        {
            return $"Rekeningnummer  {Rekeningnr} met saldo {Saldo} (percentage {Percentage})";
        }
    }
}