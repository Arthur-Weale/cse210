public class Assignments
{
    protected string _studentName ;
    protected string _topic;

    public Assignments(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}