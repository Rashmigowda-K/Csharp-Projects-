using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAssemble
{
    class Program
    {
        static int AssemblyLineSuccessRate(int n) 
        {
            if (n == 0)
            {
                Console.WriteLine(" success rate is");
                double i = 0;
                return (int)i;
            }
            else if (n <= 4)
            {
                Console.WriteLine("success rate");
                double i = 1.00;
                Console.WriteLine(i);
                return (int)i;
            }


            else if (n <= 8)
            {
                Console.WriteLine("sucess rate");
                double i = 0.90;
                Console.WriteLine(i);
                return (int)i;
            }

            else if (n == 9)
            {
                Console.WriteLine("80% sucess rate");
                double i = 0.80;
                Console.WriteLine(i);
                return (int)i;
            }
            else
            {
                Console.WriteLine(" sucess rate");
                double i = 0.77;
                Console.WriteLine(i);
                return (int)i;
            }
        }
        static int AssemblyLineProductionRatePerHor(int n)
        {
            double rate = n * 221;
            Console.WriteLine(" production rate per hour" + rate);
            return (int)rate;
        }
        static int AssemblyLineWorkingItemsPerMinute(int n)
        {
            double ratepermin = ((n * 221) / 60);
            Console.WriteLine(" production rate per min" + ratepermin);
            return (int)ratepermin;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter n value");
            int n = int.Parse(Console.ReadLine());

            AssemblyLineSuccessRate(n);
            AssemblyLineProductionRatePerHor(n);
            AssemblyLineWorkingItemsPerMinute(n);
            Console.WriteLine();

            // Console.WriteLine();
            Console.ReadKey();

        }
    }
}
