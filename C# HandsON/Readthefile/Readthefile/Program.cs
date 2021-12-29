using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Readthefile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\csharpfile.txt";

            using(StreamWriter writer =new StreamWriter(file))
            {
                writer.WriteLine("stream reader");
            }

            using(StreamReader reader = new StreamReader(file))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

            Console.ReadKey();
        }
    }
}
