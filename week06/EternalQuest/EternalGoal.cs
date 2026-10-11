using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // You can add a friendly confirmation message here if you like
        Console.WriteLine($"Good job! Eternal goal recorded.");
    }

    public override bool IsComplete()
    {
        return false;
    }


    public override string GetDetailsString()
    {
        return $"[ ] {base.GetDetailsString()}";
    }


    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}"; // We will include name/description in the base/manager logic
    }
}