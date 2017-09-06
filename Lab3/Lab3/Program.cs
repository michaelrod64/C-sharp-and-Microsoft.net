using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            introduction();
            subjectChoice();
        }
        public static void introduction() {
            Console.WriteLine("Welcome to the Automatic Exam Grader.");
            Console.WriteLine("You can enter a subject and a grade percentage to recieve your letter grade.");
        }
        public static void subjectChoice() {
            int subjectNumber;
            do 
            {
                Console.WriteLine("Please choose a subject by typing in its number, or type \"-1\" to quit the program.");
                Console.WriteLine("\t1. gardening");
                Console.WriteLine("\t2. crosswords");
                Console.WriteLine("\t3. trainspotting");
                Console.WriteLine("\t4. chess");
                Console.WriteLine("\t5. football");
                Console.WriteLine("\t6. timetabling");
                subjectNumber = Convert.ToInt16(Console.ReadLine());
                
                switch (subjectNumber)
                { case 1: 
                        gradeCalculator("gardening", 43, 50, 60, 70);
                        break;
                  case 2: gradeCalculator("crosswords", 45, 51, 64, 75);
                          break;
                  case 3: gradeCalculator("trainspotting", 46, 55, 67, 80);
                          break;
                  case 4: gradeCalculator("chess", 37, 45, 56, 66);
                          break;
                  case 5: gradeCalculator("football", 41, 50, 54, 68);
                          break;
                  case 6: gradeCalculator("timetabling", 40, 50, 60, 72);
                          break;
                  default:
                        Console.WriteLine("Please enter a valid subject number.");
                        break;
	            }

            } while(subjectNumber != -1);
        }

            public static void gradeCalculator(string subject, int f, int d, int c, int b) {
                string grade;
                Console.WriteLine("Please type in the percentage recieved in your " + subject + " exam:");
                int percentage = Convert.ToInt16(Console.ReadLine());
                while (percentage > 100 || percentage < 0) {
                    Console.WriteLine("Invalid input. Please enter a valid percentage: ");
                    percentage = Convert.ToInt16(Console.ReadLine());
                }

                if (percentage >= b) {
                    grade = "A";
                }
                else if (percentage >= c) {
                    grade = "B"; 
                }
                else if (percentage >= d) {
                    grade = "C";
                }
                else if (percentage >= f) {
                    grade = "D";
                }
                else {
                    grade = "F";
                }
                Console.WriteLine("Subject: " + subject + ", Grade: " + grade);
                Console.WriteLine();
            }

            

        }

    }

