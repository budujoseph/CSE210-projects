using System;

public class Word
{
    public string Text { get; private set; }
    public bool isHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Show()
    {
        isHidden = false;
    }

    public override string ToString()
    {
        return isHidden ? " ____ " : Text;
    }
}