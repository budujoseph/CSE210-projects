using System;
using System.Collections.Generic;
using System.IO;

public static class GoalDataHandler
{
    public static void SaveData(GoalManager user, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(user.GetScore());
            foreach (Goal goal in user.GetGoals())
            {
                writer.WriteLine($"{goal.GetType().Name} | {goal._shortName} | {goal._description} | {goal._points} | {goal._isComplete} | {goal.GetStatus()}");

            }
        }
    }

    public static GoalManager LoadData(string filePath)
    {
        GoalManager user = new GoalManager();
        if (File.Exists(filePath)) 
        {

            using (StreamReader reader = new StreamReader(filePath))
            {
                if (int.TryParse(reader.ReadLine(), out int score))
                {
                    user.SetScore(score);
                }

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");

                    if (parts.Length >= 5)
                    {
                        string goalType = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        bool Iscomplete = bool.Parse(parts[4]);

                        Goal goal = goalType switch
                        {
                            "SimpleGoal" => new SimpleGoal(name, description, points),
                            "EternalGoal" => new EternalGoal(name, description, points),
                            "CheckListGoal" when parts.Length >= 7 =>
                                new ChecklistGoal(name, description, points, int.Parse(parts[5]), int.Parse(parts[6])),
                            _ => null
                        };

                        if (goal != null)
                        {
                            if (Iscomplete)
                            {
                                goal.RecordEvent();
                            }

                            user.AddGoal(goal);
                        }
                    }
                }
            }
        }
        return user;
    }
}