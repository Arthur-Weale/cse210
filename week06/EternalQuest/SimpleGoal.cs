
// *********************
// SimpleGoal Class
// *********************
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_shortName}: {_description}";
    }

    public override string GetStringRepresentation()
    {
        // Format: SimpleGoal;shortName;description;points;isComplete
        return $"SimpleGoal;{_shortName} | {_description} | {_points} | {_isComplete}";
    }
}