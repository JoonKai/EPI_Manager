﻿using System.Windows.Media;
using System.Windows;

namespace HellsysLibrary.Extensions
{
    public static class FindElementExtension
    {
        public static T FindParent<T>(this DependencyObject child)
            where T : DependencyObject
        {
            return FindParent<T>(child, null);
        }
        public static T FindParent<T>(this DependencyObject child, string parentName)
        where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(child);
            if (parent == null)
            {
                return null;
            }
            var frameworkElement = (FrameworkElement)parent;
            if ((parentName == null || frameworkElement.Name == parentName) && frameworkElement is T)
            {
                return (T)parent;
            }
            else
            {
                return FindParent<T>(parent, parentName);
            }
        }
    }
}
