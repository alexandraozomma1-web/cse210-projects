using System;

public abstract class Activity
{
    // Private member variables (Encapsulation)
    private string _date;
    private int _minutes;

    // Constructor to set shared attributes
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Public getters so derived classes can access date and minutes if needed
    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    // Abstract methods that derived classes MUST override
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} ({GetMinutes()} min)";
    }
}