using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            HpLaptop hp = new HpLaptop("Hplaptop", 250000,"processori3 ","16gb","1tb");
            DellLaptop de = new DellLaptop()

            hp.HpLaptopType();
            de.DellLaptopType();


        }
    }
}
