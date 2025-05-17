using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string [] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("\nJournal Menu: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Random rand = new Random();
                    string prompt = prompts[rand.Next(prompts.Length)];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your Response: ");
                    string response = Console.ReadLine();
                    myJournal.AddEntry(prompt, response);
                    break;
                
                case "2":
                    myJournal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter Filename to save: ");
                    string fileName = Console.ReadLine();
                    myJournal.SaveToFile(fileName);
                    Console.WriteLine("File Saved...");
                    break;

                case "4":
                    Console.Write("Enter Filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    Console.WriteLine("File loaded successfully");
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid entry, please try again");
                    break;


            }
        }
    }
}