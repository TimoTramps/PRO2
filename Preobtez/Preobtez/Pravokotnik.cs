using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preobtez
{
    internal class Pravokotnik
    {
        public double Širina { get; set; }
        public double Dolžina { get; set; }

        public Pravokotnik()
        {
            Širina = 0;
            Dolžina = 0;
        }

        public Pravokotnik(double sirina, double dolzina)
        {
            sirina = Širina;
            dolzina = Dolžina;
        }

        public double Ploščina()
        {
            return Širina * Dolžina;
        }
        public string ToString()
        {
            return "širina: " + Širina + ", dolžina: " + Dolžina;
        }
    }
}
