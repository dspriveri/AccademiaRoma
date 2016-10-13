using Progetto.Models.Studenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.TestSerializzazioneXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var Studenti = new List<Studente>();
            Studenti.Add(new Studente { FirstName = "Vincenzo", LastName = "Iacobelli" });
            Studenti.Add(new Studente { FirstName = "Giovanni", LastName = "Sassanelli" });
            Studenti.Add(new Studente { FirstName = "Salvatore", LastName = "Sorrentino" });
            
            var salvatore = Studenti.Where(x => x.FirstName == "Salvatore").FirstOrDefault();
            Console.WriteLine(salvatore.FirstName);
            Console.ReadKey(); 
        }
    }
}
