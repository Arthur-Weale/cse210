
using System;

public class Entry 
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} | {_promptText} | {_entryText}");
    }
}
