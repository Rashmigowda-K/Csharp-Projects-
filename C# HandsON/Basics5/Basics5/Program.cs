using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

        label: 

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Welcome {0}", name);
            Console.WriteLine("Press Ctrl + C for Exit\n");

            goto label;       
        }
    }
}
