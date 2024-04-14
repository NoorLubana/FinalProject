using Microsoft.Maui.Controls;

namespace Event_Managment
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCreateEventClicked(object sender, EventArgs e)
        {
            // Navigate to EventCreation page
            await Navigation.PushAsync(new EventCreation());
        }

        private async void OnCreateTaskClicked(object sender, EventArgs e)
        {
            // Navigate to TaskCreation page
            await Navigation.PushAsync(new TaskCreation());
        }
    }
}
