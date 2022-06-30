﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using EFCorePowerTools.Contracts.ViewModels;

namespace EFCorePowerTools.Converter
{
    public class ObjectTypeIconToImageStyleConverter : IValueConverter
    {
        public ResourceDictionary ResourceDictionary { get; set; }

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var objectType = (ObjectTypeIcon)value;
            var key = $"{objectType}ImageStyle";
            return ResourceDictionary[key];
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}