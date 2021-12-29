using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopTypes
{
    class HpLaptop : LaptopDetails
    {
        public HpLaptop(string name, int price, string processor, string ram, string harddrive)
        {
           
        }
        public void HpLaptopType()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("price:" + price);
            Console.WriteLine("processor:" + processor);
            Console.WriteLine("ram:" + ram);
            Console.WriteLine("harddrive:" + harddrive);
        }
    }
}
