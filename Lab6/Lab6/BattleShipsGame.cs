using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class BattleShipsGame
    {
        const int EMPTY_SEA = 0;
        const int ATTACKED = 1;
        const int BATTLESHIP = 2;
        const int CRUISER = 3;
        const int SUBMARINE = 4;
        const int ROWING_BOAT = 5;
        const int SEA_SIZE = 10;

        static int[,] sea = new int[SEA_SIZE, SEA_SIZE];

        static void emptiesSea()
        {
            for (int i = 0; i < SEA_SIZE; i++)
            {
                for (int j = 0; j < SEA_SIZE; j++)
                {
                    sea[i, j] = EMPTY_SEA;
                }

            }
        }

        static void placesShips()
        {
            sea[0, 5] = BATTLESHIP;
            sea[2, 7] = BATTLESHIP;
            sea[0, 0] = CRUISER;
            sea[2, 0] = CRUISER;
            sea[4, 3] = CRUISER;
            sea[5, 6] = SUBMARINE;
            sea[8, 8] = ROWING_BOAT;
        }

        static void displaysSea()
        {
            for (int k = 0; k < SEA_SIZE; k++)
            {
                if (k == 0)
                {
                    Console.Write("    ");
                }
                Console.Write(k + "   ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int j = 0; j < SEA_SIZE; j++)
            {
                for (int i = 0; i < SEA_SIZE; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(j + "  ");
                    }
                    Console.Write("[" + sea[i, j] + "] ");

                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void getPlayerMove()
        {
            Console.Write("X coordinate: ");
            int Xmove = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Y coordinate: ");
            int Ymove = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n");

            switch (sea[Ymove, Xmove])
            {
                default:
                    break;
            }
        }

        public static void Main()
        {
            displaysSea();
        }


    }
}
