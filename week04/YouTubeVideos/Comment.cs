using System;

public class Comment
{
    public string Name { set; get; }
    public string CommentText { set; get; }

    public Comment(string name, string commentText)
    {
        Name = name;
        CommentText = commentText;
    }
}