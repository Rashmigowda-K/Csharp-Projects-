using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filehandling
{
    class Program
    {
        static void Main(string[] args)
        {
            class HouseFile
        {
            public void CreateHouse()
            {
                //step 1 file creation
                FileStream filestremObj = new FileStream("C:\\Test\\MyFile.txt", FileMode.Create, FileAccess.Write);
                //file write operation
                StreamWriter sw = new StreamWriter(filestremObj);
                sw.WriteLine("Welcome to my house");

                Console.Write("Enter house name: ");
                string housename = Console.ReadLine();

                Console.Write("Enter house address: ");
                string address = Console.ReadLine();

                Console.Write("Enter house phone: ");
                int phone = Convert.ToInt32(Console.ReadLine());

                sw.WriteLine("House name:" + housename);
                sw.WriteLine("House address:" + address);
                sw.WriteLine("Phone:" + phone);
                sw.Close();
                filestremObj.Close();
                Console.WriteLine("House details saved successfully in the file");
            }
            public void ReadHouseDetails()
            {

            }
        }
    }
    }
}
