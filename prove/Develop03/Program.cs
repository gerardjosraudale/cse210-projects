class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3, 7, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.");

        // Display full scripture at the beginning
        Console.WriteLine("Full Scripture:");
        scripture.Display();
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideWords();
            Console.Clear();

            // Display full scripture after hiding words
            Console.WriteLine("Updated Scripture:");
            scripture.Display();
            Console.WriteLine();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Program ending.");
                break;
            }
        }
    }
}
