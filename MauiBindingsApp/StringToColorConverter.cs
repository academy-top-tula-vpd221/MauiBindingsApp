using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBindingsApp
{
    public class StringToColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            string? colotStr = value?.ToString()?.Trim().ToLower();
            switch(colotStr)
            {
                case "red": return Colors.Red;
                case "magenta": return Colors.Magenta;
                case "green": return Colors.Green;
                case "yellow": return Colors.Yellow;
                default: return Colors.Black;
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            Color? color = value as Color;
            string? colorHex = color?.ToHex();
            switch(colorHex)
            {
                case "#FF0000": return "red";
                case "#FF00FF": return "magenta";
                case "#00FF00": return "green";
                case "#00FFFF": return "yellow";
                default: return "black";
            }
        }
    }
}
