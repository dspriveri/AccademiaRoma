using Progetto.Models.Studenti;
using Progetto.Models.Studenti.Ereditarieta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Studente lIstanza = new Studente();
            var lIstanza2 = new Studente();

            lIstanza.FullName = "Pietro Morello";
            lIstanza.FirstName = "Pietro";
            lIstanza.LastName = "Morello";
            lIstanza.Sex = "M";
            lIstanza.GradePointAverage = 10.0;
            var lIstanza3 = new Studente { FirstName = "Giacomo", LastName = "Lengueglia" };

            var Lista_di_Stringhe = new List<String>();
            Lista_di_Stringhe.Add("Gianni Sassanelli");
            Lista_di_Stringhe.Add("Vincenzo Iacobelli");

            var ListaStudenti1 = new List<Studente>();

            foreach (var item in Lista_di_Stringhe)
            {
                ListaStudenti1.Add( new Studente { FullName = item });
            }

            var ListaStudenti2 = Lista_di_Stringhe.
                Select(x => new Studente { FullName = x });

            //foreach (var item in ListaStudenti1)
            //{
            //    Console.WriteLine(item.FullName);
            //}

            var StudenteMedie1 = new StudenteMedie { Classe = 1, FullName = "Pierino" } ;

            var StudenteUniversitario = new StudenteUniversita { Facoltà = "Lettere", FullName = "Paperino" };

            var StudenteVecchio = new Studente ();

            

            StudenteVecchio = StudenteMedie1;
            Console.WriteLine($"Confronto istanze :{StudenteVecchio == StudenteMedie1}  ");

            Console.WriteLine($"Il tipo di StudenteVecchio è {StudenteVecchio.GetType()}");

            Console.WriteLine($"Il Nome dell'istanza di studente vecchio è {nameof(StudenteVecchio)}");

            //   StudenteVecchio = StudenteMedie1 as StudenteMedie;

            StampaFullName(StudenteVecchio);
            StampaFullName(StudenteUniversitario);
            StampaFacolta(StudenteUniversitario);

            if (StudenteVecchio is Studente)
            {
                Console.WriteLine("Studente vecchio è studente");
            }

            // Console.WriteLine("Hello world");
            Console.ReadLine();

        }

        static void StampaFullName(Studente Studente)
        {
            Console.WriteLine($" Il fullname è : {Studente.FullName }");
        }

        static void StampaFacolta(StudenteUniversita Studente)
        {
            Console.WriteLine($" la facoltà è : {Studente.Facoltà }");
        }
    }
}
