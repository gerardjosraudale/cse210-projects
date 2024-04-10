using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address { Street = "123 Lecture St", City = "Cityville", State = "Stateville", ZipCode = "12345" };
        Address receptionAddress = new Address { Street = "456 Reception St", City = "Townsville", State = "Stateville", ZipCode = "67890" };
        Address outdoorAddress = new Address { Street = "789 Outdoor St", City = "Villageton", State = "Stateville", ZipCode = "54321" };

        Lecture lectureEvent = new Lecture("Learn Programming", "Introduction to C#", new DateTime(2024, 4, 10), "10:00 AM", lectureAddress, "John Doe", 50);
        Reception receptionEvent = new Reception("Networking Mixer", "Meet and greet with professionals", new DateTime(2024, 4, 12), "6:00 PM", receptionAddress, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Picnic in the Park", "Fun day out with family and friends", new DateTime(2024, 4, 15), "12:00 PM", outdoorAddress, "Sunny skies");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.StandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lectureEvent.FullDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.FullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.FullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(lectureEvent.ShortDescription());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.ShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.ShortDescription());
    }
}
