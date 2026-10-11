using System;

public class SimpleGoal : Goal
{
    // Private member variable to track completion status (Encapsulation)
    private bool _isComplete;

    // Constructor: Passes name, description, and points up to the base Goal class,
    // and sets _isComplete to false by default because a new goal isn't finished yet.
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // Overrides the base RecordEvent method (Polymorphism)
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // Overrides the base IsComplete method to return our tracking variable
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Overrides GetDetailsString to show a checkbox [ ] or [X] depending on progress
    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {base.GetDetailsString()}";
    }


    public override string GetStringRepresentation()
{
    return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
}
}


