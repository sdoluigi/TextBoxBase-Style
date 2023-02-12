using System.Windows;
using System.Windows.Controls;

namespace TextBoxBase_Style.Styles
{
    public static class AttacchedProperties
    {
        public static readonly DependencyProperty SelectAllOnEntryProperty = DependencyProperty.RegisterAttached("SelectAllOnEntry", typeof(bool), typeof(AttacchedProperties), new PropertyMetadata(default(bool), SelectAllOnEntryChanged));
        public static bool GetSelectAllOnEntry(DependencyObject d)
        {
            return (bool)d.GetValue(SelectAllOnEntryProperty);
        }
        public static void SetSelectAllOnEntry(DependencyObject d, bool value)
        {
            d.SetValue(SelectAllOnEntryProperty, value);
        }

        private static void SelectAllOnEntryChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            if (!(bool)args.NewValue) return;
            var text = d as TextBox;
            if (text == null) return;
            text.GotFocus += (s, e) =>
            {
                text.SelectionStart = 0;
                text.SelectionLength = text.Text.Length;
            };
        }




        public static readonly DependencyProperty IsMandatoryProperty = DependencyProperty.RegisterAttached("IsMandatory", typeof(bool), typeof(AttacchedProperties), new PropertyMetadata(default(bool)));

        public static bool GetIsMandatory(DependencyObject d)
        {
            return (bool)d.GetValue(IsMandatoryProperty);
        }

        public static void SetIsMandatory(DependencyObject d, bool value)
        {
            d.SetValue(IsMandatoryProperty, value);
        }




        public static readonly DependencyProperty ExampleLabelProperty = DependencyProperty.RegisterAttached("ExampleLabel", typeof(string), typeof(AttacchedProperties), new PropertyMetadata(default(string)));

        public static string GetExampleLabel(DependencyObject d)
        {
            return (string)d.GetValue(ExampleLabelProperty);
        }

        public static void SetExampleLabel(DependencyObject d, string value)
        {
            d.SetValue(ExampleLabelProperty, value);
        }
    }
}
