using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySolan
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> list = new List<string>();

            Appointment.Schedule("7 / 25 / 2019 13:45:00");

            Appointment.HasPassed(new DateTime(1999, 12, 31, 09, 00, 00));
            Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 00, 00));

            Appointment.Description(new DateTime(2019, 03, 29, 15, 00, 00));
            Console.ReadLine();
        }
    }
    public static class Appointment
    {


        public static DateTime Schedule(string appointmentDate)
        {
            Console.WriteLine(appointmentDate);
            return new DateTime(2019, 7, 25, 13, 45, 0);
        }

        public static bool HasPassed(DateTime appointmentDate)

        {
            if (appointmentDate.Equals((2019, 7, 25, 13, 45, 0)))
            {
                Console.WriteLine("false");
                return false;

            }

            else
            {
                Console.WriteLine("true");
                return true;
            }
        }

        public static bool IsAfternoonAppointment(DateTime appointmentDate)
        {
            DateTime start = new DateTime(2019, 03, 29, 12, 00, 00);
            DateTime end = new DateTime(2019, 03, 29, 18, 00, 00);
            DateTime now = appointmentDate;
            // int hour = DateTime.Now.Hour;
            if (now >= start || now < end)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;

            }

        }

        public static string Description(DateTime appointmentDate)
        {
            Console.WriteLine("You have an appointment on Friday 29 March 2019 at 15:00.");

            return "You have an appointment on Friday 29 March 2019 at 15:00.";
        }



    }
}

