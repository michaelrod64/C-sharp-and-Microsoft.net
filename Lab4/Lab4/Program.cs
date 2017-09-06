using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Music myMusic = new Music();
            introduction();
            addMusic(myMusic);
            hub(myMusic);
        }

        public static void introduction()
        {
            Console.WriteLine("Hello, this is a music data program.");
            Console.WriteLine("It can keep track of up to ten artist's songs and their sales numbers.");
            Console.WriteLine("To begin, we will enter songs, their artist and thier sales numbers.");
            Console.WriteLine();
        }
        public static void addMusic(Music myMusic)
        {
            
            
                string userArtist = "0";
                int userSales = 0;

                while (userArtist != "-1" && userSales != -1 && myMusic.getTotalTracks() <= 11)
                {
                    Console.WriteLine("Type \"-1\" when you have finished inputting songs, artists, and sales numbers.");
                    Console.Write("Please enter a song and artist: ");
                    userArtist = Console.ReadLine();
                    Console.WriteLine();
                    if (userArtist != "-1")
                    {
                        do
                        {
                            Console.Write("Please enter the song's current sale's numbers (up to 50,000): ");
                            userSales = Convert.ToInt16(Console.ReadLine());
                            
                            if (userSales > 50000 || userSales < -1)
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        } while (userSales > 50000 || userSales < -1);
                        if (userSales != -1)
                        {

                            myMusic.addMusic(userArtist, userSales);
                            Console.WriteLine("Success!");
                            Console.WriteLine();
                        }
                    }
                }
        }

        public static void hub(Music myMusic)
        {
            Console.WriteLine("You have now finished submitting your information.");
            Console.WriteLine("Here are Your possible commands: ");
            Console.WriteLine();
            string userInput;
            do
            {
                Console.WriteLine("\"addtrack:\" Allows you to add additional tracks");
                Console.WriteLine("\"viewall\": Displays all tracks and their sales numbers.");
                Console.WriteLine("\"bestseller\": Displays the best selling track");
                Console.WriteLine("\"worstseller\": Displays the worst selling track");
                Console.WriteLine("\"totalsales\": Displays the total sales");
                Console.WriteLine("\"totaltracks\": Displays the total number of tracks inputted");
                Console.WriteLine("\"quit\": Shuts down program");
                Console.WriteLine();
                userInput = Console.ReadLine();
                Console.WriteLine();
                switch (userInput)
                {
                    case "addtrack":
                        addMusic(myMusic);
                        Console.WriteLine();
                        break;
                    case "viewall":
                        myMusic.getDictionary().ToList().ForEach(x => Console.Write(x + "\n"));
                        Console.WriteLine();
                        break;
                    case "bestseller":
                        Console.WriteLine(myMusic.getHighestSelling());
                        Console.WriteLine();
                        break;
                    case "worstseller":
                        Console.WriteLine(myMusic.getLowestSelling());
                        Console.WriteLine();
                        break;
                    case "totalsales":
                        Console.WriteLine("Total copies sold: " + myMusic.getSales());
                        Console.WriteLine();
                        break;
                    case "totaltracks":
                        Console.WriteLine("Total tracks submitted: " + myMusic.getTotalTracks());
                        Console.WriteLine();
                        break;
                    case "quit":
                        Console.WriteLine("Quitting program. Good-Bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        Console.WriteLine();
                        break;
                }
            } while (userInput != "quit");

        }

    }
}
