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
        Console.WriteLine();
        InspirationalMessages();
        ShowSpinner();
    }
    public void ShowSpinner()
    {
        List<string> spinnerSticks = new List<string>{
            "|","/", "-", "\\" 
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;
        while(DateTime.Now < endTime)
        {
            string stick = spinnerSticks[i];
            Console.Write($"\r{stick}");
            Thread.Sleep(100);

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


    //Exceeding Requirements 

    public void InspirationalMessages()
    {
        List<string> mindfulnessMessages = new List<string>
            {
                "Be present in every moment, for it is the only moment you truly have.",
                "Mindfulness is the art of being fully present, aware, and connected to the now.",
                "Inhale peace, exhale stress. Mindfulness is the path to clarity and calm.",
                "You are enough. Breathe, center, and embrace this moment.",
                "Let go of what you can't control, and focus on what you can. This moment is yours.",
                "Every breath you take is a chance to reconnect with yourself.",
                "Find stillness in the present. The past is gone, the future is not here, but the now is all you need.",
                "Mindfulness is not about escaping the world, but about being fully engaged in it.",
                "Allow yourself to pause, breathe, and simply be.",
                "The present moment is the only place where true peace can be found.",
                "Step back from the noise of the world, and listen to the silence within.",
                "Each breath is a reminder to be gentle with yourself.",
                "Let your mind be like a clear sky, free from the clutter of unnecessary thoughts.",
                "Awaken to the beauty in every moment, and embrace the journey within.",
                "The more you practice mindfulness, the more you realize that peace is always within reach."
            };

        Random random = new Random();
        int randomInt = random.Next(mindfulnessMessages.Count);
        Console.WriteLine(mindfulnessMessages[randomInt]);
    }

    // public void DurationCountdownTimer()
    // {
    //     for(int i = _duration; i > 0; i--)
    //     {
    //         Console.WriteLine(i);
    //         Thread.Sleep(1000);
    //         Console.Write("\b \b");
    //     }
    // }

}