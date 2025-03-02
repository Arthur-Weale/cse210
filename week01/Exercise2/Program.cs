using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int intGrade = int.Parse(grade); 

        string letter = "";
        if (intGrade >= 90)
            {
                letter = "A";
            }
        else if (intGrade >= 80)
            {
                letter = "B";
            }
        else if (intGrade >= 70)
            {
                letter = "C";
            }
        else if (intGrade >= 60)
            {
                letter = "D";
            }
        else
            {
                letter = "F";
            }

        Console.WriteLine($"Your grade is {letter}.");
        if (intGrade >= 70)
            {
                Console.WriteLine("Congratulations! You passed.");
            }
        else
            {
                Console.WriteLine("Sorry, Study smarter not harder.");
            }
    }
}