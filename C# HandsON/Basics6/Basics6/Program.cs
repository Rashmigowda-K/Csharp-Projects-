using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics6
{
    class Program
    {
        struct book
        {
            public string bookname;
            public int price;
            public string category;
        }
        static void Main(string[] args)
        {
            //Creating two book type variable
            book language, database;

            // Storing value in language variable
            Console.Write("Enter book name:");
            language.bookname = Console.ReadLine();
            Console.Write("Enter book price:");
            language.price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter book category:");
            language.category = Console.ReadLine();

            //Storing value in database variable
            Console.Write("\n\nEnter book name:");
            database.bookname = Console.ReadLine();
            Console.Write("Enter book price:");
            database.price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter book category:");
            database.category = Console.ReadLine();


            //Displaying value of language variable
            Console.Write("\n\n===================");
            Console.Write("\n\t\tLanguage\n");
            Console.Write("===================\n\n");

            Console.Write("Book Name:\t{0}", language.bookname);
            Console.Write("\nBook Price:\t{0}", language.price);
            Console.Write("\nBook Category:\t{0}", language.category);

            Console.Write("\n\n==================\n");
            Console.Write("\t\tDatabase\n");
            Console.Write("====================\n\n");

            Console.Write("Book Name:\t{0}", database.bookname);
            Console.Write("\nBook Price:\t{0}", database.price);
            Console.Write("\nBook Category:\t{0}", database.category);

            Console.ReadLine();
        }
    }
}
