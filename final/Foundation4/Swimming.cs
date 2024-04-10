using System;

namespace FitnessCenterApp
{
    // Derived class for Swimming activity
    public class Swimming : Activity
    {
        private int laps;

        // Constructor
        public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
        {
            this.laps = laps;
        }

        // Override GetDistance method
        public override double GetDistance()
        {
            return laps * 50 / 1000.0;
        }

        // Override GetSpeed method
        public override double GetSpeed()
        {
            return GetDistance() / (lengthInMinutes / 60.0);
        }

        // Override GetPace method
        public override double GetPace()
        {
            return lengthInMinutes / GetDistance();
        }

        // Override GetSummary method
        public override string GetSummary()
        {
            return base.GetSummary() + $" - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
        }
    }
}