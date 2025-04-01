public class MathAssignment : Assignments
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbookSection, string problems, string studentName, string topic):base(studentName,topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic} \nSection {_textbookSection} Problems {_problems}";
    }
}