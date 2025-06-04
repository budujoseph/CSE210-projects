using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity("Breathing", "This activity will help you relax by breathing in and out slowly.");
        activity.setDuration(5);

        activity.DisplayStartingMessage();
        activity.ShowCountDown(5);       // Countdown from 5
        activity.showSpinner(3);         // Show spinner for 3 seconds
        activity.DisplayEndingMessage(); // Ending message
    }
}