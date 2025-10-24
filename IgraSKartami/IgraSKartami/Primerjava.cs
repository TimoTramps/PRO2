using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraSKartami
{
    internal class Primerjava : IComparer<Karta>
    {
        public int Compare(Karta? x, Karta? y)
        {
            //kdaj je X pred Y -- takrat vrni -1
            if (x.Vrednost < y.Vrednost)
                return -1;//X je pred Y
            if (x.Vrednost > y.Vrednost)
                return 1;//X je za Y
            if (x.Barva < y.Barva)
                return -1;//X je pred Y
            if (x.Barva > y.Barva)
                return 1;//X je za Y
            return 0;
        }
    }
}
