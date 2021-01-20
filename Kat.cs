using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    internal class Kat : Dier
    {
        public int counter;

        public Kat(string naam)
            : base(naam)
        {
        }

        public override string Praten(string zin)
        {
            counter++;
            if (counter % 3 == 0)
            {
                return "Miauwkes";
            }
            return base.Praten(zin);
        }

        public override string Strelen()
        {
            return "RrRr";
        }
    }
}