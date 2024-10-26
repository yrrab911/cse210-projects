using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.Display());
        foreach (Word word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        var unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();
        int wordsToHide = Math.Min(3, unhiddenWords.Count);

        for (int i = 0; i <= wordsToHide; i++)
        {
            int randomIndex = random.Next(unhiddenWords.Count);
            Word wordToHide = unhiddenWords[randomIndex];
            wordToHide.Hide();
            unhiddenWords.RemoveAt(randomIndex);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
