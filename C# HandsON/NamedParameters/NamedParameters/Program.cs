using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
              int AddNumber(int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            }

            AddNumber(firstNumber: 12, secondNumber: 13);

            Console.WriteLine(AddNumber(12, 13));

               
            Console.WriteLine(AddNumber(firstNumber: 12, secondNumber: 13));
            Console.WriteLine(AddNumber(secondNumber: 13, firstNumber: 12));


             //Console.WriteLine(AddNumber(firstNumber: 12, 13); 

            // It will throw compilation error.
            // positional parameters doesn’t follow Named Parameters.
            // It throws compilation error
            // “Named argument specifications must appear after all fixed arguments have been specified”.
            Console.WriteLine(AddNumber(12, secondNumber: 13));
        }
    }
}



//allow developers to pass a method arguments with parameter names
//Prior to these this feature, the method parameters were passed using a sequence only
//we can put any parameter in any sequence as long as the name is there. 
//parameter value based on their names will be mapped to the right variable.
//The parameters name must match with the method definition parameter names.

//he syntax of parameter names is (parametername: value). 

