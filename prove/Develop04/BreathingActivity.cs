using System;
using System.Threading;

namespace MindfulnessApp
{
    class BreathingActivity : MindfulnessActivity
    {
        public override void Run()
        {
            Console.WriteLine("Breathing Activity:");
            Console.WriteLine("This activity will help you pace your breathing for a certain amount of time.");

            duration = GetDuration();

            Console.WriteLine("Get ready to begin...");
            Thread.Sleep(3000); // Pause for 3 seconds

            Console.WriteLine("Start breathing deeply...");
            DisplayCountdown(duration);

            Console.WriteLine("Good job! You have completed the Breathing Activity for {0} seconds.", duration);
            Thread.Sleep(3000); // Pause for 3 seconds
        }

        protected override string[] GetPrompts()
        {
            return new string[0]; // No prompts for BreathingActivity
        }
    }
}
