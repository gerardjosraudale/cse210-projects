using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to gather numbers
        while (true)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num == 0)
                break; // Exit the loop if user enters 0
            
            numbers.Add(num);
        }

        // Calculate sum
        int sum = numbers.Sum();

        // Calculate average
        double average = numbers.Average();

        // Find maximum
        int max = numbers.Max();

        // Output results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}