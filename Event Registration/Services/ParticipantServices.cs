using System;
using System.Collections.Generic;
using System.Text;
using Event_Registration.Models;

namespace Event_Registration.Services
{
    public class ParticipantServices
    {
        List<Participant> ParticipantRec = new List<Participant>();

        public void RegisterParticipant()
        {
            Console.WriteLine("Welcome to Participant Registration");
            Console.Write("Enter Participant ID: ");
            int.TryParse(Console.ReadLine(), out int participantid);
            if (participantid <= 0)
            {
                Console.WriteLine("Participant ID must be positive.");
                return;
            }

            if (ParticipantRec.Any(p => p.ParticipantId == participantid))
            {
                Console.WriteLine("Participant ID already exists.");
                return;
            }

            Console.Write("Enter Full Name: ");
            string? fullname = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fullname))
            {
                Console.WriteLine("Name cannot be empty.");
                return;
            }

            Console.Write("Enter Email: ");
            string? email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Email cannot be empty.");
                return;
            }

            if (ParticipantRec.Any(p =>
                p.Email == email))
            {
                Console.WriteLine("Email already exists.");
            }

            Console.Write("Enter Phone Number: ");
            string? ph = Console.ReadLine();
            if (ph.Length != 10)
            {
                Console.WriteLine(
                    "Phone number must contain 10 digits");
            }
            int phonenumber = int.Parse(ph);

            Participant participant =
                new Participant(participantid, fullname, email, phonenumber);

            ParticipantRec.Add(participant);
            Console.WriteLine("Participant registered successfully.");
        }

        public void DisplayParticipants()
        {
            if (ParticipantRec.Count == 0)
            {
                Console.WriteLine("No participants found.");
            }
            foreach (var p in ParticipantRec)
            {
                Console.WriteLine("Participants List");
                Console.WriteLine("Participant ID: " + p.ParticipantId);
                Console.WriteLine("Full Name: " + p.FullName);
                Console.WriteLine("Email: " + p.Email);
                Console.WriteLine("Phone Number: " + p.Phonenumber);
            }
        }

        public void SearchById()
        {
            Console.Write("Enter Participant ID to search: ");
            int.TryParse(Console.ReadLine(), out int id);
            if (ParticipantRec.Any(p => p.ParticipantId == id))
            {
                Console.WriteLine("Participant Found!");

                foreach (var p in ParticipantRec)
                {
                    if (p.ParticipantId == id)
                    {
                        Console.WriteLine("Participant ID: " + p.ParticipantId);
                        Console.WriteLine("Full Name: " + p.FullName);
                        Console.WriteLine("Email: " + p.Email);
                        Console.WriteLine("Phone Number: " + p.Phonenumber);
                    }
                }
            }
            else
            {
                Console.WriteLine("Participant not found.");
            }

        }

        public void SearchByNameOrEmail()
        {
            Console.Write("Enter Participant Name or Email: ");
            string? key = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(key))
            {
                Console.WriteLine("Search input cannot be empty.");
            }
            var res = ParticipantRec.Where(p =>
                p.FullName.Contains(key,
                    StringComparison.OrdinalIgnoreCase) ||
                p.Email.Contains(key,
                    StringComparison.OrdinalIgnoreCase)).ToList();
            if (res.Count == 0)
            {
                Console.WriteLine("No participants found");
            }
            foreach (var p in res)
            {
                Console.WriteLine("Searched Detail: ");
                Console.WriteLine("Participant ID: " + p.ParticipantId);
                Console.WriteLine("Full Name: " + p.FullName);
                Console.WriteLine("Email: " + p.Email);
                Console.WriteLine("Phone Number: " + p.Phonenumber);
            }
        }

        public void UpdateParticipant()
        {
            Console.Write("Enter Participant ID to update: ");
            int.TryParse(Console.ReadLine(), out int id);

            Console.Write("Enter New Full Name: ");
            string? name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty.");
            }

            Console.Write("Enter New Email: ");
            string? email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Email cannot be empty.");
            }

            if (ParticipantRec.Any(p =>
                p.ParticipantId != id &&
                p.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Email already exists.");
            }

            Console.Write("Enter New Phone Number: ");
            string? con = Console.ReadLine();
            int.TryParse(con, out int contact);
            if (string.IsNullOrWhiteSpace(con))
            {
                Console.WriteLine("Phone number cannot be empty.");
                return;
            }
            if (con.Length != 10)
            {
                Console.WriteLine(
                    "Phone number must contain 10 digits");
            }

            foreach (var p in ParticipantRec)
            {
                if (p.ParticipantId == id)
                {
                    p.FullName = name;
                    p.Email = email;
                    p.Phonenumber = contact;
                    break;

                }
            }

            Console.WriteLine("Participant updated successfully.");
        }
    }
}