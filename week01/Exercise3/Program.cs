using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random(); //With the Random class, creates a storage for the random numbers
        int number = randomGenerator.Next(1,101);// With the method next , this allows creation of non negative numbers from 0
        int guessNum ;

        //Loop 
        do{ 
            Console.WriteLine("Guess the random number:");
            string userGuess = Console.ReadLine();
            guessNum = int.Parse(userGuess); //Changes a string to integer
            
                //Checks if the guess number is greater than the generated number
                if (guessNum > number)
                    {
                        Console.WriteLine("You need to guess lower.");
                    }
                else if (guessNum < number) //Checks if the guess number is less than the generated number
                    {
                        Console.WriteLine("You need to guess higher.");
                    }

            }while (guessNum != number); //Makes the loop to execute continuously as long as the guess number and the random generated number are not equal
            
            Console.WriteLine("Your Guess is correct. Congratulations!");
    }
}