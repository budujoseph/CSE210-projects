using System;

public class Activity
{
    protected string _activityName{get; set; }
    protected string _description{get; set; }
    protected int _duration{get; set; }

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Srating {_activityName}");
        Console.WriteLine(_description);

        if(this is ReflectionActivity)
        {
            Console.Write("Enter the reflection time for each stage(in seconds): ");
            int promptTime = int.Parse(Console.ReadLine());
            int stages = ((ReflectionActivity)this).GeNumberOfStages();
            _duration = promptTime * stages;

            Console.WriteLine($"Total reflection time will be: {_duration} seconds");
        }

        else
        {
            Console.Write("Enter the duration(in seconds); ");
            _duration = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    public virtual void Run()
    {

    }

    public void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in: {i} seconds...");
            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine();
    }
}