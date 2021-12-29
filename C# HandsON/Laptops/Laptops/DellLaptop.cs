using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptops
{
    class DellLaptop : LaptopDetails //child class
    {
        /* string Name = "Dell";
         int Price = 45000;
         string Processor = "i5";
         string Ram = "16GB";
         string HardDrive = "1TB";*/
        public void DellLaptopType()
        {
            Console.WriteLine(" Name= Dell,Price = 45000, Processor = i5, Ram = 16GB,HardDrive = 1TB");
        }
    }
}
