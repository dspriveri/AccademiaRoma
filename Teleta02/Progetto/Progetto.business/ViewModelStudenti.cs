using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto.Models.Studenti.Estensioni;
using Progetto.Servizi.Studenti.Interfaces;
using Progetto.Servizi.Studenti.Implementations;
using Progetto.Models.Studenti;

namespace Progetto.business
{
    public class ViewModelStudenti
    {
        public List<Student> EstrazioneStudentiNellaVista(string FilePath)
        {
            var Servizio = new XmlProvider();
            var Studenti = Servizio.GetSchool(FilePath).Students;
            if (DateTime.Today.Month % 2 == 0)
            {
                return Studenti.EstraiStudentiPerSessoEVoto("Female", 2).ToList();
            }
            else
            {
                return Studenti.EstraiStudentiPerSessoEVoto("Male", 0).ToList();
            }
            
            
        }

        public List<ViewModelStudente> EstrazioneViewModelStudenti (string FilePath)
        {
            var Prodotti = new List<Models.Prodotti.Product>
                        {
                             new Models.Prodotti.Product {
                                 Codice = "ALIM",
                                 Descrizion = "Alimentatore",
                                 Prezzo = 34.00 }
                        };
            var Servizio = new XmlProvider();
            var Studenti = Servizio.GetSchool(FilePath).Students;
            if (DateTime.Today.Month % 2 == 0)
            {
   
                return Studenti.EstraiStudentiPerSessoEVoto("Female", 2).
                    Select(x => new ViewModelStudente
                    {
                        FullName = x.FullName,
                        Sex = x.Sex,
                        ProdottiConsigliati = Prodotti
                    }).ToList();

                    
            }
            else
            {
                return Studenti.EstraiStudentiPerSessoEVoto("Female", 0).
                    Select(x => new ViewModelStudente
                    {
                        FullName = x.FullName,
                        Sex = x.Sex,
                        ProdottiConsigliati = Prodotti
                    }).ToList();
            }
        }
    }
}
