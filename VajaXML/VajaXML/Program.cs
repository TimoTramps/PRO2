using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace VajaXML
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Racuni
            FileStream fs = new FileStream("Racuni.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(IzdaniRacunEnostavni));
            IzdaniRacunEnostavni d = (IzdaniRacunEnostavni)xs.Deserialize(fs);

            foreach (IzdaniRacunEnostavniRacunPostavkeRacuna dm in d.Racun.PostavkeRacuna)
            {
                Console.WriteLine(dm.OpisiArtiklov.OpisArtikla.OpisArtikla1 + " " + dm.KolicinaArtikla.Kolicina + " " + dm.ZneskiPostavke.ZnesekPostavke);
            }
        }
    }
}
