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

        private int Pivot(int zač, int konec)
        {
            //metoda vrne poicijo pivotnega elements
            double p = tab[zač];
            int m = zač;
            int n = konec + 1;

            //z M poišči prvega, ki je večji od P
            do
            {
                m++;
            } while (tab[m] <= p & m < konec);
            //z N poišči prvega, ki je manjši od P
            do
            {
                n--;
            } while (tab[n] > p);
            // dokler se M in N ne prekrižeta
            while (m < n)
            {
                //zamenjaj
                int temp = tab[m]; tab[m] = tab[n]; tab[n] = temp;

                do{
                    m++;
                } while (tab[m] <= p & m < konec);

                do{
                    n--;
                } while (tab[n] > p);
            } //M in N sta prekrižana

            int temp1 = tab[zač]; tab[zač] = tab[n]; tab[n] = temp1;
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
