using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Registration.Models
{
    public class Participant
    {
        public int ParticipantId { get; set; }
        public string? FullName { get; set; }
        public string? Email {  get; set; }
        public int Phonenumber { get; set; }

        public Participant(int participantId, string? fullName, string? email, int phonenumber)
        {
            ParticipantId = participantId;
            FullName = fullName;
            Email = email;
            Phonenumber = phonenumber;
        }
    }
}
