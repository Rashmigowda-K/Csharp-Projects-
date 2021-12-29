using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentandteacher
{
    class Teacher : Person
    {
        private string subject;
        public void explain()
        {
            Console.WriteLine("explanation begins");
        }
    }
}
