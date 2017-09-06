using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class BattleShipProgram
    {
        const int EMPTY_SEA = 0;
        const int ATTACKED = 1;
        const int BATTLESHIP = 2;
        const int CRUISER = 3;
        const int SUBMARINE = 4;
        const int ROWING_BOAT = 5;
        const int SEA_SIZE = 10;

        const int bHealth = 4;
        const int cHealth = 3;
        const int sHealth = 3;
        const int rHealth = 2;
        
        private static int targetX = 0;
        private static int targetY = 0;
        private static int xComp = 0;
        private static int yComp = 0;
        private static bool hunt = false;
        private static int tries = 1;
        private static int i = 1;
        private static int j = 1;
        private static int k = 1;
        private static int l = 1;
        private static bool sunk = false;
        private static int huntedShip;





        

        static int[,] compSea = new int[SEA_SIZE, SEA_SIZE];
        static int[,] playerSea = new int[SEA_SIZE, SEA_SIZE];

        static void clearSea()
        {
            for (int i = 0; i < SEA_SIZE; i++)
            {
                for (int j = 0; j < SEA_SIZE; j++)
                {
                    compSea[i, j] = EMPTY_SEA;
                    playerSea[i, j] = EMPTY_SEA;
                }

            }
        }

        
            
            
            

private static void placeShips(int health, int SHIP)
{
    bool shipConfirmed = false;
    while (shipConfirmed == false)
    {
    Random rnd = new Random();
    int xComp = rnd.Next(0, 10);
    int yComp = rnd.Next(0, 10);
    int xCount = 0;
    int yCount = 0;
    int choice = rnd.Next(2);
    switch (choice)
    {
        case 0:
        
    
    if (xComp + (health - 1) < 10) {

    
        for (int i = 0; i < health; i++) {
            if (compSea[xComp + i, yComp] == EMPTY_SEA) {
                xCount++;
            }      
        } 
        if (xCount == health) {
            for (int i = 0; i < health; i++) {
                compSea[xComp + i, yComp] = SHIP; 
                
            }
            shipConfirmed = true;
        }
        else if (yComp + (health - 1) < 10) {
            for (int i = 0; i < health; i++)
            {
                if (compSea[xComp, yComp + i] == EMPTY_SEA)
                {
                    yCount++;
                }
            }
            if (yCount == health) {
                for (int i = 0; i < health; i++)
			    {
                    compSea[xComp, yComp + i] = SHIP;

			    }
                shipConfirmed = true;
            }
        }

        } else if (yComp + (health - 1) < 10) {
            for (int i = 0; i < health; i++)
			{
                if (compSea[xComp, yComp + i] == EMPTY_SEA) {
                    yCount++;
                }
			}
            if (yCount == health) {
                for (int i = 0; i < health; i++) {
                    compSea[xComp, yComp + i] = SHIP;
                }
                shipConfirmed = true;
			}
          }
        break;
        case 1:

        if (yComp + (health - 1) < 10)
        {


            for (int i = 0; i < health; i++)
            {
                if (compSea[xComp, yComp + i] == EMPTY_SEA)
                {
                    yCount++;
                }
            }
            if (yCount == health)
            {
                for (int i = 0; i < health; i++)
                {
                    compSea[xComp, yComp + i] = SHIP;

                }
                shipConfirmed = true;
            }
            else if (xComp + (health - 1) < 10)
            {
                for (int i = 0; i < health; i++)
                {
                    if (compSea[xComp + i, yComp] == EMPTY_SEA)
                    {
                        xCount++;
                    }
                }
                if (xCount == health)
                {
                    for (int i = 0; i < health; i++)
                    {
                        compSea[xComp + i, yComp] = SHIP;

                    }
                    shipConfirmed = true;
                }
            }

        }
        else if (xComp + (health - 1) < 10)
        {
            for (int i = 0; i < health; i++)
            {
                if (compSea[xComp + i, yComp] == EMPTY_SEA)
                {
                    xCount++;
                }
            }
            if (xCount == health)
            {
                for (int i = 0; i < health; i++)
                {
                    compSea[xComp + i, yComp] = SHIP;
                }
                shipConfirmed = true;
            }
        }


        break;
        }
    
    
    }
    }
static void placePlayerShips(int ship, int health, string shipName)
{
    Console.WriteLine("Please place your " + shipName + ". Your " + shipName + " must be placed in " + health + " consecutive spaces in a straight line, horizontally or vertically.");
    int count = 0;
    int xMove1;
    int yMove1;
    int xPlus = 1;
    int xMinus = 1;
    int yPlus = 1;
    int yMinus = 1;
    bool horizontal = false;
    bool vertical = false;

    
    do
    {
        Console.Write("X coordinate: ");
        xMove1 = Convert.ToInt16(Console.ReadLine()) - 1;
        
        Console.Write("Y coordinate: ");
        yMove1 = Convert.ToInt16(Console.ReadLine()) - 1;
        Console.WriteLine();
        if (playerSea[xMove1, yMove1] != 0)
        {
            Console.WriteLine("Sorry, you have already placed a ship there. Please try again.");
        }
        else
        {
            playerSea[xMove1, yMove1] = ship;
            count++;
        }
    } while (count < 1);


    while (count < health)
    {
        Console.Write("X coordinate: ");
        int xMove = Convert.ToInt16(Console.ReadLine()) - 1;
        Console.Write("Y coordinate: ");
        int yMove = Convert.ToInt16(Console.ReadLine()) - 1;
        Console.WriteLine();
        if (playerSea[xMove, yMove] != 0)
        {
            Console.WriteLine("Sorry, you have already placed a ship there. Please try again.");
        }
        else if (xMove != xMove1 && yMove != yMove1)
        {
            Console.WriteLine("Sorry, that is not a valid move. Please try again.");
        }
        else if ((xMove != xMove1 + xPlus) && (xMove != xMove1 - xMinus) && (yMove != yMove1 + yPlus) && (yMove != yMove1 - yMinus))
        {
            Console.WriteLine("Sorry, that is not a valid move. Please try again.");
        }
        else if ((horizontal && yMove != yMove1) || (vertical && xMove != xMove1))
        {
            Console.WriteLine("Sorry, that is not a valid move. Please try again.");
        }
        else
        {
            if (xMove > xMove1)
            {
                horizontal = true;
                xPlus++;
            }
            else if (xMove < xMove1)
            {
                horizontal = true;
                xMinus++;
            }
            else if (yMove > yMove1)
            {
                vertical = true;
                yPlus++;
            }
            else
            {
                vertical = true;
                yMinus++; 
            }
            playerSea[xMove, yMove] = ship;
            count++;
        }
    }
}
       

        static void displaySea(int[,] sea, string player)
        {
            Console.WriteLine(player + "'s board:");
            for (int k = 0; k < SEA_SIZE; k++)
            {
                if (k == 0)
                {
                    Console.Write("    ");
                }
                Console.Write((k + 1) + "   ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int j = 0; j < SEA_SIZE; j++)
            {
                for (int i = 0; i < SEA_SIZE; i++)
                {
                    if (i == 0 && j != 9)
                    {
                        Console.Write((j + 1) + "  ");
                    }
                    else if (i == 0)
                    {
                        Console.Write((j + 1) + " ");
                    }
                    Console.Write("[" + sea[i, j] + "] ");

                }
                Console.WriteLine();
                Console.WriteLine();
            }
            
            
        }

        static void getPlayerMove()
        {
            Console.WriteLine("Select your attack coordinates!");
            int Xmove;
            int Ymove;
            
            do
            {
                Console.Write("X coordinate: ");
                Xmove = Convert.ToInt16(Console.ReadLine()) - 1;
                Console.WriteLine();
                Console.Write("Y coordinate: ");
                Ymove = Convert.ToInt16(Console.ReadLine()) - 1;
                Console.WriteLine("\n");
                if (compSea[Xmove, Ymove] == 1)
                {
                    Console.WriteLine("Sorry, you have already attacked there. Please try again.");
                }
            } while (compSea[Xmove, Ymove] == 1);

            if (compSea[Xmove, Ymove] != 0)
            {
                Console.WriteLine("Hit!");
            }
            else
            {
                Console.WriteLine("Ha! You missed!");
            }
            int shipHit = compSea[Xmove, Ymove];
            compSea[Xmove, Ymove] = ATTACKED;
            switch (shipHit)
            {
                   
                case 2:
                    if (checkSunk(compSea, 2))
                    {
                        Console.WriteLine("Drat! You sunk my Battleship!");
                    }
                    break;
                case 3:
                    if (checkSunk(compSea, 3))
                    {
                        Console.WriteLine("Arrgh. You sunk my Cruiser.");
                    }
                    break;
                case 4:
                    if (checkSunk(compSea, 4))
                    {
                        Console.WriteLine("Oh no! You sunk my Submarine!");
                    }
                    break;
                case 5:
                    if (checkSunk(compSea, 5))
                    {
                        Console.WriteLine("No! you sunk my Rowboat!");
                    }
                    break;
            }
            compSea[Xmove, Ymove] = 1;
        }

        static bool GameOver(int[,] sea, Boolean compWin, bool isComp )
        {
            for (int j = 0; j < SEA_SIZE; j++)
            {
                for (int i = 0; i < SEA_SIZE; i++)
                {
                    if ((sea[i, j] != 0) && (sea[i, j] != 1))
                    {
                        return false;
                    }
                }
            }
            if (isComp)
            {
                compWin = false;
            }
            else
            {
                compWin = true;
            }
            return true;
        }
        
        private static void makeMove()
        {
            Random rnd = new Random();
            

            switch (hunt)

            {
                case true:
                           switch (tries)
	                       { 
                               case 1:
                                   if ((targetX + i <= 9))
                                   {
                                       yComp = targetY;
                                       xComp = targetX + i;
                                       i++;
                                   }
                               break;
                               case 2:
                               if (targetY + j <= 9)
                               {
                                   xComp = targetX;
                                   yComp = targetY + j;
                                   j++;
                               }
                               break;
                               case 3:
                               if (targetX - k >= 0)
                               {
                                   yComp = targetY;
                                   xComp = targetX - k;
                                   k++;
                               }
                                break;
                               case 4:
                                if (targetY >= 0)
                                {
                                    xComp = targetX;
                                    yComp = targetY - l;
                                    l++;
                                }
                               break;
	                        }
                           if ((playerSea[xComp, yComp] == EMPTY_SEA) || (playerSea[xComp, yComp] == ATTACKED))
                           {
                               tries++;
                           }
                           if (tries == 5)
                           {
                               tries = 1;
                           }
                           Console.WriteLine("I attack (" + (xComp + 1) + "," + (yComp + 1) + ")");
                           playerSea[xComp, yComp] = ATTACKED;
                           sunk = checkSunk(playerSea, huntedShip);

                           if (sunk == true)
                           {
                               hunt = false;
                           }
                    break;
                default: 

            
                    tries = 1;
                    i = 1;
                    j = 1;
                    k = 1;
                    l = 1;
                    sunk = false;
                    do
                    {


                        xComp = rnd.Next(0, 10);
                        yComp = rnd.Next(0, 10);

                    } while (playerSea[xComp, yComp] == ATTACKED);

                    Console.WriteLine("I attack (" + (xComp + 1) + "," + (yComp + 1) + ")");
                    if (playerSea[xComp, yComp] != EMPTY_SEA)
                    {
                        targetX = xComp;
                        targetY = yComp;
                        hunt = true;
                        huntedShip = playerSea[targetX, targetY];
                    }

                    playerSea[xComp, yComp] = ATTACKED;
                    break;
            }
        }

        private static bool checkSunk(int[,] sea, int huntedShip)
            {
            for (int j = 0; j < SEA_SIZE; j++)
            {
                for (int i = 0; i < SEA_SIZE; i++)
                {
                    if (sea[i, j] == huntedShip)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        

        public static void Main()
        {

            
            int targetX = -1;
            int targetY = -1;

            Boolean compWin = false;
            clearSea();
            placeShips(bHealth, BATTLESHIP);
            placeShips(cHealth, CRUISER);
            placeShips(sHealth, SUBMARINE);
            placeShips(rHealth, ROWING_BOAT);
            displaySea(playerSea, "Human Player");
            placePlayerShips(BATTLESHIP, bHealth, "Battleship");
            displaySea(playerSea, "Human Player");
            placePlayerShips(CRUISER, cHealth, "Cruiser");
            displaySea(playerSea, "Human Player");
            placePlayerShips(SUBMARINE, sHealth, "Submarine");
            displaySea(playerSea, "Human Player");
            placePlayerShips(ROWING_BOAT, rHealth, "RowBoat");
            displaySea(playerSea, "Human Player");
            displaySea(compSea, "Computer");
            

            while (!GameOver(compSea, compWin, true) && !GameOver(playerSea, compWin, false))
            {
                getPlayerMove();
                makeMove();
                displaySea(playerSea, "Human Player");
            }
            if (compWin)
            { 
                Console.WriteLine("Sorry, you lose!");
            }
            else
            {
                Console.WriteLine("Congradulations! You won!");
            }
            Console.ReadLine();
        }


    }
}


   

