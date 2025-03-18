using System.IO;

public class Journal 
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry ()   //(newEntry : Entry)
    {
        PromptGenerator promptGen = new PromptGenerator();
        // Get the prompt only once so we use the same value for both displaying and storing.
        string prompt = promptGen.GetPrompt();
        Console.WriteLine("Prompt: " + prompt);
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry();
        entry._promptText = prompt;
        entry._entryText = response;
        // The _date field in Entry is already set upon creation

        _entries.Add(entry);
        Console.WriteLine("Entry added successfully!");
    }
    public void DisplayAll ()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
            return;
        }

        foreach(Entry entry in  _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string fileName)
{
    if (string.IsNullOrWhiteSpace(fileName))
    {
        Console.WriteLine("Error: The file name cannot be empty or null.");
        return;
    }

    // Ensure filename has a valid path
    if (!Path.IsPathRooted(fileName))
    {
        fileName = Path.Combine(Environment.CurrentDirectory, fileName);
    }

    Console.WriteLine($"Saving to: {fileName}"); // Debugging: Check the actual path

    string directory = Path.GetDirectoryName(fileName);
    if (!string.IsNullOrWhiteSpace(directory) && !Directory.Exists(directory))
    {
        Directory.CreateDirectory(directory);
    }

    try
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("Warning: No entries found. The file may be empty.");
            }

            foreach (Entry entry in _entries)
            {
                Console.WriteLine("Writing entry: " + entry._entryText);
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

        Console.WriteLine($"✅ Journal saved successfully to {fileName}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Error saving file: {ex.Message}");
    }
}

    public void LoadFromFile (string fileName)  //(file : string)
    {
    if (!File.Exists(fileName))
    {
        Console.WriteLine("File not found.");
        return;
    }

    string[] lines = File.ReadAllLines(fileName);
    _entries.Clear();  // Clear existing entries before loading

    foreach (string line in lines)
    {
        string[] parts = line.Split('|'); 
        if (parts.Length == 3)
        {
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);  //Restore entry to journal 
        }
    }
}
}