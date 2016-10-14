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
using System.Collections.ObjectModel;
using System.Timers;
using Progetto.Models.Studenti.Estensioni;

namespace Progetto.client.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Cont { get; set; }
        public ObservableCollection<Student> Studenti { get; set; } = new ObservableCollection<Student>();


        public MainWindow()
        {
            InitializeComponent();
            var Servizio = new XmlProvider();
            var scuola = Servizio.GetSchool("c:\\Temp\\Students.xml").School;
            LabelScuola.Content = scuola;



            //     LV.ItemsSource = Servizio.GetStudents("c:\\Temp\\Students.xml");


            Studenti = Servizio.GetObservableSchool  ("c:\\Temp\\Students.xml");
            LV.ItemsSource = Studenti.EstraiStudentiPerSessoEVoto ("Female", 2.5);

            var st = new Student { FirstName = "Monica", PhotoFilename = @"http://images2.fanpop.com/image/photos/14100000/Monica-Bellucci-monica-bellucci-14168755-1600-1200.jpg" };
            Studenti.Add(st);


            //var MioTimer = new System.Timers.Timer(2000);
            //MioTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //MioTimer.Interval = 5000;
            //MioTimer.Enabled = true;




        }

        //private void OnTimedEvent(object sender, ElapsedEventArgs e)
        //{
        //    //var S = (Student)LV.Items[0];
        //    //S.GradePointAverage = S.GradePointAverage
        //    //throw new NotImplementedException();

        //    if (Cont < 2)
        //    {
 
        //        Cont += 1;
        //    }            
        //}
    }
}
