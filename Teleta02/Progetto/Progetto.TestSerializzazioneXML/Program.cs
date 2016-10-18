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
            var lStudenti = new List<Student>();
            lStudenti.Add(new Student { FirstName = "Vincenzo", LastName = "Iacobelli" });
            lStudenti.Add(new Student { FirstName = "Giovanni", FullName="Gianni", LastName = "Sassanelli" });
            lStudenti.Add(new Student { FirstName = "Salvatore", Sex="M", LastName = "Sorrentino" });


            var studentbody = new StudentBody();
            studentbody.School = "Scuola di c#";

            studentbody.Students =  lStudenti;
            //var salvatore = Studenti.Where(x => x.FirstName == "Salvatore").FirstOrDefault();
            XmlSerializer myXml = new XmlSerializer(typeof(StudentBody));
            myXml.Serialize(new System.IO.StreamWriter("C:\\Temp\\XmlProva.xml"), studentbody);
            
            Console.ReadKey(); 
        }
    }
}
