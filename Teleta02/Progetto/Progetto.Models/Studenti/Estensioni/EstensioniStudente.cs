using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Models.Studenti.Estensioni
{
    public static class EstensioniStudente
    {
        public static IEnumerable<Student>
            EstraiStudentiPerSessoEVoto (this IEnumerable<Student> Lista, string sexy, double voto)
        {
            
            return Lista
                .Where(x => (x.Sex == sexy))
                .Where (x => x.GradePointAverage > voto );
        }
    }
}
