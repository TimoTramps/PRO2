namespace vaja_zanke
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Naloga 1
            int stevec = 13;
            if (stevec > 10)
                Console.WriteLine("Števec je večji od 10");

            // Naloga 2
            int sum = 0;
            for (int k = 1; k <= 99; k = k + 2)
                sum += k;
            Console.WriteLine(sum);

            // Naloga 3
            int sum1 = 0;
            int k1 = 1;
            do{
                sum1 += k1;
                k1 = k1 + 2;
            } while (k1 <= 99);
            Console.WriteLine(sum1);


            Console.WriteLine("");
            //Naloga 4
            int j = 1;
            while (j <= 20)
            {
                Console.Write("{0,4}", j);
                if(j%5==0)
                    Console.WriteLine();
                j++;
            }
        }
    }
}
