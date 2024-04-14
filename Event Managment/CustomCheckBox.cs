using Microsoft.Maui.Controls;

namespace Event_Managment
{
    public class CustomCheckBox : CheckBox
    {
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomCheckBox), "");

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
    }
}
