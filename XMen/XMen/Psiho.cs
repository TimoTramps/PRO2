using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMen
{
    internal class Psiho : Mutant
    {
        public int IQ { get; set; }

        public int ŠteviloUporabe { get; set; }

        public override int KvocientNevarnosti()
        {
            return Stopnja * IQ * ŠteviloUporabe;
        }
    }
}
