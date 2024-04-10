using System;

namespace FitnessCenterApp
{
    // Derived class for Stationary Bicycle activity
    public class StationaryBicycle : Activity
    {
        private double speed;

        // Constructor
        public StationaryBicycle(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
        {
            this.speed = speed;
        }

        // Override GetSpeed method
        public override double GetSpeed()
        {
            return speed;
        }

        // Override GetPace method
        public override double GetPace()
        {
            return 60.0 / speed;
        }

        // Override GetSummary method
        public override string GetSummary()
        {
            return base.GetSummary() + $" - Speed: {speed} mph, Pace: {GetPace()} min per mile";
        }
    }
}
