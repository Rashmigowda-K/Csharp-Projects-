using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptops
{
    class LaptopDetails //parent class
    {
        string Name = "";
        int Price = 0 ;
        string Processor = "";
        string Ram = "";
        string HardDrive = "";

        public void LaptopName()
         {
            Console.WriteLine("the name of the laptop is ");
            LaptopName();
         }
        public void LaptopPrice()
        {
            Console.WriteLine("the price of the laptop is");
            LaptopPrice();
        }
        public void LaptopProcessor()
        {
            Console.WriteLine("the processor of the laptop is");
            LaptopProcessor();
        }
        public void LaptopRam()
        {
            Console.WriteLine("the ram of the laptop is");
        }
        public void LaptopHarddrive()
        {
            Console.WriteLine("the harddrive of the laptop is");
            LaptopHarddrive();
        }



    }
}
