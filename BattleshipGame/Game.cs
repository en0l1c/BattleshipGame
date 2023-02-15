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
        public static int round = 1;
        // lengths of four ships
        static int[] lengthsOfShip = new int[4] { 2, 3, 4, 5 };
        public static string stringForBattleLog;
        public static int timeToTheEnd;

        // neighbour cells of the destroyed ship
        public static int extraRevealedCells = 0;

        public static Player myPlayer;
        public static Player cpuPlayer;

        static string[] kindOfShips = new string[4] { "Υποβρύχιο(2)", "Πολεμικό(3)", "Αντιτορπιλικό(4)", "Αεροπλανοφόρο(5)" };


        public static int RandomNumber(int maxNum)
        {
            Random rnd = new Random();
            return rnd.Next(maxNum);
        }


        // Is Valid Cell for deploying a Ship?
        public static bool IsValidCell(int shipToDeploy, int cellX, int cellY, bool isHorizontal, int[,] shipsSet, Player player)
        {
            //cellX for row
            // cellY for column

            // If cellX or cellY are below the zero, means
            if(cellX < 0 || cellY < 0)
            {
                return false;
            }

            if (isHorizontal)
            {
                if (cellX + lengthsOfShip[shipToDeploy] - 1 <= 9)
                {
                    // check all the cells that are not valid to put a ship on they
                    for(int row = Math.Max(0, cellX - 1); row <= Math.Min(9, cellX + lengthsOfShip[shipToDeploy]); row++)
                    {
                        //MessageBox.Show($"i: {row}, lengthOfShips: {lengthsOfShips[shipToDeploy]}");
                        for(int col = Math.Max(0, cellY - 1); col <= Math.Min(9, cellY + 1); col++)
                        {
                            if (shipsSet[row, col] != -1)
                            {
                                // invalid layout
                                return false;
                            }
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
                if(cellY + lengthsOfShip[shipToDeploy] -1 <= 9)
                {
                    // searching for an invalid layout on the grid
                    for(int row = Math.Max(0, cellX - 1); row <= Math.Min(9, cellX + 1); row++)
                    {
                        for(int col = Math.Max(0, cellY - 1); col <= Math.Min(9, cellY + lengthsOfShip[shipToDeploy]); col++)
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

        public static void PutShipToField(int shipToDeploy, int cellX, int cellY, bool isHorizontal, int[,] shipsSet)
        {
            if(isHorizontal)
            {
                for(int i = 0; i < lengthsOfShip[shipToDeploy]; i++)
                {
                    // deploy a ship into the shipsSet
                    shipsSet[cellX + i, cellY] = shipToDeploy;
                }
            }
            else
            {
                for(int i = 0; i < lengthsOfShip[shipToDeploy]; i++)
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
                List<int[]> validCellsForShips = new List<int[]>();
                List<bool> rotationAspects = new List<bool>();

                // for loops to check all the cells of the field (2D array) 10x10
                for (int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        // if its horizontal
                        if (IsValidCell(shipToDeploy, row, col, true, player.setOfShips, player))
                        {
                            validCellsForShips.Add(new int[2] { row, col });
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
                            validCellsForShips.Add(new int[2] { row, col });
                            //
                            rotationAspects.Add(false);
                        }
                    }
                }

                // choose a random valid cell from the list
                int random = RandomNumber(validCellsForShips.Count);

                // deploy the ship into the setOfShips
                PutShipToField(shipToDeploy, validCellsForShips[random][0], validCellsForShips[random][1], rotationAspects[random], player.setOfShips);
            }
        }

        // return true if the attack was the last and game is over, or return false
        static public bool Attack(int cellX, int cellY, Player attacker, Player attacked)
        {
            //MessageBox.Show("Who's turn: " + whosTurn.ToString());
            // here goes logs
            // ....

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
                    //MessageBox.Show(kindOfShips[attacked.setOfShips[cellX, cellY]]);
                    stringForBattleLog += "Round " + round + ": Βυθίστηκε το " + kindOfShips[attacked.setOfShips[cellX, cellY]] + " πλοίο του παίκτη: " + attacked.playersName + "\n";
                    attacked.battlelog = stringForBattleLog;
                    attacker.battlelog = stringForBattleLog;

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
                    // if the cell is unrevealed add it to the list
                    if (!player.revealedCells[row, col])
                    {
                        unreferencedCells.Add(new int[2] { row, col });
                    }
                }
            }

            return unreferencedCells[RandomNumber(unreferencedCells.Count)];
        }


        static public void NewGame(Player player)
        {
            round = 1;

            stringForBattleLog = "";
            timeToTheEnd = 0;
            player.battlelog = "";
            player.remainCellsForShips = new int[] { 2, 3, 4, 5 };
            player.unrevealedCells = 100; // at the begging all the cells are unrevealed
            player.remainShips = 4;
            player.remainShipCells = 14;
            player.setOfShips = new int[10, 10]; // 2D array 10x10
            player.revealedCells = new bool[10, 10];

            // 1 for loop for row, and one loop for column
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    player.setOfShips[row, col] = -1; // at the beginning of the game all 
                    player.revealedCells[row, col] = false; // turn all 100 cells as false to say they are unrevealed cells

                }
            }

            player.lastRevealedCells = new int[2];
            player.lastRevealedCells[0] = -1;
            player.lastRevealedCells[1] = -1;

            AutoDeployShips(player);
            
            //new GameForm();
        }

        static public void CalculateTime()
        {
            Game.timeToTheEnd = Game.timeToTheEnd / 1000; // divine by the timer's interval to get the total seconds;
            if (Game.timeToTheEnd >= 60)
            {
                int minutes = Game.timeToTheEnd / 60;
                int seconds = Game.timeToTheEnd % 60;
                MessageBox.Show(minutes.ToString() + " min " + seconds.ToString() + " sec to end the game");
            }
            else
            {
                MessageBox.Show(Game.timeToTheEnd.ToString() + " seconds to end the game");
            }
        }
    }
}
