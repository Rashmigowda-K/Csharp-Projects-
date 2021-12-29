using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static public void student(string fname,
                               string lname,
                               int age = 20,// optional parameter
                               string branch = "Computer science")//optional parameter

        {
            Console.WriteLine("First name: {0}", fname);
            Console.WriteLine("Last name: {0}", lname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Branch: {0}", branch);
        }

        // Main Method
        static public void Main()
        {

            // Calling the scholar method
            student("Ankita", "Saini");
            student("Siya", "Joshi", 30);
            student("Rohan", "Joshi", 37, "Information Technology");
        }

    }
}


//As the name suggests optional parameters are not compulsory parameters, they are optional.
//It helps to exclude arguments for some parameters.
//You can use optional parameters in Methods, Constructors, Indexers, and Delegates.
//The default value of an optional parameter is a constant expression.
//The optional parameters are always defined at the end of the parameter list.
//Or in other words,the last parameter of the method, constructor, etc.

