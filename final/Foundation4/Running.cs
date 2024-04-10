using System;

namespace FitnessCenterApp
{
    // Derived class for Running activity
    public class Running : Activity
    {
        private double distance;

        // Constructor
        public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
        {
            this.distance = distance;
        }

        // Override GetDistance method
        public override double GetDistance()
        {
            return distance;
        }

        // Override GetSpeed method
        public override double GetSpeed()
        {
            return distance / (lengthInMinutes / 60.0);
        }

        // Override GetPace method
        public override double GetPace()
        {
            return lengthInMinutes / distance;
        }

        // Override GetSummary method
        public override string GetSummary()
        {
            return base.GetSummary() + $" - Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        }
    }
}
