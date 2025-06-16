using System;

public class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public int Duration => _duration;
    public DateTime Date => _date;

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Activity ({_duration} min) : Distance: {GetDistance(): 0.0} km, Speed: {GetSpeed(): 0.0} kph, Pace: {GetPace(): 0.0} min per km";
    }
}