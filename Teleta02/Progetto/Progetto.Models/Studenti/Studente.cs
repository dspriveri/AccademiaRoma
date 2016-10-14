using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Progetto.Models.Studenti
{
    public class Student
    {
        public string  FullName { get; set; }
        public string FirstName { get; set; }

        private string sesso;
       // [XmlIgnore]
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

        public string MiddleName { get; set; } = "MR.Default";
        public string LastName { get; set; } = "";

        public string PhotoFilename { get; set; } = "No Photo";
        public Double GradePointAverage { get; set; } = 2;


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
