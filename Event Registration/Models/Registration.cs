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
        public int EventId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public Status status { get; set; }
        public decimal AmountPaid { get; set; }
        public Registration(int registrationid, int eventid, int participantid, DateTime registrationdate, Status sts, decimal amountpaid)
        {
            RegistrationId = registrationid;
            EventId = eventid;
            ParticipantId = participantid;
            RegistrationDate = registrationdate;
            status = sts;
            AmountPaid = amountpaid;
        }
    }
}
