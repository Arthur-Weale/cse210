using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage(); 
        string getUserName = PromptUserName();
        int getPromptUserNumber = PromptUserNumber();
        int getSquareNumber = SquareNumber(getPromptUserNumber);
        DisplayResult(getSquareNumber, getUserName);
    }
    static void DisplayWelcomeMessage ()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName ()
    {  
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumString = Console.ReadLine();
        int userNumInt = int.Parse(userNumString);
        return userNumInt;
    }

    static int SquareNumber (int getPromptUserNumber)
    {
        int squaredNum = getPromptUserNumber * getPromptUserNumber;
        return squaredNum;
    }

    static void DisplayResult (int getSquareNumber, string getUserName)
    {
        Console.WriteLine($"{getUserName} , the square of your number is {getSquareNumber}");
    }    
}