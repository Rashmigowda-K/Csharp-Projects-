using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoalbumTarea
{
    class Bigphotoalbum : PhotoAlbum
    {
        public int numberofpages;
        public Bigphotoalbum(int value)
        {
            numberofpages = value; 
        }
       public int GetNumberofpages()
        {
            return numberofpages;
        }
    }
}
