using System.Data;

public class Activity
{
    protected string _name;
    protected string _descritption;
    protected int _duration;

    public Activity(string name, string descritption)
    {
        _name = name;
        _descritption = descritption;
        //_duration = duration;
    }


    public int SetDuration(int duration)
    {
        return _duration = duration; //For now i put return
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine($"This activity will {_descritption}. ");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        string durationInput = Console.ReadLine();
        _duration = int.Parse(durationInput);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well Done");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of another {_name} Activity");
        ShowSpinner();
        
    }
    public void ShowSpinner()
    {
        List<string> spinnerSticks = new List<string>{
            "|","/", "-", "\\" 
        };

        // foreach(string stick in spinnerSticks)
        // {
        //     Console.Write(stick);
        //     Thread.Sleep(1000);
        //     Console.WriteLine("/b /b");
        // }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;
        while(DateTime.Now < endTime)
        {
            string stick = spinnerSticks[i];
            Console.Write($"\r{stick}");
            Thread.Sleep(100);
            // Console.Write("/b /b");

            i++;

            if(i >= spinnerSticks.Count)
            {
                i = 0;
            }
        }
        Console.Write("\r "); // Overwrite the last spinner item with an empty space
        Console.WriteLine();
    }
    public void ShowCountDown()
    {
        for(int i = 5;i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}