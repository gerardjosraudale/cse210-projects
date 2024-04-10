using System;

namespace FitnessCenterApp
{
    // Base Activity class
    public class Activity
    {
        // Attributes shared among all activities
        private DateTime date;
        protected int lengthInMinutes; // Change access modifier to protected

        // Constructor
        public Activity(DateTime date, int lengthInMinutes)
        {
            this.date = date;
            this.lengthInMinutes = lengthInMinutes;
        }

        // Virtual methods for getting distance, speed, and pace
        public virtual double GetDistance()
        {
            return 0; // Default implementation, overridden in derived classes
        }

        public virtual double GetSpeed()
        {
            return 0; // Default implementation, overridden in derived classes
        }

        public virtual double GetPace()
        {
            return 0; // Default implementation, overridden in derived classes
        }

        // GetSummary method to produce a string with all the summary information
        public virtual string GetSummary()
        {
            return $"{date.ToString("dd MMM yyyy")} - {lengthInMinutes} min";
        }
    }
}
