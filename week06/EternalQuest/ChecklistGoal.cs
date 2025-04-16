
// *********************
// ChecklistGoal Class
// *********************
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            // Award bonus points when the target is exactly met on this event.
            if (IsComplete())
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName}: {_description} (Completed: {_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        // Format: ChecklistGoal;shortName;description;points;amountCompleted;target;bonus
        return $"ChecklistGoal : {_shortName} | {_description}  | {_points} | {_amountCompleted} | {_target} | {_bonus}";
    }
}
