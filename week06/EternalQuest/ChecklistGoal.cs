using System;

public class ChecklistGoal : Goal
{
    // Private member variables for tracking checklist progress (Encapsulation)
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor: Takes base details plus target count and bonus points
    public ChecklistGoal(string name, string description, string points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0; // Starts at 0 progress
        _target = target;
        _bonus = bonus;
    }

    // Overrides RecordEvent: Increases progress count by 1 each time it's recorded
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    // Overrides IsComplete: Returns true ONLY if current progress has reached the target
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Overrides GetDetailsString: Displays custom progress info like "Completed 2/5 times"
    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    // A special method to check if the user just earned the bonus on the final step
    public int GetBonus()
    {
        return _bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    // Overrides GetStringRepresentation: Formats data for saving to a file
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_amountCompleted},{_target},{_bonus}";
    }
}