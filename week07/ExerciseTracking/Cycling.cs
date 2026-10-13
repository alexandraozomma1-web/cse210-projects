using System;

public class Cycling : Activity
{
    // Unique private attribute for Cycling: Speed is stored directly (Encapsulation)
    private double _speed;

    // Constructor that passes date and minutes up to the base Activity class
    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // Overriding distance: calculated using speed and minutes
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    // Overriding speed: returns the stored speed directly
    public override double GetSpeed()
    {
        return _speed;
    }

    // Overriding pace: calculated as 60 / speed
    public override double GetPace()
    {
        return 60 / _speed;
    }

    // Summary for Cycling
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetMinutes()} min): Distance {GetDistance():F1} miles, Speed {_speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}