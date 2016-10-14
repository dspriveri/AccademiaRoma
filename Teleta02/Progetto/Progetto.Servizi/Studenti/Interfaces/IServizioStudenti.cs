using Progetto.Models.Studenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Servizi.Studenti.Interfaces
{
    public interface IServizioStudenti
    {
        List<Student> GetStudents(string FilePath);

        StudentBody GetSchool(String FilePath);


        //Student GetStudent(String FullName);

        //void CreaStudente(Student Studente);
    }
}
