using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?"); //Console.Write is the equivalen to input in python , This line of code asks for user input.
        string userName = Console.ReadLine(); //Console.ReadLine is the equivalent to print in python , this prints in the user input.
        Console.Write("What is your last name?");
        string userLastName = Console.ReadLine();

        Console.WriteLine($"Your name is {userLastName}, {userName} {userLastName}.");
    }
}