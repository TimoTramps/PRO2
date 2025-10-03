namespace Palindromi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "kajak";
            string b = "mark";
            string c = "pericarežeracirep";

            JePalindrom(a, a);
            JePalindrom(b, b);
            JePalindrom(c, c);
        }

        static void JePalindrom(string n, string og)
        {
          if (n.Length == 0 || n.Length == 1)
                Console.WriteLine("Beseda " + og + " je palindrom. ;)");
            else if (n[0] == n[n.Length - 1])
                JePalindrom(n.Substring(1, n.Length - 2), og);
            else
                Console.WriteLine("Beseda " + og + " ni palindrom. :(");
        }
    }
}
