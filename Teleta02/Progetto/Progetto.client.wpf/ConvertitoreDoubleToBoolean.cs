using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Progetto.client.wpf
{
    public class ConvertitoreDoubleToBoolean : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
          
            return (double)value > 1.5D;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Boolean)value ? 3 : 5 ; 
        }
    }
}
