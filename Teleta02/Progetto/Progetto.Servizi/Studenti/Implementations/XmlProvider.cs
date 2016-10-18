using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto.Models.Studenti;
using System.Xml.Serialization;
using System.IO;
using Progetto.Servizi.Studenti.Interfaces;
using System.Collections.ObjectModel;

namespace Progetto.Servizi.Studenti.Implementations
{
    public class XmlProvider : IServizioStudenti
    {
        public ObservableCollection<Student> GetObservableSchool(string FilePath)
        {
            var Serializer = new XmlSerializer(typeof(StudentBody));
            var Scuola = (StudentBody)Serializer.Deserialize(new StreamReader(FilePath));
            return new ObservableCollection<Student> (Scuola.Students);
            
        }

        public StudentBody GetSchool(string FilePath)
        {
            var Serializer = new XmlSerializer(typeof(StudentBody));
            var Scuola = (StudentBody)Serializer.Deserialize(new StreamReader(FilePath));
            return Scuola;
        }

        public List<Student> GetStudents(string FilePath)
        {
            var Serializer = new XmlSerializer(typeof(StudentBody));
            var Scuola = (StudentBody)Serializer.Deserialize(new StreamReader(FilePath));
            return Scuola.Students;   
        }

     
    }
}
