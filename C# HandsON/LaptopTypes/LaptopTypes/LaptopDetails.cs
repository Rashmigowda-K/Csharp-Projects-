using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopTypes
{
    class LaptopDetails
    {
        public string name;
        public int price;
        public string processor;
        public string ram;
        public string harddrive;
        
        public LaptopDetails(string name,int price,string processor,string ram, string harddrive)
        {
            this.name = name;
            this.price = price;
            this.processor = processor;
            this.ram = ram;
            this.harddrive = harddrive;

        }
    }
}
