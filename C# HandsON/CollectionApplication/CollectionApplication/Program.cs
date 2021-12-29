using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue('1');
            q.Enqueue('2');
            q.Enqueue('3');
            q.Enqueue('4');
            q.Enqueue('5');

            Console.WriteLine("Current queue: ");
            foreach (var n in q) Console.Write(n + " "); // space between char

            Console.WriteLine();
            q.Enqueue('f');
            q.Enqueue('r');
            q.Enqueue('i');
            q.Enqueue('e');
            q.Enqueue('n');
            q.Enqueue('d');
            q.Enqueue('s');
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c);// without space

            Console.WriteLine(); //next line
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue(); //removing the value/char
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            Console.ReadKey();
        }
    }
}




//Queue is a special type of collection that stores the elements in FIFO style (First In First Out),
//exactly opposite of the Stack<T> collection.(Last In First Out)
//It contains the elements in the order they were added.
//generic Queue<T> and non-generic Queue collection - includes
//Elements can be added using the Enqueue() method. 
//Elements can be retrieved using the Dequeue() and the Peek() methods.
//The Peek() method always returns the first item from a queue collection without
//removing it from the queue.
//<> - angular bracket --> datatype --> Generic