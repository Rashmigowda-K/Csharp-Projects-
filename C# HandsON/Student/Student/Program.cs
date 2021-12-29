using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StudentDetails
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string CourseJoined { get; set;}
        public int FeePaidSoFar { get; set; }

        public double ServiceTax { get; set; }

        public double DueAmount { get; set; }

        public double Tax()
        {
            ServiceTax = 0.123;
            return ServiceTax;
        }
        public int  TotalDueAmount
        {
            get
            {
                return TotalFeeForCourse - FeePaidSoFar;
                //return DueAmount = DueAmount * ServiceTax;
            }
        }

       
        public int TotalFeeForCourse
        {
            get
            {
               // StudentDetails studentDetails = new StudentDetails();

                if (CourseJoined.ToLower() == "c#")
                    return Convert.ToInt32(2000 * ServiceTax);
                else if (CourseJoined.ToLower() == "asp.net")
                    return Convert.ToInt32(3000 * ServiceTax);
                return 0;
            }
        }

        public StudentDetails(int rollNo, string name, string courseJoined)
        {
            RollNo = rollNo;
            Name = name;
            CourseJoined = courseJoined;
        }

      
        public void Payment(int amount)
        {
            FeePaidSoFar = FeePaidSoFar + amount;
        }

        
        public void Print()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Course Joined: {CourseJoined}");
            //Console.WriteLine($"Total Fee: {TotalFeeForCourse}");
            Console.WriteLine($"Fee Paid So Far: {FeePaidSoFar}");
             Console.WriteLine($"Due Amount: {DueAmount}");
           // Console.WriteLine($"Total Fee: {TotalFee}");
        }
    }
    


       
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails RashmiStudentDetails = new StudentDetails(1, "Rashmi", "c#");
           // StudentDetails BinduStudentDetails = new StudentDetails(2, "Bindu", "ASP.NET");
            
           
            RashmiStudentDetails.Payment(200);
            RashmiStudentDetails.Payment(100);
            
            
            RashmiStudentDetails.Print();

            Console.WriteLine("\n");


           // BinduStudentDetails.Print();
        }
    }
}


