using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrejanjeNiz
{
    internal class Tabela
    {
        string[] tab;
        int štEementov;

        public Tabela(int velikost)
        {
            tab = new string[velikost];
            štEementov = 0;
        }
        public void Dodaj(string k)
        {
            tab[štEementov++] = k;
        }
        public void Izpisi()
        {
            for (int k = 0; k < tab.Length; k++)
            {
                Console.Write(tab[k]+" ");
            }
            Console.WriteLine();
        }

        private int Pivot(int zač, int konec)
        {
            // Assume tab is now string[]
            string p = tab[zač];
            int m = zač;
            int n = konec + 1;

            // Find first element greater than pivot p
            do
            {
                m++;
            } while (m < konec && string.Compare(tab[m], p) <= 0);

            // Find first element less than pivot p
            do
            {
                n--;
            } while (string.Compare(tab[n], p) > 0);

            // While m and n do not cross
            while (m < n)
            {
                // Swap tab[m] and tab[n]
                string temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;

                do
                {
                    m++;
                } while (m < konec && string.Compare(tab[m], p) <= 0);

                do
                {
                    n--;
                } while (string.Compare(tab[n], p) > 0);
            }

            // Swap pivot with tab[n]
            string temp1 = tab[zač];
            tab[zač] = tab[n];
            tab[n] = temp1;

            return n;
        }


        public void QuickSort(int zač, int konec)
        {
            if (zač >= konec) return;
            int delitev = Pivot(zač, konec);
            Izpisi();
            QuickSort(zač, delitev - 1);
            QuickSort(delitev + 1, konec);
        }
    }
}
