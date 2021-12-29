using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteVariableData
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\csharpfile.tx";
            int a, b, result;
            a = 5;
            b = 2;
            result = a + b;
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write("sum of {0} +{1}={2}", a, b, result);

            }
            Console.WriteLine("saved");
            Console.ReadKey();
        }
    }
}
