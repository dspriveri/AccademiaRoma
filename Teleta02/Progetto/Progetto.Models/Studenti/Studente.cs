using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Models.Studenti
{
    public class Studente
    {
        public string  FullName { get; set; }
        public string FirstName { get; set; }

        private string sesso;
        public string Sex {
            get
            {
                return sesso;
            }
            set
            {
                sesso = value;
            }
        }

        public string  MiddleName { get; set; }
        public string  LastName { get; set; }

        public string PhotoFileName { get; set; }
        public Double GradePointAverage { get; set; }


        public override string ToString()
        {
            String c = $"ToString overrided {base.ToString()}";

            StringBuilder SB = new StringBuilder();

            SB.AppendLine(c);
            SB.AppendLine(this.FirstName);
            SB.AppendLine(this.LastName);

            return SB.ToString();
        }
    }
}
