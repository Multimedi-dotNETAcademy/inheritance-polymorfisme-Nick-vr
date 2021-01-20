using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    public class Zichtrekening : Rekening
    {
        public Zichtrekening(string rekeningnr, double saldo = 0)
            : base(rekeningnr, saldo)
        {
            Minimum = -100;
        }
    }
}