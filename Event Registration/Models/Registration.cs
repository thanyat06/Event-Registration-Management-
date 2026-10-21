using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Registration.Models
{
    public class Registration
    {
        public enum Status
        {
            Registered,
            Cancelled,
            Attended
        }
        public int RegistrationId { get; set; }
        public string? EventId { get; set; }
        public string? ParticipantId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public Status status { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
