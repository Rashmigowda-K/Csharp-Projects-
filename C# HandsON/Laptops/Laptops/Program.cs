using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptops
{
    class Program //main class
    {
        static void Main(string[] args)
        {
            HpLaptop hp = new HpLaptop();
            hp.HplaptopType();

            DellLaptop de = new DellLaptop();
            de.DellLaptopType();

            LenovoLaptop le = new LenovoLaptop();
            le.LenovoLaptopType();

            Console.ReadKey();
        }
    }
}
