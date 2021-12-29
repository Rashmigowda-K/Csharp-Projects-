using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccessFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("D:\\csharpfile.txt", FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("hello .net!!");
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();
            Console.WriteLine("Successfully saved file with data : hello .net!!");
            Console.ReadKey();
        }
    }
}
