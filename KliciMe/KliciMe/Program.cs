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
            Console.WriteLine(jani.Ime+" dolguje "+jani.Stanje+" EUR");

            Kupec zden = new Kupec();
            zden.Ime = "Zdenka";
            zden.BeležiKlic(100, TipKlica.Mobilno);
            Console.WriteLine(zden.Ime + " dolguje " + zden.Stanje + " EUR");
        }
    }
}
