using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments assignments = new Assignments("Arthur Weale", "Multiplication");
        Console.WriteLine(assignments.GetSummary());
        Console.WriteLine();


        // Assignments assignments1 = new Assignments("Arthur Weale", "Multiplication");
        // Console.WriteLine(assignments1.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("7.3", "8-19", "Arthur Weale", "Multiplication");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II by " ,"Arthur Weale", "European History");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}