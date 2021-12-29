using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoalbumTarea
{
    class Program
    {
        static void Main()
        {
            bool debug = false;

            //Create an album with its default constructor
            PhotoAlbum myAlbum1 = new PhotoAlbum();
            Console.WriteLine(myAlbum1.getnumberofpages());

            //Create an album with 24 pages
            PhotoAlbum myAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(myAlbum2.getnumberofpages());

            //Create an BigPhotoAlbum 
            Bigphotoalbum myBigphotoalbum1 = new Bigphotoalbum();
            Console.WriteLine(myBigphotoalbum1.getnumberofpages());


            if (debug)
                Console.ReadLine();
        }
    }
}
