using System;
using Windows.UI.Xaml;

namespace IconUriAttachedPropertyDemo
{
    public class Properties
    {
        public static Uri GetIconUri(DependencyObject obj)
        {
            return (Uri)obj.GetValue(IconUriProperty);
        }

        public static void SetIconUri(DependencyObject obj, Uri value)
        {
            obj.SetValue(IconUriProperty, value);
        }

        public static readonly DependencyProperty IconUriProperty =
            DependencyProperty.RegisterAttached("IconUri", typeof(Uri), typeof(Properties), new PropertyMetadata(null));
    }
}
