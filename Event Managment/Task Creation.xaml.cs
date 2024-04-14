using System;
using Microsoft.Maui.Controls;
using XamarinEssentials = Xamarin.Essentials;


namespace Event_Managment
{
    public partial class TaskCreation : ContentPage
    {
        public TaskCreation()
        {
            InitializeComponent();
        }

        private void OnCreateTaskClick(object sender, EventArgs e)
        {
            // Retrieve user input
            string name = nameEntry.Text;
            string eventName = eventNameEntry.Text;
            int age;

            // Validate and parse age input
            if (!int.TryParse(ageEntry.Text, out age))
            {
                DisplayAlert("Error", "Please enter a valid age.", "OK");
                return;
            }

            // Check if age meets minimum requirement
            if (age < 17)
            {
                DisplayAlert("Error", "Minimum age requirement is 17.", "OK");
                return;
            }

            // Assign tasks based on age
            if (age < 18)
            {
                // Assign tasks for participants under 18
                AssignTasksUnder18();
            }
            else
            {
                // Assign tasks for participants 18 and above
                AssignTasksAbove18();
            }
        }

        private void AssignTasksUnder18()
        {
            // Assign tasks for participants under 18
            // In this case, only assign tasks for ushers, ticket checkers, and grounds keepers
            // Implement your logic here
            // Example:
            // stageSetupCheckbox.IsChecked = false;
            // foodHandlerCheckbox.IsChecked = false;
            // groundsCleanerCheckbox.IsChecked = true;
            // ticketCheckerCheckbox.IsChecked = true;
            // usherCheckbox.IsChecked = true;
        }

        private void AssignTasksAbove18()
        {
            // Assign tasks for participants 18 and above
            // In this case, assign all available tasks
            // Implement your logic here
            // Example:
            // stageSetupCheckbox.IsChecked = true;
            // foodHandlerCheckbox.IsChecked = true;
            // groundsCleanerCheckbox.IsChecked = true;
            // ticketCheckerCheckbox.IsChecked = true;
            // usherCheckbox.IsChecked = true;
        }

    }

}
