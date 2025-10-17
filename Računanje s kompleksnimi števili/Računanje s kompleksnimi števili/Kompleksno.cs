using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Računanje_s_kompleksnimi_števili
{
    internal class Kompleksno
    {
        public double Realna { get; set; }
        public double Imaginarna { get; set; }

        public Kompleksno(double x, double y)
        {
            Realna = x;Imaginarna = y;
        }
        //izpis
        public override string ToString()
        {
            return Realna + " +i* " + Imaginarna;
        }

        public static Kompleksno operator +(Kompleksno z, Kompleksno w)
        {
            Kompleksno r = new Kompleksno(0, 0);
            r.Realna = z.Realna + w.Realna;
            r.Imaginarna = z.Imaginarna + w.Imaginarna;
            return r;
        }
        public static Kompleksno operator -(Kompleksno z, Kompleksno w)
        {
            Kompleksno r = new Kompleksno(0, 0);
            r.Realna = z.Realna - w.Realna;
            r.Imaginarna = z.Imaginarna - w.Imaginarna;
            return r;
        }

        public static Kompleksno operator *(Kompleksno z, Kompleksno w)
        {
            Kompleksno r = new Kompleksno(0, 0);
            r.Realna = z.Realna * w.Realna - z.Imaginarna * w.Imaginarna;
            r.Imaginarna = z.Realna * w.Imaginarna + z.Imaginarna * w.Realna;
            return r;
        }
    }
}
