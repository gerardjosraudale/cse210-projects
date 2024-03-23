using System;
using System.Threading;

namespace MindfulnessApp
{
    class ReflectionActivity : MindfulnessActivity
    {
        private string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public override void Run()
        {
            Console.WriteLine("Reflection Activity:");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            duration = GetDuration();

            Console.WriteLine("Get ready to begin...");
            Thread.Sleep(3000); // Pause for 3 seconds

            Random random = new Random();

            Console.WriteLine("Think deeply about the experience...");

            for (int i = 0; i < duration;)
            {
                string prompt = prompts[random.Next(prompts.Length)];
                Console.WriteLine(prompt);
                DisplaySpinner(3); // Pause for 3 seconds

                foreach (string question in questions)
                {
                    Console.WriteLine(question);
                    Thread.Sleep(5000); // Pause for 5 seconds
                }

                i += 8; // Each iteration presents 8 questions
            }

            Console.WriteLine("Good job! You have completed the Reflection Activity for {0} seconds.", duration);
            Thread.Sleep(3000); // Pause for 3 seconds
        }

        protected override string[] GetPrompts()
        {
            return prompts;
        }
    }
}
