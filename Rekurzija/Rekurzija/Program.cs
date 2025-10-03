using System.Net.Http.Headers;

namespace Rekurzija
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = fakulteta(5);
            Console.WriteLine(a);

            int b = fr(5);
            Console.WriteLine(b);

            int c = Fibonacci(7);
            Console.WriteLine(c);

            int d = recf(5);
            Console.WriteLine(d);
        }

        static int fakulteta(int n)
        {
            int produkt = 1;
            for (int k = n; k > 1; k--)
                produkt *= k;
            return produkt;

        }

        //rekurzvno

        static int fr(int n)
        {
            if (n == 0)
                return 1;
            return n * fr(n - 1);
        }

        //fibonacci

        static int Fibonacci(int n)
        {

            if (n == 1 || n == 2)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        //2,2,3,5,14,69,965

        //a1=2, a2=2, a(n) = a(n-2)*a(n-1)-1


        static int recf(int n)
        {
            if (n == 1 || n == 2)
                return 2;
            return recf(n - 2) * recf(n - 1) - 1;
        }
    }
}
