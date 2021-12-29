using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\csharpfile.txt";
            using (StreamWriter writer = new StreamWriter(file)) 
            {
                writer.Write("hello");
                writer.WriteLine("hello stream write class");

            }
            Console.WriteLine("data saved successfully");
            Console.ReadKey();
        }
    }
}
