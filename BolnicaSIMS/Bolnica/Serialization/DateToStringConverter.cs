using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Bolnica.Serialization
{
        /*
    public class DateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is DateTime))
            {
                return null;
            }



            string result;



            if (DateTimeHelper.DateToString((DateTime)value, out result))
            {
                return result;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is string))
            {
                return null;
            }



            DateTime result;



            if (DateTimeHelper.StringToDate((string)value, out result))
            {
                return result;
            }



            return null;
        }

    }
        */
}
