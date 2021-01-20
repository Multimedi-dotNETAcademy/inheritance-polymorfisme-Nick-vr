using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    internal class Papegaai : Dier
    {
        public Papegaai(string naam)
            : base(naam)
        {
        }

        public override string Praten(string zin)
        {
            Random rnd = new Random();

            int rand = rnd.Next(1, 5);

            if (rand == 1)
            {
                return "Koko kopke krabben";
            }
            else
            {
                return zin;
            }
        }

        public override string Strelen()
        {
            return "Koko";
        }
    }
}