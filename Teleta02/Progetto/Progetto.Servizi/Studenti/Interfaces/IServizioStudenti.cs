using Progetto.Models.Studenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Progetto.Servizi.Studenti.Interfaces
{
    public interface IServizioStudenti
    {
        List<Student> GetStudents(string FilePath);

        StudentBody GetSchool(string FilePath);

        ObservableCollection<Student> GetObservableSchool(string FilePath);

        //Student GetStudent(String FullName);

        //void CreaStudente(Student Studente);
    }
}
