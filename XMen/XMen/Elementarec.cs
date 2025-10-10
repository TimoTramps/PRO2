using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMen
{
    internal class Elementarec : Mutant
    {
        public int Področje { get; set; }

        public override int KvocientNevarnosti()
        {
            return Stopnja * Področje;
        }
    }
}
