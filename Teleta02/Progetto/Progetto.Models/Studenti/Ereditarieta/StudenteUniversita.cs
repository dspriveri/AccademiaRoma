using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Models.Studenti.Ereditarieta
{
    public class StudenteUniversita:Studente
    {
        public string Facoltà { get; set; }

        public override string ToString()
        {
            String c = $"ToString overrided {base.ToString()}";
            StringBuilder SB = new StringBuilder();
            SB.Append(c);
            SB.Append(Facoltà.ToString());

            return SB.ToString();
        }
    }
}
