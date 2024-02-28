using System;


class Program
{
    static void Main(string[] args)
    {
          Console.WriteLine("Welcome to the Guess My Number game!");

        // Ask the user for the magic number
        //Console.Write("What is the magic number? ");
        //int magicNumber = Convert.ToInt32(Console.ReadLine());

          // For Part 3, where we use a random number
         Random randomGenerator = new Random();
         int magicNumber = randomGenerator.Next(1, 101);

        // Loop until the user guesses the magic number
        while (true)
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            int guess = Convert.ToInt32(Console.ReadLine());

            // Determine if the guess is higher, lower, or correct
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                break; // Exit the loop when the user guesses the magic number
            }
        }
    }
}