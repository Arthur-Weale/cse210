using System;

class Program
{
    static void Main(string[] args)
    {

        //*****As for a stretch challenge, the program reports when the scripture is completely hidden.*******

        // Step 1: Create a reference.
        Reference reference = new Reference("John", 3, 16);

        // Step 2: Create a scripture object with the reference and text.
        string scriptureText = "For God so loved the world that he gave his only Son, that whoever believes in him should not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // Step 3: Display the scripture initially.
        Console.WriteLine("Initial Scripture:");
        Console.WriteLine(scripture.GetDisplayText(1));
        Console.WriteLine();

        // Step 4: Hide words step by step, waiting for user input each time.
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press any key to hide more words...");
            Console.ReadKey(); // Waits for user input before proceeding

            scripture.HideRandomWords(1);  // Hide 1 word at a time.
            Console.Clear(); // Clears the console for a cleaner output
            Console.WriteLine(scripture.GetDisplayText(1));
            Console.WriteLine();
        }

        // Final message when all words are hidden.
        Console.WriteLine("The scripture is now completely hidden!");
    }
}
