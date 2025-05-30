using System;
using System.Collections.Generic;

public class Video
{
    public string _Title{ set; get; }
    public string _Author{ set; get; }
    public int _CommentLength{ set; get; }
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int commentLength)
    {
        _Title = title;
        _Author = author;
        _CommentLength = commentLength;
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
        Console.WriteLine($"Title: {_Title}");
        Console.WriteLine($"Author: {_Author}");
        Console.WriteLine($"Length: {_CommentLength}");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
        Console.WriteLine("Comments: ");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"\t{comment._name} : {comment._commentText}");
        }
    }
}