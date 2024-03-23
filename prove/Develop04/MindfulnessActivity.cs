using System;
using System.Threading;

namespace MindfulnessApp
{
    abstract class MindfulnessActivity
    {
        protected int duration;

        protected abstract string[] GetPrompts();

        public abstract void Run();

        protected int GetDuration()
        {
            Console.Write("Enter the duration of the activity in seconds: ");
            while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
            }
            return duration;
        }

        protected void DisplayCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine("Time remaining: {0} seconds", i);
                Thread.Sleep(1000); // Pause for 1 second
            }
        }

        protected void DisplaySpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("\b/"); Thread.Sleep(100);
                Console.Write("\b-"); Thread.Sleep(100);
                Console.Write("\b\\"); Thread.Sleep(100);
                Console.Write("\b|"); Thread.Sleep(100);
            }
        }
    }
}
