using System;
using System.Runtime.InteropServices;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetCommentNum()
    {
        return comments.Count;
    }

    public void InsertComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }

    public void DisplayComments()
    {
        foreach (Comment com in comments)
        {
            Console.WriteLine($"{com.GetName()} wrote:\n {com.GetText()}");
        }
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }
}