using System;
using System.Collections.Generic;

public class Video
{
    public string _title{ set; get; }
    public string _author{ set; get; }
    public int _commentLength{ set; get; }
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int commentLength)
    {
        _title = title;
        _author = author;
        _commentLength = commentLength;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_commentLength}");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
        Console.WriteLine("Comments: ");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"\t{comment._name} : {comment._commentText}");
        }
    }
}