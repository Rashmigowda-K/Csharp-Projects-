using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails RashmiStudentDetails = new StudentDetails(1, "Rashmi", "c#");
            StudentDetails BinduStudentDetails = new StudentDetails(2, "bindu", "ASP.NET");

            
            RashmiStudentDetails.Payment(500);
            BinduStudentDetails.Payment(1000);

            RashmiStudentDetails.Print();

            Console.WriteLine("\n");


            BinduStudentDetails.Print();
        }
    }
}
