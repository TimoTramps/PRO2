using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMen
{
    internal abstract class Mutant:IPrikazovalnik
    {
        public string Ime { get; set; }
        public int Stopnja { get; set; }

        public abstract int KvocientNevarnosti();

        public void PrikažiInformacije()
        {
            Console.WriteLine("Sem " + Ime + " moj kvocient nevarnosti je " + KvocientNevarnosti());
        }
    }
}
