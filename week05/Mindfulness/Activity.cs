public class Activity
{
    private string _name;
    private string _descritption;
    private int _duration;

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
    }
    public void DisplayEndMessage()
    {

    }
    public void ShowSpinner()
    {

    }
    public void ShowCountDown()
    {

    }
}