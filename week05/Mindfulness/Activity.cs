using System;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void setDuration(int duration) {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_activityName}");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
       Console.WriteLine("Well done");
       Console.WriteLine($"You have completed the {_activityName} activity for {_duration} seconds");
    }

    public void showSpinner(int seconds)
    {
        string[] spinner = {"|", "/", "-", "\\"};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{spinner[i % spinner.Length]}");
            Thread.Sleep(200);
            i++;
        }

        Console.Write("\r");
        Console.WriteLine();
    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write($"Starting in: {second} seconds...");
        }

        Console.WriteLine();
    }
}