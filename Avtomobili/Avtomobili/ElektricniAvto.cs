using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtomobili
{
    internal class ElektricniAvto:Avto
    {
        public double PorabaNa100KmKWh { get; set; }

        //public ElektricniAvto(string znamka, double poraba)
        //{
        //    Znamka = znamka;
        //    PorabaNa100Km = poraba;
        //}

        public ElektricniAvto(string znamka, double porabaNa100KmKWh)
        : base(znamka, 0)
        {
            PorabaNa100KmKWh = porabaNa100KmKWh;
        }

        public new double IzracunajPorabo(double prevozeniKm)
        {
            return (prevozeniKm / 100) * PorabaNa100KmKWh;
        }

    }
}
