



using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class Comment
{
    string _author;
    string _text;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetText()
    {
        return _text;
    }
}