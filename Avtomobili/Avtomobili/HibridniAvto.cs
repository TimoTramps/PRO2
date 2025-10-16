using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtomobili
{
    internal class HibridniAvto:Avto
    {

        public double ElektricniDelez { get; set; }

        //public HibridniAvto(string znamka, double elDelez)
        //: base(znamka, 0)
        //{
        //    ElektricniDelez = elDelez;
        //}

        public HibridniAvto(string znamka, double porabaNa100Km, double elektricniDelez)
        : base(znamka, porabaNa100Km)
        {
            ElektricniDelez = elektricniDelez;
        }

        public new double IzracunajPorabo(double prevozeniKm)
        {
            double porabaBencina = base.IzracunajPorabo(prevozeniKm);
            double porabaElektrike = prevozeniKm * ElektricniDelez / 100 * 15;

            Console.WriteLine($"Poraba bencina: {porabaBencina} litrov");
            Console.WriteLine($"Poraba elektrike: {porabaElektrike} kWh");

            return porabaBencina;
        }

    }
}
