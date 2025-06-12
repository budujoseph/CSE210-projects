using System;
using System.Security.Cryptography.X509Certificates;

public abstract class Goal
{
    public string _shortName { get; private set; }
    public string _description { get; private set; }
    public int _points { get; protected set; }
    public bool _isComplete { get; protected set; }

    protected Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
}

// SIMPLE GOAL CLASS
public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string GetStatus() => _isComplete ? "[X] Completed" : "[ ] Not Completed";
}

//ETERNAL GOAL  CLASS
public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points) { }

    public override int RecordEvent() => _points;

    public override string GetStatus() => "[🤝 ] Eterna; Goal";

}

//CHECKLIST CLASS
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string shortName, string description, int points, int targetCount, int bonusPoints) : base(shortName, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (_isComplete) return 0;

        _currentCount++;
        int earnedPoints = _points;

        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
            earnedPoints += _bonusPoints;

        }

        return earnedPoints;
    }

    public override string GetStatus()
    {
        return _isComplete ? $"[X] Completed {_currentCount} / {_targetCount}"
                           : $"[ ] Completed {_currentCount} / {_targetCount}";
    }
}