using System.Diagnostics.Contracts;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;

    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted > _target)
        {
            _amountCompleted = _target;
        }
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"Name: {_shortName}, Description: {_description} {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}|{_description}|{_points}|{IsComplete()}|{_bonus}|{_target}|{_amountCompleted}";
    }
}