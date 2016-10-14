using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Progetto.Servizi.Studenti.Implementations;
using Progetto.Servizi.Studenti.Interfaces;
using Progetto.Models.Studenti;


namespace Progetto.client.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var Servizio = new XmlProvider();
            var scuola = Servizio.GetSchool("c:\\Temp\\Students.xml").School;
            LabelScuola.Content = scuola;

            LV.ItemsSource = Servizio.GetStudents("c:\\Temp\\Students.xml");
            
        }

        
    }
}
