



public class Video
{
    string _author ;
    string _title;
    int _length;

    List<Comment> _comments = new List<Comment>();


    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public int GetLength()
    {
        return _length;
    }

    public void AddComment(Comment comments)
    {
        _comments.Add(comments);
        
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Author: {GetAuthor()}");
        Console.WriteLine($"Length: {GetLength()}");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.GetAuthor()}: {comment.GetText()}");
        }
        Console.WriteLine();
    }
}