using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() :  base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {   
    }

    public override void Run()
    {
        int cycleCount = 0;
        for (int i = 0; i < _duration; i += 10)
        {
            CountDownWithMessage(5, "Breath in...");
            CountDownWithMessage(5, "Breath out...");

            cycleCount++;
        }

        Console.WriteLine($"\nGood job! You completed {cycleCount} breating cycles.");
    }

    private void CountDownWithMessage(int seconds, string message)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{message} {i}");
            Thread.Sleep(1000);
        }
        Console.Write("\r         \r");
    }
}