﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace LondonTowerLibrary.Converters
{
    /// <summary>
    /// Le converter extrait l'heure et les minutes d'un type DateTime et les format avant d'envoyer le résultat en string. 
    /// </summary>
    [ValueConversion(typeof(DateTime), typeof(String))]
    public class HourToStringConverter : IValueConverter
    {
        public static HourToStringConverter Instance = new HourToStringConverter();

        /// <summary>
        /// sens Model Viewer -> IHM
        /// extrait l'heure et les minutes d'un type DateTime et les format avant d'envoyer le résultat en string. 
        /// Les paramêtres sont automatiquement fournis par le Binding.
        /// Renverra un string vide si le DateTime a sa valeur par défaut.
        /// </summary>
        /// <param name="value">DateTime value</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime)value != default) ? ((DateTime)value).ToString("HH:mm") : "";
        }

        /// <summary>
        /// Sens IHM -> Model Viewer
        /// Ce sens n'es pas censé être utilisé pour ce converter.
        /// En cas d'utilisation, il convertira simplement un string en DateTime et convertira en default DateTimeValue si echec de conversion.
        /// </summary>
        /// <param name="value">string value</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (DateTime.TryParse((string)value, out DateTime date)) ? date : new DateTime();
        }
    }
}
