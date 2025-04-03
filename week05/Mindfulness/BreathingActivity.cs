public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding your breathing.")
    {
        
    }

    public void Run()
    {
        
        Console.WriteLine("Get Ready......");
        ShowSpinner();
        Console.WriteLine();
        //DurationCountdownTimer();
        Console.WriteLine();
        DateTime startTimeCount = DateTime.Now;
        DateTime newCountTime = startTimeCount.AddSeconds(_duration);
        while(DateTime.Now < newCountTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown();
            
            Console.WriteLine();  // One blank line
            Console.WriteLine();  // Two blank lines

            Console.Write("Now Breathe out...");
            ShowCountDown();
            
            Console.WriteLine();  // One blank line
            Console.WriteLine();  // Two blank lines
        }

        DisplayEndMessage();
    }
}