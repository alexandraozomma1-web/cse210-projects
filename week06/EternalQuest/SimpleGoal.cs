using System;

public class SimpleGoal : Goal
{

    private bool _isComplete;


    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }


    public override void RecordEvent()
    {
        _isComplete = true;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

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


