using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string city;
            int age;
            int pin;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your City");
            city = Console.ReadLine();

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your pin");
            pin = Convert.ToInt32(Console.ReadLine());

            
           
            Console.WriteLine("Your Complete Address:");
            

            Console.WriteLine("Name = {0}", name);
            Console.WriteLine("City = {0}", city);
            Console.WriteLine("Age = {0}", age);
            Console.WriteLine("Pin = {0}", pin);
            

            Console.ReadLine();



        }
    }
}
