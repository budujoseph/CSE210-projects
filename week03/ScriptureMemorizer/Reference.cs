using System;

public class Reference
{
    public string Book { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; } // to accept single verses

    public Reference(string book, int startVerse)
    {
        Book = book;
        StartVerse = startVerse;
        EndVerse = null;
    }

    public Reference(string book, int startVerse, int endVerse)
    {
        Book = book;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse == null
            ? $"{Book} {StartVerse}"
            : $"{Book} {StartVerse} - {EndVerse}";
    }
}