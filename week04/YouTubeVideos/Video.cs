using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public int commentNumber()
    {

        return _comments.Count;

    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"{_title}: by {_author}: with a length of {_length} seconds");
        Console.WriteLine($"{_comments.Count} comments.");
        foreach (Comment com in _comments)
        {
            com.DisplayAll();
        }
    }
}