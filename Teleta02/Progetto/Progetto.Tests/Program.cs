using Progetto.Models.Studenti;
using Progetto.Models.Studenti.Ereditarieta;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Progetto.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Student lIstanza = new Student();
            var lIstanza2 = new Student();

            lIstanza.FullName = "Pietro Morello";
            lIstanza.FirstName = "Pietro";
            lIstanza.LastName = "Morello";
            lIstanza.Sex = "M";
            lIstanza.GradePointAverage = 10.0;
            var lIstanza3 = new Student { FirstName = "Giacomo", LastName = "Lengueglia" };

            var Lista_di_Stringhe = new List<String>();
            Lista_di_Stringhe.Add("Gianni Sassanelli");
            Lista_di_Stringhe.Add("Vincenzo Iacobelli");

            var ListaStudenti1 = new List<Student>();

            foreach (var item in Lista_di_Stringhe)
            {
                ListaStudenti1.Add( new Student { FullName = item });
            }

            var ListaStudenti2 = Lista_di_Stringhe.
                Select(x => new Student { FullName = x });

            //foreach (var item in ListaStudenti1)
            //{
            //    Console.WriteLine(item.FullName);
            //}

            var StudenteMedie1 = new StudenteMedie { Classe = 1, FullName = "Pierino" } ;

            var StudenteUniversitario = new StudenteUniversita { Facoltà = "Lettere", FullName = "Paperino" };

            var StudenteVecchio = new Student ();

            

            StudenteVecchio = StudenteMedie1;
            Console.WriteLine($"Confronto istanze :{StudenteVecchio == StudenteMedie1}  ");

            Console.WriteLine($"Il tipo di StudenteVecchio è {StudenteVecchio.GetType()}");

            Console.WriteLine($"Il Nome dell'istanza di studente vecchio è {nameof(StudenteVecchio)}");

            //   StudenteVecchio = StudenteMedie1 as StudenteMedie;

            StampaFullName(StudenteVecchio);
            StampaFullName(StudenteUniversitario);
            StampaFacolta(StudenteUniversitario);

            if (StudenteVecchio is Student)
            {
                Console.WriteLine("Studente vecchio è studente");
            }

            var StudenteUniversitario4 = new StudenteUniversita();

            // UpCasting dell'oggetto
            Student Studente4 = StudenteUniversitario4;

            // DownCasting
            Studente4 = (StudenteUniversita)StudenteUniversitario4;

            Student Studente5 = (Student)Studente4;
            var stud = new Student();

            // Cast diretto che da exception a run time (ma non a design time)
            // !!! StudenteUniversita StudenteUniversita6 = (StudenteUniversita)stud;

            // Cast indiretto che imposta a null l'oggetto se non riesce
            StudenteUniversita StudenteUniversita7 = stud as StudenteUniversita;
            if (StudenteUniversita7 == null)
                Console.WriteLine("Cast ok ma oggetto null");

            StudenteUniversita7 = (StudenteUniversita7==null) 
                ? new StudenteUniversita {
                    FirstName ="Nome Assegnato",
                    LastName="Cognome Assegnato",
                    Facoltà="Facoltà Assegnata"
                } : StudenteUniversita7;
           
            Console.WriteLine(StudenteUniversita7.ToString()); 


            Console.WriteLine("Hello world");
            Console.ReadLine();

        }

        static void StampaFullName(Student Studente)
        {
            Console.WriteLine($" Il fullname è : {Studente.FullName }");
        }

        static void StampaFacolta(StudenteUniversita Studente)
        {
            
            Console.WriteLine($" la facoltà è : {Studente.Facoltà }");
        }
    }
}
