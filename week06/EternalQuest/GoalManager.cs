using System;
using System.Collections.Generic;

public class GoalManager
{
    private int _score;
    private List<Goal> _goals;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal) => _goals.Add(goal);
    public List<Goal> GetGoals() => _goals;
    public int GetScore() => _score;
    public void SetScore(int score) => _score = score;

    public void RecordEvent(string goalName)
    {
        Goal goal = _goals.Find(g => g._shortName == goalName);

        if (goal != null)
        {
            int points = goal.RecordEvent();
            _score += points;
            Console.WriteLine($"Event recorded. Points Earned: {points}. Total Score: {_score}");
        }

        else
        {
            Console.WriteLine("Goal Not Found");
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal._shortName} : {goal.GetStatus()}");
        }
    }
}