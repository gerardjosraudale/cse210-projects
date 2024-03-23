using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                int choice = GetChoice();

                switch (choice)
                {
                    case 1:
                        new BreathingActivity().Run();
                        break;
                    case 2:
                        new ReflectionActivity().Run();
                        break;
                    case 3:
                        new ListingActivity().Run();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
        }

        static int GetChoice()
        {
            Console.Write("Enter your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.Write("Invalid input. Enter a number between 1 and 4: ");
            }
            return choice;
        }
    }
}
