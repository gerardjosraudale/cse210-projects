using System;
using System.Threading;

namespace MindfulnessApp
{
    class ListingActivity : MindfulnessActivity
    {
        private string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public override void Run()
        {
            Console.WriteLine("Listing Activity:");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

            duration = GetDuration();

            Console.WriteLine("Get ready to begin...");
            Thread.Sleep(3000); // Pause for 3 seconds

            Random random = new Random();

            Console.WriteLine("Start listing...");

            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            DisplayCountdown(5); // Countdown for 5 seconds

            // Collect user input
            int itemCount = 0;
            while (itemCount < duration)
            {
                Console.Write("Enter an item (or 'done' to finish): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                    break;
                itemCount++;
            }

            Console.WriteLine("You listed {0} items.", itemCount);
            Thread.Sleep(3000); // Pause for 3 seconds

            Console.WriteLine("Good job! You have completed the Listing Activity for {0} seconds.", duration);
            Thread.Sleep(3000); // Pause for 3 seconds
        }

        protected override string[] GetPrompts()
        {
            return prompts;
        }
    }
}
