using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int intGrade = int.Parse(grade); //Change the grade from string to integer

        string letter = ""; //Re-initialises a varible that takes in a string
        if (intGrade >= 90)
            {
                letter = "A"; //Assigns a letter grade to letter
            }
        else if (intGrade >= 80)
            {
                letter = "B"; //Assigns a letter grade to letter
            }
        else if (intGrade >= 70)
            {
                letter = "C"; //Assigns a letter grade to letter
            }
        else if (intGrade >= 60)
            {
                letter = "D"; //Assigns a letter grade to letter
            }
        else
            {
                letter = "F"; //Assigns a letter grade to letter
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