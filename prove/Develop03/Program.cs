class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

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
