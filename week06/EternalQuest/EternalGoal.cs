
// *********************
// EternalGoal Class
// *********************
public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override int RecordEvent()
    {
        // Each recorded event awards points. The goal is never completed.
        return _points;
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        // Mark eternal goals with an infinity symbol
        return $"[∞] {_shortName}: {_description}";
    }

    public override string GetStringRepresentation()
    {
        // Format: EternalGoal;shortName;description;points
        return $"EternalGoal;{_shortName};{_description};{_points}";
    }
}