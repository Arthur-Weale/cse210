using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        int userInputInt ;
        // int durationTime;

        do{
            Console.WriteLine("Menu Options");
            Console.WriteLine("1.Start Breathing Activity");
            Console.WriteLine("2.Start Reflecting Activity");
            Console.WriteLine("3.Start Listing Activity");
            Console.WriteLine("4.Quit");
            Console.Write("Select a choice from the Menu: ");
            string userInput = Console.ReadLine();
            userInputInt = int.Parse(userInput);
            Console.Clear();

            if (userInputInt == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartMessage();
                Console.Clear();
                breathingActivity.Run();
            }
            else if(userInputInt == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayStartMessage();
                Console.Clear();
                reflectingActivity.Run();
            }

            else if(userInputInt == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartMessage();
                listingActivity.Run();
            }
        }
        while(userInputInt != 4);

        
    }
}
