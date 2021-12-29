using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("D:\\csharpfile.txt", FileMode.Create);
            fs.Close();
            Console.Write("File has been created and the Path is D:\\csharpfile.txt");
            Console.ReadKey();
        }
    }
    
}
