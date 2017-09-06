using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            readInstructions();
            int requiredAge = pickMovie();
            checkAge(requiredAge);
           



        }
        public static void readInstructions() {
            Console.WriteLine("Welcome to the Multiplex");
            Console.WriteLine("We are presently showing:");
            Console.WriteLine("\t1. Rush (15)");
            Console.WriteLine("\t2. How I Live Now (15)");
            Console.WriteLine("\t3. Thor: The Dark World (12A)");
            Console.WriteLine("\t4. Filth (18)");
            Console.WriteLine("\t5. Planes (U)");
            Console.WriteLine("Enter the number of the film you wish to see: ");
        }



        public static int pickMovie()
        {
            
            int movie = Convert.ToInt16(Console.ReadLine());
            int age = 0;
            switch (movie){
                case 1: 
                    readFilm("Rush");
                    return age = 15;
                    break;
                case 2:
                    readFilm("How I Live Now");
                    return age = 15;
                    break;
                case 3: 
                    readFilm("Thor: The Dark World");
                    return age = 12;
                    break;
                case 4: 
                    readFilm("Filth");
                    return age = 18;
                    break;
                case 5:
                    readFilm("Planes");
                    return age = 0;
                    break;
		        default:
                    Console.WriteLine("Invalid input. Please enter a valid movie input.");
                    return pickMovie();
                    break;
	        }
        }
        public static void readFilm(string movie) {
            Console.WriteLine("The film you wish to see is " + movie);
        }
        public static void checkAge(int requiredAge) {
            Console.WriteLine("Enter your age:");
            
            int age = Convert.ToInt16(Console.ReadLine());
            while (age < 0 || age > 127) {
                Console.WriteLine("Invalid age. Please try again: ");
                age = Convert.ToInt16(Console.ReadLine());
                }
            if (age >= requiredAge) {
                Console.WriteLine("Enjoy the Film");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Access denied -- you are too young");
                Console.ReadLine();
            }
        }
    } 
}

