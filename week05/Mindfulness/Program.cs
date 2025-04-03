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
                // Activity activity = new Activity("Breathing", "help you relax by walking your breathing in and out slowly. Clear your mind and focus your breathing");
                // activity.DisplayStartMessage();
                // string duration = Console.ReadLine();
                // durationTime = int.Parse(duration);

                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartMessage();
                Console.Clear();
                breathingActivity.Run();
            }
        }
        while(userInputInt != 4);

        
    }
}
