using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop lp = new Laptop();

            lp.ShowDetails(Laptop.Lenove, Laptop.Price1000, Laptop.i3, Laptop.Ram2GB, Laptop.HD500GB);
            

            lp.ShowDetails(Laptop.Dell, Laptop.Price1500, Laptop.i5, Laptop.Ram4GB, Laptop.HD1TB);
           

            lp.ShowDetails(Laptop.Sony, Laptop.Price2000, Laptop.i9, Laptop.Ram8GB, Laptop.HD1TB);
            

            Console.ReadKey();
        }
    }
}
