using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace VajaJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ucilnica
            FileStream fs = new FileStream("Ucilnica.json", FileMode.Open);
            Class1[] xs = JsonConvert.DeserializeObject<Class1[]>(File.ReadAllText(@"Ucilnica.json"));

            for(int k=0; k <= xs.Length; k++) { 

            foreach (Module dm in xs[k].modules)
            {
                    //Console.WriteLine(dm[k].name);
            }
            
            }
        }
    }
}
