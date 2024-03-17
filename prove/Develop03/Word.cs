public class Word
{
    public string Text { get; }
    public bool IsHidden { get; set; }

    /// <summary>
    /// Constructor for Word class.
    /// </summary>
    /// <param name="text">The text of the word.</param>
    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }
}

