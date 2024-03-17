using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private readonly Reference reference;
    private readonly List<Word> words;

    /// <summary>
    /// Constructor for Scripture class.
    /// </summary>
    /// <param name="reference">The reference for the scripture.</param>
    /// <param name="text">The text of the scripture.</param>
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    /// <summary>
    /// Displays the scripture, hiding any words marked as hidden.
    /// </summary>
    public void Display()
    {
        Console.WriteLine(reference);
        foreach (Word word in words)
        {
            if (word.IsHidden)
                Console.Write(new string('*', word.Text.Length) + " ");
            else
                Console.Write(word.Text + " ");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Hides a random selection of words in the scripture.
    /// </summary>
    public void HideWords()
    {
        Random random = new Random();
        int numToHide = random.Next(1, words.Count(w => !w.IsHidden));
        int hiddenCount = 0;
        foreach (Word word in words)
        {
            if (!word.IsHidden)
            {
                if (hiddenCount < numToHide)
                {
                    word.IsHidden = true;
                    hiddenCount++;
                }
                else
                {
                    break;
                }
            }
        }
    }

    /// <summary>
    /// Checks if all words in the scripture are hidden.
    /// </summary>
    /// <returns>True if all words are hidden, otherwise false.</returns>
    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
}
