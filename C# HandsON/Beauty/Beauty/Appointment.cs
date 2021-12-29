using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty
{
     static class Appointment
    {
               public static DateTime Schedule(string appointmentDateDescription)
                 {
                    //return DateTime.Parse(appointmentDateDescription);
                    throw new NotImplementedException("please implement the (static)Appointment.Schedule() ");
                 }

               public static bool HasPassed(DateTime appointmentDate)
                 {
                  // return DateTime.Now > appointmentDate;
                  throw new NotImplementedException("please implement the (static)Appointment.HasPassed() ");
                 }

               public static bool AfternoonAppointment(DateTime appointmentDate)
                 {
                   // return appointmentDate.Hour is >=
                    throw new NotImplementedException("please implement the (static)Appointment.AfternoonAppointment() ");
                 }

               public static string Description(DateTime appointmentDate)
                 {
                  //  return $"You have an appointment on {appointmentDate:M/d/yyyy h:mm:ss tt}.";
                   throw new NotImplementedException("please implement the (static)Appointment.Description() ");
                 }

               public static DateTime AnniversaryDate()
                 {
                   // return new DateTime(DateTime.Now.Year);
                  throw new NotImplementedException("please implement the (static)Appointment.AnniversaryDate() ");
                 }

        static void Main()
        {
            Console.WriteLine("Appointment.Schedule()" + Appointment.Schedule( 7 / 25 / 2019 13:45:00));
        }


     }
}
