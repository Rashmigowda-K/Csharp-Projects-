using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("id    " + "source   " + "destination   " + "date   " + "status    " + "network   ");
            FileStream fs = new FileStream("D:\\csharpfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek()>0)
            {
                string readmyline = sr.ReadLine();
                string[] strings = readmyline.Split(':');

                //if (readmyline.StartsWith("Id"))

                if (strings.Length>1)
                {
                    Console.Write(strings[1]);
                }
               
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}




