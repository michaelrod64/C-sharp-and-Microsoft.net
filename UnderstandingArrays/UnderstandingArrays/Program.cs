using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int[] numbers = new int[6];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            numbers[5] = 42;

            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(numbers[1].ToString());
            Console.WriteLine();
            
    
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            
            Console.WriteLine(numbers.Length);

            string zig = "You can get what you want out of life " +
                "if you help enough people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.Write(zigChar);

            Console.ReadLine();

        }
    }
}
