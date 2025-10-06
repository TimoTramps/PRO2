namespace UrejanjeQuick
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //a.Dodaj(6); a.Dodaj(24); a.Dodaj(80);
            //a.Dodaj(4); a.Dodaj(19); a.Dodaj(84);
            //a.Dodaj(1); a.Dodaj(10); a.Dodaj(13); a.Dodaj(7);
            Random r = new Random();
            Tabela a = new Tabela(11);
            for(int k=0; k<11; k++)
            {
                a.Dodaj(r.Next(100));
            }



            Console.WriteLine("Neurejena tabela:");
            a.Izpisi();
            a.QuickSort(0, 10);
            Console.WriteLine("Urejena tabela:");
            a.Izpisi();

        }
    }
}
