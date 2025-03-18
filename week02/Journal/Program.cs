
//The Journl.txt location is : Journal\bin\Debug\net8.0\journal.txt
//To exceed requirements i added 105 prompts to make the journal more dynamic of sorts.



using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choiceInt;
        Journal journal = new Journal();
        do
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choice!");
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            choiceInt = int.Parse(choice);
            

            if (choiceInt == 1)
            {
                
                journal.AddEntry ();
            }
            else if(choiceInt == 2)
            {
                journal.DisplayAll ();
            }
            else if(choiceInt == 3)
            {
                Console.Write("What is the filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if(choiceInt == 4)
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choiceInt == 5)
            {
                Console.WriteLine("Exiting...");
            }
            else 
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
            
        while ( choiceInt != 5);
    }
}