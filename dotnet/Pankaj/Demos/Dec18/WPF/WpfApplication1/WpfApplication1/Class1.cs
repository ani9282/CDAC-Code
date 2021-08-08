using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace WpfApplication1
{
    public class Person
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
    public class DoubleToWholeNumberValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double d = System.Convert.ToDouble(value);
            return Math.Round(d);
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }

}
