using System;
using System.Collections.Generic;
using System.IO;

// *********************
// Base abstract class "Goal"
// *********************
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetShortName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    // Abstract methods to be overridden in derived classes
    public abstract int RecordEvent();
    public abstract bool IsComplete();

    // Default implementation for displaying goal details; can be overridden if needed
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName}: {_description}";
    }

    // Returns a string representation to be saved to a file.
    public abstract string GetStringRepresentation();
}

