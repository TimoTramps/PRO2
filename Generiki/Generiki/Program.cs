using System.Collections;

namespace Generiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sklad s1 = new Sklad();
            s1.Push(1);
            s1.Push(2);
            //s1.Push("A");
            int x = (int)s1.Pop();
            Console.WriteLine(x);
            x = (int)s1.Pop();
            Console.WriteLine(x);

            SkladGen<int> s2 = new SkladGen<int>();
            s2.Push(2);
            int y = s2.Pop();

            SkladGen<string> s3 = new SkladGen<string>();
            s3.Push("aaaaaaaaa!!!1!!!");
            string z = s3.Pop();

        }
    }
}
