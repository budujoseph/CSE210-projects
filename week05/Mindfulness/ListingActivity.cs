using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static readonly string [] _prompts = {
        "Who are people that you appreciate?",
        "What are your personal strength?",
        "Who have you helped this week?",
        "What are the good things in your life?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(prompt);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items");
    }
}