public class Scripture 
{
    private Reference _reference ;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference , string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords (int numberToHide)
    {
        Random rand = new Random();
        var hiddenWords = _words.Where(w => !w.IsHidden()).ToList(); // Only visible words.

        for (int i = 0; i < numberToHide && hiddenWords.Count > 0; i++)
        {
            int index = rand.Next(hiddenWords.Count); // Pick a random word.
            hiddenWords[index].Hide(); // Hide it.
            hiddenWords.RemoveAt(index); // Remove it to avoid picking it again.
        }
    }
    public string GetDisplayText (int numberToHide)
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordsText}";
    }
    public bool IsCompletelyHidden ()
    {
        return _words.All(w => w.IsHidden()); // All words should be hidden.
    }
}