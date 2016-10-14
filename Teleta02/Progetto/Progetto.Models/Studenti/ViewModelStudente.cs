using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto.Models.Prodotti;

namespace Progetto.Models.Studenti
{
    public class ViewModelStudente
    {
        public string FullName { get; set; }
        public string Sex { get; set; }

        public List<Product> ProdottiConsigliati { get; set; } = new List<Product>();
    }
}
