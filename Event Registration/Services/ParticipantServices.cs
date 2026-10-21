using System;
using System.Collections.Generic;
using System.Text;
using Event_Registration.Models;

namespace Event_Registration.Services
{
    public class ParticipantServices
    {
        List<Participant> ParticipantRec = new List<Participant>();
        public void ParticipantRegister()
        {
            Console.WriteLine("Participant Registration");
            Console.WriteLine("Enter Participant id: ");
            int.TryParse(Console.ReadLine(), out int participantid);
            if (participantid <= 0)
            {
                Console.WriteLine("Participant ID must be positive.");
                return;
            }
            if (ParticipantRec.Any(p => p.ParticipantId == id))
            {
                Console.WriteLine("Participant ID already exists.");
                return;
            }
            Console.WriteLine("Enter Fullname");
            string? fullname = Console.ReadLine();
            Console.WriteLine("Enter email");
            string? email = Console.ReadLine();
            Console.WriteLine("Enter Phone number");
            string? phonenumber = Console.ReadLine();
            if (phonenumber.Length != 10)
            {
                Console.WriteLine("Contact Number should be 10 digits");
            }

        }
    }
}
