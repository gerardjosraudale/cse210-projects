using System;
using System.Collections.Generic;

namespace FitnessCenterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating activities
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
            activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8));
            activities.Add(new StationaryBicycle(new DateTime(2022, 11, 4), 45, 20));
            activities.Add(new Swimming(new DateTime(2022, 11, 5), 60, 20));

            // Displaying summary information
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}