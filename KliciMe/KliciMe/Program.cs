namespace KliciMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Kupec jani = new Kupec();
            jani.Ime = "Jani";
            jani.BeležiKlic(10, TipKlica.Stacionarno);
            //Console.WriteLine(jani.Ime+" dolguje "+jani.Stanje+" EUR");
            Console.WriteLine(jani.ToString());
            //Console.WriteLine("GetType: " + jani.GetType());

            Kupec zden = new Kupec60();
            zden.Ime = "Zdenka";
            zden.BeležiKlic(100, TipKlica.Mobilno);
            //Console.WriteLine(zden.Ime + " dolguje " + zden.Stanje + " EUR");
            Console.WriteLine(zden.ToString());
            Console.WriteLine("******************************************");
            Kupec[] vsiKupci = new Kupec[2];
            vsiKupci[0] = new Kupec();
            vsiKupci[0].Ime = "Andrej";
            vsiKupci[0].BeležiKlic(10, TipKlica.Stacionarno);

            vsiKupci[1] = new Kupec();
            vsiKupci[1].Ime = "Tanja";
            vsiKupci[1].BeležiKlic(100, TipKlica.Mobilno);
            Console.WriteLine(vsiKupci[0].ToString());
            Console.WriteLine(vsiKupci[1].ToString());
        }
    }
}
