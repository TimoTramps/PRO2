using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrike
{
    internal class Matrika
    {
        public double[,] tab = new double[3, 3];


        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= 3 || j < 0 || j >= 3)
                    throw new IndexOutOfRangeException("Indeksi morajo biti med 0 in 2.");
                return tab[i, j];
            }
            set
            {
                if (i < 0 || i >= 3 || j < 0 || j >= 3)
                    throw new IndexOutOfRangeException("Indeksi morajo biti med 0 in 2.");
                tab[i, j] = value;
            }
        }

        public static Matrika operator +(Matrika m1, Matrika m2)
        {
            Matrika rezultat = new Matrika();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    rezultat[i, j] = m1[i, j] + m2[i, j];
            }
            return rezultat;
        }

        public void Tiskaj()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(tab[i, j] + "\t");

                Console.WriteLine();
            }
        }
    }
} 


