using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto.Models.Studenti;
using Progetto.Servizi.Studenti.Interfaces;

namespace Progetto.Servizi.Studenti.Implementations
{
    public class DbRead : IServizioStudenti
    {
        public StudentBody GetSchool(string FilePath)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents(string FilePath)
        {
            throw new NotImplementedException();
        }
    }
}
