using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    internal abstract class Dier
    {
        private string _naam;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        protected Dier(string naam)
        {
            Naam = naam;
        }

        public virtual string Eten()
        {
            return "";
        }

        public virtual string Praten(string zin)
        {
            return "";
        }

        public virtual string Strelen()
        {
            return "";
        }
    }
}