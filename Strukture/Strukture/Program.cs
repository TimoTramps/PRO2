using System.Security.Cryptography;

namespace Strukture
{
    internal class Program
    {

        struct Vektor //1. je vrednostni tip/
        {
            public double x, y, z;

            //2. Struktura ni namenjena dedovanju, deduje od razreda Object
            public override string ToString()
            {
                return "(" + x + ", " + y + ", " + z + ")";
            }

            //3. ne moremo imeti konstruktorja brez parametrov
            public Vektor(double x1,double y1,double z1)
            {
                x = x1; y = y1; z = z1;
            }
            public Vektor(Vektor v)
            {
                x = v.x; y = v.y; z = v.z;
            }
            public static Vektor operator +(Vektor levi, Vektor desni)
            {
                Vektor r = new Vektor();
                r.x = levi.x + desni.x;
                r.y = levi.y + desni.y;
                r.z = levi.z + desni.z;
                return r;
            }

            public static Vektor operator *(double l, Vektor d)
            {
                Vektor r = new Vektor();
                r.x = l * d.x;
                r.y = l * d.y;
                r.z = l * d.z;
                return r;
            }

            public static Vektor operator *(Vektor l, double d)
            {
                return d*l;
            }

            public static double operator *(Vektor a, Vektor b)
            {
                return a.x * b.x + a.y * b.y + a.z * b.z;
            }
            public static bool operator ==(Vektor a, Vektor b)
            {
                return a.x==b.x && a.y==b.y && a.z==b.z;
            }
            public static bool operator !=(Vektor a, Vektor b)
            {
                return !(a==b);
            }

        }
        static void Main(string[] args)
        {
            Vektor v1 = new Vektor(3,2,0);
            Console.WriteLine(v1.ToString());
            Vektor v2 = new Vektor(1,2,1);
            Console.WriteLine(v2.ToString());
            Vektor v3 = v1 + v2;
            Console.WriteLine(v3.ToString());
            Vektor v4 = 5*v1;
            Console.WriteLine(v4.ToString());
            Vektor v5 = v1*5;
            Console.WriteLine(v5.ToString());
            double s = v1 * v2;
            Console.WriteLine(s);
            bool b = v1==v2;
            Console.WriteLine(b);
        }
    }
}
