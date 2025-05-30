using System;

public class Comment
{
    public string _name { set; get; }
    public string _commentText { set; get; }

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }
}