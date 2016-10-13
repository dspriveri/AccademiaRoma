using Progetto.Models.Studenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Progetto.TestSerializzazioneXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var Studenti = new List<Studente>();
            Studenti.Add(new Studente { FirstName = "Vincenzo", LastName = "Iacobelli" });
            Studenti.Add(new Studente { FirstName = "Giovanni", FullName="Gianni", LastName = "Sassanelli" });
            Studenti.Add(new Studente { FirstName = "Salvatore", Sex="M", LastName = "Sorrentino" });

            
            //var salvatore = Studenti.Where(x => x.FirstName == "Salvatore").FirstOrDefault();
            XmlSerializer myXml = new XmlSerializer(typeof(List<Studente>));
            myXml.Serialize(new System.IO.StreamWriter("C:\\Temp\\XmlProva.xml"),Studenti);
            
            Console.ReadKey(); 
        }
    }
}
