using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    static class Game
    {
        public static int round;
        // lengths of four ships
        static int[] lengthsOfShips = new int[4] { 2, 3, 4, 5 };
        static bool whosTurn; // true for player's turn, false for cpu turn

        // neighbour cells of the destroyed ship
        public static int extraRevealedCells = 0;

        public static Player myPlayer;
        public static Player cpuPlayer;


        static public void Initialize()
        {
            whosTurn = true;
            round = 1;
        }
        public static int RandomNumber(int maxNum)
        {
            Random rnd = new Random();
            return rnd.Next(maxNum);
        }

        //public static bool IsValidCellForShip(int shipToDeploy, int cellX, int cellY, bool isHorizontal, int[,] shipSet, Player player)

        // Is Valid Cell for deploying a Ship?
        public static bool IsValidCell(int shipToDeploy, int cellX, int cellY, bool isHorizontal, int[,] shipsSet, Player player)
        {
            //cellX for row
            // cellY for column

            //MessageBox.Show(lengthsOfShips[shipToDeploy].ToString());
            if(cellX < 0 || cellY < 0)
            {
                return false;
            }

            if (isHorizontal)
            {
                if (cellX + lengthsOfShips[shipToDeploy] - 1 <= 9)
                {
                    // searching for an invalid layout on the grid
                    for(int row = Math.Max(0, cellX - 1); row <= Math.Min(9, cellX + lengthsOfShips[shipToDeploy]); row++)
                    {
                        //MessageBox.Show($"i: {row}, lengthOfShips: {lengthsOfShips[shipToDeploy]}");
                        for(int col = Math.Max(0, cellY - 1); col <= Math.Min(9, cellY + 1); col++)
                        {
                            if (shipsSet[row, col] != -1)
                            {
                                // invalid layout
                                return false;
                            }
                            //MessageBox.Show($"row: {row}, lengthOfShips: {lengthsOfShips[shipToDeploy]}, cellX = {cellX} " +
                            //    $"{Environment.NewLine} " +
                            //    $"col: {col}, lengthOfShips: {lengthsOfShips[shipToDeploy]}, cellY = {cellY} " +
                            //    $"{Environment.NewLine}" +
                            //    $"");
                        }
                    }

                    // we didnt find an invalid layout
                    return true;
                }
                else
                {
                    // its bigger than the length of the grid (10x10)
                    return false;
                }
            }
            else
            {
                // vertical validation
                if(cellY + lengthsOfShips[shipToDeploy] -1 <= 9)
                {
                    // searching for an invalid layout on the grid
                    for(int row = Math.Max(0, cellX - 1); row <= Math.Min(9, cellX + 1); row++)
                    {
                        for(int col = Math.Max(0, cellY - 1); col <= Math.Min(9, cellY + lengthsOfShips[shipToDeploy]); col++)
                        {
                            if (shipsSet[row, col] != -1)
                            {
                                // invalid layout found
                                return false;
                            }
                        }
                    }
                    return true; // did not find invalid layout
                }
                else
                {
                    // out of bounds of the grid
                    return false;
                }
            }
        }

        public static void DeployShip(int shipToDeploy, int cellX, int cellY, bool isHorizontal, int[,] shipsSet)
        {
            if(isHorizontal)
            {
                for(int i = 0; i < lengthsOfShips[shipToDeploy]; i++)
                {
                    // deploy a ship into the shipsSet
                    shipsSet[cellX + i, cellY] = shipToDeploy;
                }
            }
            else
            {
                for(int i = 0; i < lengthsOfShips[shipToDeploy]; i++)
                {
                    shipsSet[cellX, cellY + i] = shipToDeploy;
                }
            }
        }
        public static void AutoDeployShips(Player player)
        {
            // for all each four ships we have to deploy on field
            for(int shipToDeploy = 0; shipToDeploy < 4; shipToDeploy++)
            {
                // create a list for storing the possibilities
                List<int[]> possibilities = new List<int[]>();
                List<bool> rotationAspects = new List<bool>();

                // for loops to check all the cells of the field (2D array) 10x10
                for (int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        // if its horizontal
                        if (IsValidCell(shipToDeploy, row, col, true, player.setOfShips, player))
                        {
                            //MessageBox.Show($"row: {row}" +
                            //    $"{Environment.NewLine} " +
                            //    $"col: {col}" +
                            //    $"{Environment.NewLine}" +
                            //    $"{IsValidCell(shipToDeploy, row, col, true, player.setOfShips, player)}");
                            possibilities.Add(new int[2] { row, col });
                            //
                            rotationAspects.Add(true);
                        }
                        // if its vertical
                        if (IsValidCell(shipToDeploy, row, col, false, player.setOfShips, player))
                        {
                            //MessageBox.Show($"row: {row}" +
                            //    $"{Environment.NewLine} " +
                            //    $"col: {col}" +
                            //    $"{Environment.NewLine}" +
                            //    $"{IsValidCell(shipToDeploy, row, col, false, player.setOfShips, player)}");
                            possibilities.Add(new int[2] { row, col });
                            //
                            rotationAspects.Add(false);
                        }
                    }
                }

                // choose the possibility
                int random = RandomNumber(possibilities.Count);


                // deploy the ship into the setOfShips
                DeployShip(shipToDeploy, possibilities[random][0], possibilities[random][1], rotationAspects[random], player.setOfShips);
            }
        }

        // return true if the attack was the last and game is over, or return false
        static public bool Attack(int cellX, int cellY, Player attacker, Player attacked)
        {
            // here goes logs
            // ....

            //Thread.Sleep(3000); // wait a few seconds to create a feel of shooting


            // mark the attacked cell as revelead cell
            attacked.revealedCells[cellX, cellY] = true;
            attacked.unrevealedCells--; // firstly the unrevealed cells are 100, on each reveal decrease by one the unrevealedCells

            // mark the last revealed cells
            attacked.lastRevealedCells[0] = cellX;
            attacked.lastRevealedCells[1] = cellY;

            // is successfull hit on ship?
            if (attacked.setOfShips[cellX, cellY] != -1)
            {
                attacked.remainShipCells--;

                attacker.hits++;

                // decrease the amount of cells left for the ship that has been hit
                attacked.remainCellsForShips[attacked.setOfShips[cellX, cellY]]--;

                // logs go here
                // ....

                if (attacked.remainCellsForShips[attacked.setOfShips[cellX, cellY]] == 0)
                {
                    // all the cells from the ship is revealed, so the ship was completely destroyed
                    attacked.remainShips--;

                    // log goes here
                    // ... 

                    // reveal neighbouring cells of the destroyed ship
                    RevealedNeighbouringCells(cellX, cellY, attacker, attacked);

                    //decrease the number of unrevealed cells
                    attacked.unrevealedCells -= extraRevealedCells;

                    // log goes here
                    // ...

                    // check if the game is over
                    if(attacked.remainShips == 0)
                    {
                        // name of the player he wons
                        return true;
                    }
                    else
                    {
                        return false; // return false if there are ships
                    }

                }
                else
                {
                    // the ship is not completely destroyed, there are cells left in it so the game continues
                    return false;
                }
            }
            else
            {
                // the attack went to the sea, so it counts as a missed shoot
                attacker.misses++;
                return false;
            }
        }

        // reveal next cells of a destroyed ship
        static public void RevealedNeighbouringCells(int cellX, int cellY, Player attacker, Player attacked)
        {
            //MessageBox.Show(cellX.ToString());
            //MessageBox.Show(cellY.ToString());

            // reveal neighbouring cells of the destroyed ship
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    //MessageBox.Show("row: " + row.ToString() + " col: " + col.ToString());
                    if (attacked.setOfShips[row, col] == attacked.setOfShips[cellX, cellY])
                    {
                        
                        
                        try
                        {
                            if (!attacked.revealedCells[row - 1, col - 1])
                            {
                                attacked.revealedCells[row - 1, col - 1] = true;
                                extraRevealedCells++;
                            }
                        }
                        catch
                        {

                        }

                        try
                        {
                            if (!attacked.revealedCells[row - 1, col])
                            {
                                attacked.revealedCells[row - 1, col] = true;
                                extraRevealedCells++;
                            }
                        }
                        catch
                        {

                        }

                        try
                        {
                            if (!attacked.revealedCells[row - 1, col + 1])
                            {
                                attacked.revealedCells[row - 1, col + 1] = true;
                                extraRevealedCells++;
                            }
                        }
                        catch
                        {


                        }


                        try
                        {
                            if (!attacked.revealedCells[row, col - 1])
                            {
                                attacked.revealedCells[row, col - 1] = true;
                                extraRevealedCells++;
                            }
                        }
                        catch
                        {

                        }

                        try
                        {
                            if (!attacked.revealedCells[row, col + 1])
                            {
                                attacked.revealedCells[row, col + 1] = true;
                                extraRevealedCells++;
                            }
                        }
                        catch
                        {

                        }

                        try
                        {
                            if (!attacked.revealedCells[row + 1, col - 1])
                            {
                                attacked.revealedCells[row + 1, col - 1] = true;
                                extraRevealedCells++;
                            }
                        }
                        catch
                        {

                        }

                        try
                        {
                            if (!attacked.revealedCells[row + 1, col])
                            {
                                attacked.revealedCells[row + 1, col] = true;
                                extraRevealedCells++;
                            }
                        }
                        catch
                        {

                        }

                        try
                        {
                            if (!attacked.revealedCells[row + 1, col + 1])
                            {
                                attacked.revealedCells[row + 1, col + 1] = true;
                                extraRevealedCells++;

                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }


        // method to make the cpu select a cell to hit
        static public int[] CpuCellSelection(Player player)
        {
            // random choose a cell and check if it is revealed. if its unrevealed continue, else do not let the cpu choose that cell

            List<int[]> unreferencedCells = new List<int[]>(); // store all unrevealed cells

            for(int row = 0; row < 10; row++)
            {
                for(int col = 0; col < 10; col++)
                {
                    if (!player.revealedCells[row, col])
                    {
                        unreferencedCells.Add(new int[2] { row, col });
                    }
                }
            }

            return unreferencedCells[RandomNumber(unreferencedCells.Count)];

        }
    }
}
