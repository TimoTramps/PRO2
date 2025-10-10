using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMen
{
    internal class Fizikalec : Mutant
    {
        public int IQ { get; set; }

        public int Moč { get; set; }
        public override int KvocientNevarnosti()
        {
            return Stopnja * IQ * Moč;
        }
    }
}
