using System.Reflection.Emit;

namespace UrejanjeNiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabela a = new Tabela(11);
            a.Dodaj("Matej"); a.Dodaj("Ana"); a.Dodaj("Teja");
            a.Dodaj("Jani"); a.Dodaj("Luka"); a.Dodaj("Tjaša"); a.Dodaj("Robi");
            a.Dodaj("Rok"); a.Dodaj("Nives"); a.Dodaj("Igor"); a.Dodaj("Sonja");



            Console.WriteLine("Neurejena tabela:");
            a.Izpisi();
            a.QuickSort(0, 10);
            Console.WriteLine("Urejena tabela:");
            a.Izpisi();

        }
    }
}
