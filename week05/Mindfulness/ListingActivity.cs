public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts = new List<string>();

    public ListingActivity(): base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        //_count = Count;
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    } 

    public void Run()
    {
        Console.WriteLine("Get Ready......");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompts: ");
        GetRandomPrompt();

        List<string> userResponses = GetListFromUser();
        Console.WriteLine($"You listed {userResponses.Count} items!");

        Console.WriteLine();  // One blank line
        Console.WriteLine();  // Two blank lines
        DisplayEndMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random(); 
        int randomIntItem = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[randomIntItem]);
        Console.Write("You may Begin in.....");
        ShowCountDown();
        
    }

    public List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        DateTime startTimeCount = DateTime.Now;
        DateTime newCountTime = startTimeCount.AddSeconds(_duration);

        while(DateTime.Now < newCountTime)
        {
            string userInput = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(userInput))
            {
                listFromUser.Add(userInput);
            }
        }
        return listFromUser;
    }
}