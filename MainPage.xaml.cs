namespace Event_Managment
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
           EventCreation Page = new EventCreation();
           await Navigation.PushAsync(new EventCreation());

        }
    }

}
/*designed to manage interactions within this main page, specifically focusing on navigating to another page within the application when a button is clicked*/
