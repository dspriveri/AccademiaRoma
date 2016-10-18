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
using System.Windows.Shapes;
using Progetto.business;
using Progetto.Models.Studenti;

namespace progetto.ClientVpfLibrerieBusinness
{
    /// <summary>
    /// Interaction logic for NewModelDaBusiness.xaml
    /// </summary>
    public partial class NewModelDaBusiness : Window
    {
        public NewModelDaBusiness()
        {
            InitializeComponent();
            var vistaModello = new ViewModelStudenti();
            LV.ItemsSource = vistaModello.EstrazioneViewModelStudenti("c:\\temp\\students.xml");
              
        }
    }
}
