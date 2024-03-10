using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal(); // Initialize a new journal
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        string[] prompts = {
                            "Who was the most interesting person I interacted with today?",
                            "What was the best part of my day?",
                            "How did I see the hand of the Lord in my life today?",
                            "What was the strongest emotion I felt today?",
                            "If I had one thing I could do over today, what would it be?"
                        };

                        string prompt = prompts[random.Next(prompts.Length)]; // Choose a random prompt
                        Console.WriteLine(prompt);
                        Console.Write("Enter your response: ");
                        string response = Console.ReadLine();
                        journal.AddEntry(new Entry(prompt, response, DateTime.Now.ToString())); // Create a new entry with the current date
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine("Journal Entries:");
                        journal.DisplayEntries(); // Display all entries in the journal
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.Write("Enter the file name to save: ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToFile(saveFileName); // Save the journal to a file
                        Console.WriteLine("Journal saved to file.\n");
                        break;

                    case "4":
                        Console.Write("Enter the file name to load: ");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromFile(loadFileName); // Load the journal from a file
                        Console.WriteLine("Journal loaded from file.\n");
                        break;

                    case "5":
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose again.\n");
                        break;
                }
            }
        }
    }
}
