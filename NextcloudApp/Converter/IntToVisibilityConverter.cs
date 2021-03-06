﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace NextcloudApp.Converter
{
    public class IntToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var number = int.Parse(value.ToString());
            return number == 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}
