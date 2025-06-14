using System;

class Program
{
    public static void Main(string[] args)
    {
        GoalManager user = new GoalManager();

        while (true)
        {
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Create Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. View Score");
            Console.WriteLine("5. Save Goals to File");
            Console.WriteLine("6. Load Goals from File");
            Console.WriteLine("7. Exit");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    user.DisplayGoals();
                    break;

                case "2":
                    CreateGoal(user);
                    break;

                case "3":
                    Console.WriteLine("Enter goal name");
                    string goalName = Console.ReadLine();
                    user.RecordEvent(goalName);
                    break;

                case "4":
                    Console.WriteLine($"Current score: {user.GetScore()}");
                    break;

                case "5":
                    Console.WriteLine("Enter file path to save goals.");
                    string savePath = Console.ReadLine();
                    GoalDataHandler.SaveData(user, savePath);
                    Console.WriteLine("Goals saved successfully");
                    break;

                case "6":
                    Console.WriteLine("Enter file path to load goals");
                    string loadPath = Console.ReadLine();
                    user = GoalDataHandler.LoadData(loadPath);
                    Console.WriteLine("Goals loaded successfully");
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    public static void CreateGoal(GoalManager user)
    {
        Console.WriteLine("Enter Goal Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the points to be awarded after completing this goal: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string goalType = Console.ReadLine();
        Goal newGoal = null;

        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;

            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;

            case "3":
                Console.WriteLine("Enter the number of times this goal must be completed");
                int targetCount = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter bonus points awarded upon completion: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                break;

            default:
                Console.WriteLine("Invalid goal type");
                return;
        }

        user.AddGoal(newGoal);
        Console.WriteLine("Goal created successfully");

    }
}