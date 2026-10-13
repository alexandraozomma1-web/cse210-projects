using System;

public class Swimming : Activity
{
    // Private attribute for Swimming: Laps tracked directly (Encapsulation)
    private int _laps;

    // Constructor passing date and minutes up to the base Activity class
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // Overriding distance: converting laps to miles (laps * 50 / 1000 * 0.62)
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000 * 0.62;
    }

    // Overriding speed: (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    // Overriding pace: minutes / distance
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    // Summary for Swimming
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetMinutes()} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}