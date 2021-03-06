using System;
using MvvmCross.Converters;

namespace EventBookerAndroid.Core.Converters
{
    public class DateTimeToDayConverter : MvxValueConverter<DateTime, string>
    {
        protected override string Convert(DateTime value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            return value.ToString("MMM dd, yyyy");
        }
    }
}
