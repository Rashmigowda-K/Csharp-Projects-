using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentandteacher
{
    class Person
    {
        protected int age;
        public void greet()
        {
            Console.WriteLine("hello");
        }
        public void setage(int n)
        {
            age = n;
        }
    }
}
