using System;

public class Running : Activity
{
    // Unique private attribute for Running (Encapsulation)
    private double _distance;

    // Constructor that passes date and minutes up to the base Activity class
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // Overriding the abstract distance method
    public override double GetDistance()
    {
        return _distance;
    }

    // Overriding the abstract speed method (mph)
    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    // Overriding the abstract pace method (min per mile)
    public override double GetPace()
    {
        return (double)GetMinutes() / _distance;
    }

    // Summary for Running
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetMinutes()} min): Distance {_distance} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}