using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraSKartami
{
    enum Vrednosti
    {
        As=1, Dva, Tri, Štiri, Pet, Šest, Sedem, Osem, Devet, Deset,
        Janez, Kraljica, Kralj
    }

    enum Barve
    {
        Križ, Pik, Karo, Srce
    }
    internal class Karta
    {

        public Barve Barva { get; set; }

        public Vrednosti Vrednost { get; set; }

        public string Ime { get; set; }

        public Karta(Barve b, Vrednosti v)
        {
            Barva = b;
            Vrednost = v;
            Ime = Vrednost + " " + Barva;
        }
    }
}
