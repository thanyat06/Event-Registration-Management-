using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Registration.Models
{
    public class Event
    {
        public int Eventid {  get; set; }
        public string? Eventname { get; set; }
        public string? Venue { get; set; }
        public DateTime? EventDate { get; set; }
        public int Capacity { get; set; }
        public decimal RegistrationFee { get; set; }

        public Event(int eventid, string? eventname, string? venue, DateTime? eventDate, int capacity, decimal registrationFee)
        {
            Eventid = eventid;
            Eventname = eventname;
            Venue = venue;
            EventDate = eventDate;
            Capacity = capacity;
            RegistrationFee = registrationFee;
        }
    }
}
