
using System;

namespace Preobtez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik p1 = new Pravokotnik();
            Pravokotnik p2 = new Pravokotnik();
            Pravokotnik p3 = new Pravokotnik(10, 15);
            p1.Širina = 10;
            p1.Dolžina = 15;
            p2.Širina = 25; p2.Dolžina = 10;
            Console.WriteLine("Pravokotnik 1 " + p1.ToString());
            Console.WriteLine("Pravokotnik 1 " + p2.ToString());
            Console.WriteLine("Pravokotnik 1 " + p3.ToString());
            if (p1.Ploščina() == p2.Ploščina()) Console.WriteLine("p1=p2");
            else
            {
                if (p1.Ploščina() > p2.Ploščina()) Console.WriteLine("P1 je večji od P2");
                else Console.WriteLine("P2 je večji od P1");
            }
            if (p1.Ploščina() == p3.Ploščina()) Console.WriteLine("P1 je enak P3");
            Console.ReadLine();
        }
    }
}
