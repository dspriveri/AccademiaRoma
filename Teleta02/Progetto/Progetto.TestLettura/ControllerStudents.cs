using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto.Models.Studenti;
using Progetto.Servizi.Studenti.Interfaces;

namespace Progetto.TestLettura
{
    public class ControllerStudents 
    {
        private IServizioStudenti Servizio;
        public ControllerStudents(IServizioStudenti vServizio)
        {
            this.Servizio = vServizio;

        }

        public List<Student> GetStudents(String Path)
        {
            return this.Servizio.GetStudents(Path);
        } 
    }
}
