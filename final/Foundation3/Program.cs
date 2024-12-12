using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "Cityville", "State", "12345");
        Address receptionAddress = new Address("456 Elm St", "Townsville", "State", "67890");
        Address outdoorAddress = new Address("789 Oak St", "Villageville", "State", "11223");

        Lecture lecture = new Lecture("Tech Talk", "A talk on technology", "2024-12-20", "10:00 AM", lectureAddress, "John Doe", 100);
        Reception reception = new Reception("Wedding Reception", "Join us for a celebration", "2024-12-21", "6:00 PM", receptionAddress, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "A day at the park", "2024-12-22", "12:00 PM", outdoorAddress, "Sunny");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event e in events)
        {
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------/n");
        }
    }
}
