using Event_Registration.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Event_Registration.Services
{
    public class EventService
    {
        List<Event> EventRec = new List<Event>();
        public void EventManagement()
        {
            Console.WriteLine("Enter details to Organize an Event");
            Console.WriteLine("Enter Eventid: ");
            int.TryParse(Console.ReadLine(), out int eventid);
            if(eventid <= 0)
            {
                Console.WriteLine("Event ID must be positive");
            }
            Console.WriteLine("Enter Event Name: ");
            string? eventname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(eventname)){
                Console.WriteLine("Enter a valid Event Name");
            }
            Console.WriteLine("Enter Venue: ");
            string? venue = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(venue)){
                Console.WriteLine("Enter a valid Event Name");
            }
            Console.WriteLine("Enter EventDate: ");
            DateTime EventDate = DateTime.Now;
            Console.WriteLine("Capacity: ");
            int.TryParse(Console.ReadLine(), out int capacity);
 
            if(capacity <= 0)
            {
                Console.WriteLine("Capacity should be positive");
            }
            Console.WriteLine("Registrtion fee");
            int.TryParse(Console.ReadLine(), out int registrationFee);

            Event newEvent = new Event(
                eventid, eventname, venue, EventDate, capacity, registrationFee);

            EventRec.Add(newEvent);

            Console.WriteLine("Event created successfully.");
        }

        public void DisplayByID()
        {
            Console.WriteLine("Enter EventId");
            int.TryParse(Console.ReadLine(), out int id);
            if (id <= 0)
            {
                Console.WriteLine("Id shouldn't be negative");
            }
            if (EventRec.Any(e => e.Eventid == id))
            {
                Console.WriteLine("ID found");
                foreach(var e in EventRec)
                {
                    Console.WriteLine("EventId: " + e.Eventid);
                    Console.WriteLine("EventName: " + e.Eventname);
                    Console.WriteLine("Venue: " + e.Venue);
                    Console.WriteLine("EventDate: "+ e.EventDate);
                    Console.WriteLine("Capacity: " + e.Capacity);
                    Console.WriteLine("Registration Fee: " + e.RegistrationFee);
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        public void Display()
        {
            if (EventRec.Count == 0) {
                Console.WriteLine("No Events Found");
            }
            foreach (var e in EventRec)
            {
                Console.WriteLine("EventId: " + e.Eventid);
                Console.WriteLine("EventName: " + e.Eventname);
                Console.WriteLine("Venue: " + e.Venue);
                Console.WriteLine("EventDate: " + e.EventDate);
                Console.WriteLine("Capacity: " + e.Capacity);
                Console.WriteLine("Registration Fee: " + e.RegistrationFee);
            }
        }

        public void Search()
        {
            Console.WriteLine("Enter event name or venue: ");
            string? key = Console.ReadLine();
            if (EventRec.Count == 0)
            {
                Console.WriteLine("List is Empty");
            }
            var res = EventRec.Where(e => e.Eventname.Contains(key) || e.Venue.Contains(key)).ToList();
            if (res.Count == 0)
            {
                Console.WriteLine("No Data matched");
            }
            else
            {
                foreach (var e in res) {
                    Console.WriteLine("EventId: " + e.Eventid);
                    Console.WriteLine("EventName: " + e.Eventname);
                    Console.WriteLine("Venue: " + e.Venue);
                    Console.WriteLine("EventDate: " + e.EventDate);
                    Console.WriteLine("Capacity: " + e.Capacity);
                    Console.WriteLine("Registration Fee: " + e.RegistrationFee);
                }
            }
        }

        public void Update()
        {
            Console.WriteLine("Enter an id to update: ");
            int.TryParse(Console.ReadLine(), out int uid);
            if (EventRec.Any(e => e.Eventid == uid))
            {
                Console.WriteLine("ID Found");

                var res = EventRec.First(e => e.Eventid == uid);
                Console.WriteLine("Updated venue: ");
                res.Venue = Console.ReadLine();
                Console.WriteLine("Updated Capacity: ");
                int.TryParse(Console.ReadLine(), out int upcap);
                res.Capacity = upcap;
                Console.WriteLine("Updated fee: ");
                int.TryParse(Console.ReadLine(), out int upfee);
                res.RegistrationFee = upfee;
            }
        }
    }
}
