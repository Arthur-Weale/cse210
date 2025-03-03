using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numList = new List<int>();//Creates a list.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userInputNum;
        int runningTotal = 0;
        int avg = 0;
        int max;
        do
            {
                Console.Write("Enter number: ");
                string userInput = Console.ReadLine();
                userInputNum = int.Parse(userInput);
                
                if(userInputNum > 0)
                    {
                        numList.Add(userInputNum); //Adds objects in the list
                    }

                max =  numList.Max(); //Finds the largest number in a list
                if (userInputNum == 0) //Condition to start making calculations if the input is zero
                    {
                        foreach (int integer in numList)
                            {
                                //Mathematical operations perfomed below.
                                runningTotal = runningTotal+ integer; 
                                avg = runningTotal / numList.Count();
                            }
                            Console.WriteLine($"The sum is: {runningTotal}");
                            Console.WriteLine($"The average is: {avg}");
                            Console.WriteLine($"The largest is: {max}");
                    }
                
            }
        while(userInputNum != 0);
    }
}