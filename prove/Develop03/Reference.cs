public class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

    /// <summary>
    /// Constructor for Reference class.
    /// </summary>
    /// <param name="book">The name of the book.</param>
    /// <param name="chapter">The chapter number.</param>
    /// <param name="startVerse">The starting verse number.</param>
    /// <param name="endVerse">The ending verse number.</param>
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    /// <summary>
    /// Overrides the ToString method to return the reference string.
    /// </summary>
    /// <returns>The reference string.</returns>
    public override string ToString()
    {
        if (StartVerse == EndVerse)
            return $"{Book} {Chapter}:{StartVerse}";
        else
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}
