using System;
using System.Collections.Generic;

public class Video
{
    public string Title{ set; get; }
    public string Author{ set; get; }
    public int CommentLength{ set; get; }
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int commentLength)
    {
        Title = title;
        Author = author;
        CommentLength = commentLength;
    }


    public int NumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {CommentLength}");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
        Console.WriteLine("Comments: ");
        foreach(Comment comment in comments)
        {
            Console.WriteLine($"\t{comment.Name} : {comment.CommentText}");
        }
    }
}