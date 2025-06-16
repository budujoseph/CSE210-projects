using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 03, 4), 30, 4.8),
            new Cycling(new DateTime(2023, 12, 11), 25, 25.0),
            new Swimming(new DateTime(2023, 10, 05), 30, 14)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}