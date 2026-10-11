using System;

public class EternalGoal : Goal
{
    // Constructor: Passes the name, description, and points up to the base Goal class
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    // Overrides RecordEvent: For an eternal goal, recording it just awards points. 
    // It does not change a completion status because it never finishes!
    public override void RecordEvent()
    {
        // You can add a friendly confirmation message here if you like
        Console.WriteLine($"Good job! Eternal goal recorded.");
    }

    // Overrides IsComplete: Always returns false because eternal goals are never finished.
    public override bool IsComplete()
    {
        return false;
    }

    // Overrides GetDetailsString: Always displays an empty checkbox [ ] because it's never completed
    public override string GetDetailsString()
    {
        return $"[ ] {base.GetDetailsString()}";
    }

    // Overrides GetStringRepresentation: Formats data for saving to a file
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}"; // We will include name/description in the base/manager logic
    }
}