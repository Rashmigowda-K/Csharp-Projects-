using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopTypes
{
    class DellLaptop : LaptopDetails
    {
        //public DellLaptop(string name, int price, string processor, string ram, string harddrive)
        //{

        //}
        public DellLaptop(string name, int price, string processor, string ram, string harddrive)
        {
            

        }
        public void DellLaptopType()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("price:" + price);
            Console.WriteLine("processor:" + processor);
            Console.WriteLine("ram:" + ram);
            Console.WriteLine("harddrive:" + harddrive);
        }
    }
}
