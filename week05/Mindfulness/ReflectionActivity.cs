using System;

public class ReflectionActivity : Activity
{
    private static readonly string[] _prompts = {
        "Think of a time when you stoop up for someelse else.",
        "Think of a time wen you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time wen you did something really selfless"
    };

    private static readonly string[] _questions = {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from this experince?",
        "How can you apply this experience to other situations?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times when you have shown strength and resilience.")
    {
    }

    public override void Run()
    {
        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine($"Prompts: {prompt}\n");

        int reflectionTimePerSecond = _duration / _questions.Length;

        for (int i = 0; i < _questions.Length; i++)
        {
            string question = _questions[i];
            Console.WriteLine($"Reflection Question: {question}");
            CountDownWithPause(reflectionTimePerSecond);
        }

        Console.WriteLine("\nGood job! You've completed the reflection activity");
    }

    public int GeNumberOfStages()
    {
        return _questions.Length;
    }

    private void CountDownWithPause(int seconds)
    {
        Console.WriteLine($"\nTake {seconds} to reflect...");
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"\rTime left: {i} seconds");
            System.Threading.Thread.Sleep(2000);
        }
        Console.WriteLine();
    }
}