using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitWords = text.Split(" ");
        foreach (var word in splitWords)
        {
            _words.Add(new Word(word));
        }

    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.ToString());
        foreach (var word in _words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    public void HideWords(int numberToHide)
    {
        int hideCount = 0;
        List<int> unHiddenIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].isHidden)
            {
                unHiddenIndexes.Add(i);
            }
        }

        numberToHide = Math.Min(numberToHide, unHiddenIndexes.Count);

        while (hideCount < numberToHide && unHiddenIndexes.Count > 0)
        {
            int randomIndex = _random.Next(unHiddenIndexes.Count);
            int wordIndex = unHiddenIndexes[randomIndex];

            _words[wordIndex].Hide();
            unHiddenIndexes.RemoveAt(randomIndex);
            hideCount++;
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden)
            {
                return false;
            }
        }

        return true;
    }

}