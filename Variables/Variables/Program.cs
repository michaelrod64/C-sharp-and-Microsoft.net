using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 7;
            int y = x + 3;

            Console.WriteLine(y);
            */

            //var myFirstName = "Bob";

            int x = 7;
            string y = "5";
            string myFirstTry = x.ToString() + y;

            //int mySecondTry = x + y;
            int mySecondTry = x + int.Parse(y);

            Console.WriteLine(mySecondTry);


            //string myfirstname;

           // Console.WriteLine(myFirstName);

            Console.ReadLine();
             

        }
    }
}
