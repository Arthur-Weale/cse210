using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity: Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }

    public void Run()
    {
        Console.WriteLine("Get Ready......");
        ShowSpinner();
        Console.WriteLine();
        //DurationCountdownTimer();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        
        DisplayQuestions();
        Console.WriteLine();
        DisplayEndMessage();
    }

    public string  GetRandomPrompt()
    {
        Random random = new Random();
        int randomPromptInt = random.Next(_prompts.Count);
        return _prompts[randomPromptInt];
    }
    public string  GetRandomQuestion()
    {
        Random random = new Random();
        int randomQueInt = random.Next(_questions.Count);
        return _questions[randomQueInt];
    }
    public void DisplayPrompt()
    {
        
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("When you have something in your mind, press enter to continue.");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Now Ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.Clear();
    }
    public void DisplayQuestions()
    {
        DateTime startTimeCount = DateTime.Now;
        DateTime newCountTime = startTimeCount.AddSeconds(_duration);
        while(DateTime.Now < newCountTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner();
            Console.WriteLine();
        }
    }
} 