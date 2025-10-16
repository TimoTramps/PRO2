namespace Avtomobili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto[] avti = new Avto[3];
            avti[0] = new Avto("Opel Astra", 6.5);
            avti[1] = new ElektricniAvto("Tesla Model 3", 15.0);
            avti[2] = new HibridniAvto("Toyota Prius", 4.5, 0.3);
            double razdalja = 150;
            for (int k = 0; k < avti.Length; k++)
            {
                double poraba = avti[k].IzracunajPorabo(razdalja);
                Console.WriteLine(avti[k].Znamka + " porabi " + poraba + " na " + razdalja);
            }

        }
    }
}
