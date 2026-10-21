
using Event_Registration.Services;
using System;

namespace Program_main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EventService es = new EventService();
            ParticipantServices ps = new ParticipantServices();
            RegistrationServices rs = new RegistrationServices();
            Reports rp = new Reports();

            rp.es = es;
            rp.ps = ps;
            rp.rs = rs;

            int ch = 0;

            while (ch != 26)
            {
                Console.WriteLine("\nEVENT REGISTRATION MANAGEMENT");
                Console.WriteLine("1. Create Event");
                Console.WriteLine("2. Display Events");
                Console.WriteLine("3. Search Event by ID");
                Console.WriteLine("4. Search Event by Name or Venue");
                Console.WriteLine("5. Update Event");
                Console.WriteLine("6. Register Participant");
                Console.WriteLine("7. Display Participants");
                Console.WriteLine("8. Search Participant by ID");
                Console.WriteLine("9. Search Participant by Name or Email");
                Console.WriteLine("10. Update Participant");
                Console.WriteLine("11. Register for Event");
                Console.WriteLine("12. Display Registrations");
                Console.WriteLine("13. Search Registration by ID");
                Console.WriteLine("14. Cancel Registration");
                Console.WriteLine("15. Mark Attendance");
                Console.WriteLine("16. Participants by Event");
                Console.WriteLine("17. Events by Participant");
                Console.WriteLine("18. Remaining Capacity");
                Console.WriteLine("19. Full Events");
                Console.WriteLine("20. Group Registrations by Event");
                Console.WriteLine("21. Payments by Event");
                Console.WriteLine("22. Overall Payments");
                Console.WriteLine("23. Attendance Count");
                Console.WriteLine("24. Attendance Percentage");
                Console.WriteLine("25. Exit");

                if (!int.TryParse(Console.ReadLine(), out ch))
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }

                switch (ch)
                {
                    case 1:
                        es.EventManagement();
                        break;

                    case 2:
                        es.Display();
                        break;

                    case 3:
                        es.DisplayByID();
                        break;

                    case 4:
                        es.Search();
                        break;

                    case 5:
                        es.Update();
                        break;

                    case 6:
                        ps.RegisterParticipant();
                        break;

                    case 7:
                        ps.DisplayParticipants();
                        break;

                    case 8:
                        ps.SearchById();
                        break;

                    case 9:
                        ps.SearchByNameOrEmail();
                        break;

                    case 10:
                        ps.UpdateParticipant();
                        break;

                    case 11:
                        rs.RegisterEvent();
                        break;

                    case 12:
                        rs.Display();
                        break;

                    case 13:
                        rs.SearchById();
                        break;

                    case 14:
                        rs.Cancel();
                        break;

                    case 15:
                        rs.MarkAttended();
                        break;

                    case 16:
                        rp.ParticipantsByEvent();
                        break;

                    case 17:
                        rp.EventsByParticipant();
                        break;

                    case 18:
                        rp.RemainingCapacity();
                        break;

                    case 19:
                        rp.FullEvents();
                        break;

                    case 20:
                        rp.GroupRegistrationsByEvent();
                        break;

                    case 21:
                        rp.PaymentsByEvent();
                        break;

                    case 22:
                        rp.OverallPayments();
                        break;

                    case 23:
                        rp.AttendanceCount();
                        break;

                    case 24:
                        rp.AttendancePercentage();
                        break;

                    case 25:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
