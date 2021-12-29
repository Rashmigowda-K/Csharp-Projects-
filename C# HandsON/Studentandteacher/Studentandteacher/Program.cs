using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentandteacher
{
    class StudentAndTeacherTest
    {
        static void Main()
        {
            bool debug = false;
            //create a person and make it say hello
            Person myperson = new Person(); //object
            myperson.greet();
            //create a student ,set his age to 21,tell him to greet and display his age
            Student mystudent = new Student();
            mystudent.setage(21);
            mystudent.greet();
            mystudent.showage();

            //create a teacher, 30 years old,
            // ask him to say hello and then explain
            Teacher myteacher = new Teacher();
            myteacher.setage(30);
            myteacher.greet();
            myteacher.explain();

            if (debug)
                Console.ReadLine();
        }
    }
}
