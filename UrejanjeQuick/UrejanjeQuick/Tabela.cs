using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrejanjeQuick
{
    internal class Tabela
    {
        int[] tab;
        int štEementov;

        public Tabela(int velikost)
        {
            tab = new int[velikost];
            štEementov = 0;
        }
        public void Dodaj(int k)
        {
            tab[štEementov++] = k;
        }
        public void Izpisi()
        {
            for (int k = 0; k < tab.Length; k++) 
            {
                Console.Write("{0,4}", tab[k]);
            }
            Console.WriteLine();
        }
    }
}
