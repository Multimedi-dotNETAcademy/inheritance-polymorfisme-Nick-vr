using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    internal class Mens : Dier
    {
        public Mens(string naam)
            : base(naam)
        {
        }

        public override string Eten()
        {
            return "Lekker";
        }

        public override string Praten(string zin)
        {
            string antwoord = "";
            switch (zin)
            {
                case "Hallo":
                    antwoord = "Hallo";
                    break;

                case "Goedendag":
                    antwoord = "Goedendag";
                    break;

                case "Goedemorgen":
                    antwoord = "Goedemorgen";
                    break;

                case "Hoe gaar het?":
                    antwoord = "Goed en met jou?";
                    break;

                case "Hoe laat is het?":
                    string uur = DateTime.Now.ToString("HH: mm");
                    antwoord = $"Het is {uur}";
                    break;

                case "Welke dag is het?":
                    string day = DateTime.Now.DayOfWeek.ToString();
                    antwoord = $"Het is {day}";
                    break;

                case "Welk dier ben jij?":
                    antwoord = "Ik ben een mens";
                    break;

                case "Wat is je naam?":
                    antwoord = $"Mijn naam is {this.Naam}";
                    break;
            }
            return antwoord;
        }

        public override string Strelen()
        {
            return "Blijf van mijn lijf. Arrh.";
        }
    }
}