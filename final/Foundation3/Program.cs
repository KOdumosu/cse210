
using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress = new Address("851 Main St, New York" "NY 10044,", "USA");
        LectureEvent lectureEvent = new LectureEvent("Tech Talk", "Exciting tech discussions", DateTime.Now, DateTime.Now.AddHours(2), eventAddress, "Daniel Hassan", 150);
        ReceptionEvent receptionEvent = new ReceptionEvent("Networking Night", "Networking event with professionals", DateTime.Now.AddDays(7), DateTime.Now.AddHours(3), eventAddress, "event@rsvpmail.com");
        OutdoorEvent outdoorEvent = new OutdoorEvent("Summer Picnic", "Enjoy the outdoors with friends", DateTime.Now.AddDays(14), DateTime.Now.AddHours(4), eventAddress, "Sunny with a chance of rain");

        // Display marketing messages for each event
        Console.WriteLine("Marketing Messages:\n");

        Console.WriteLine("Lecture Event:");
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
