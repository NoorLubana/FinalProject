using System;
using Microsoft.Maui.Controls;
using Xamarin.Essentials; // Make sure to add this using directive

namespace Event_Managment;

public partial class EventCreation : ContentPage
{
    public EventCreation()
    {
        InitializeComponent();
    }

    private void OnCreateEventClicked(object sender, EventArgs e)
    {
        string eventName = eventNameEntry.Text;
        string eventLocation = eventLocationEntry.Text;
        DateTime eventDateTime = eventDatePicker.Date + eventTimePicker.Time;

        // Save event information to preferences
        SaveEvent(eventName, eventLocation, eventDateTime);

        // Display success message
        DisplayAlert("Success", "Event information saved successfully", "OK");
    }

    private void SaveEvent(string eventName, string eventLocation, DateTime eventDateTime)
    {
        // Generate a unique key for the event
        string eventKey = $"Event_{DateTime.Now.Ticks}";

        // Store event details in preferences
        Xamarin.Essentials.Preferences.Set($"{eventKey}_Name", eventName);
        Xamarin.Essentials.Preferences.Set($"{eventKey}_Location", eventLocation);
        Xamarin.Essentials.Preferences.Set($"{eventKey}_DateTime", eventDateTime.ToString());
    }
}
