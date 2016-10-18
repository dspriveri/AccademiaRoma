using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto.Models.Studenti;
using System.Xml.Serialization;
using System.IO;
using Progetto.Servizi.Studenti.Implementations;
using Progetto.Servizi.Studenti.Interfaces;

namespace Progetto.TestLettura
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Serializer = new XmlSerializer(typeof(StudentBody));
            //var Scuola = (StudentBody)Serializer.Deserialize(new StreamReader("c:\\Temp\\XmlProva.xml"));

            //Console.WriteLine(Scuola.School);
            //Console.ReadLine();

            IServizioStudenti Servizio = new XmlProvider();
            var Studenti = Servizio.GetStudents("c:\\Temp\\Students.xml");
            foreach (var item in Studenti)
            {
                Console.WriteLine(item.ToString());
            
            }

            Console.ReadLine();
        }
    }
}
