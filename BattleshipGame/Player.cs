using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Player
    {
        public string playersName;

        public int[] remainCellsForShips { get; set; }
        public int remainShips { get; set; }
        public int remainShipCells { get; set; }

        public int[,] setOfShips { get; set; } //2D array for all locations of the ships
        public bool[,] revealedCells { get; set; } //2D array for knowing which cell is revealed. true --> revealed, false --> unrevealed
        public int[] lastRevealedCells { get; set; } // latest revealed cells
        public int unrevealedCells;

        public int victories { get; set; }
        public int defeats { get; set; }

        // Hits count.
        public int hits { get; set; }
        // Misses count.
        public int misses { get; set; }
        // Battle log content.
        public string battlelog { get; set; }
        public Player()
        {
            remainCellsForShips = new int[] { 2, 3, 4, 5 };
            unrevealedCells = 100; // at the begging all the cells are unrevealed
            remainShips = 4;
            remainShipCells = 14;
            setOfShips = new int[10, 10]; // 2D array 10x10
            revealedCells = new bool[10, 10];
            victories = 0;
            defeats = 0;

            // 1 for loop for row, and one loop for column
            for(int row = 0; row<10; row++)
            {
                for(int col = 0; col<10; col++)
                {
                    setOfShips[row, col] = -1; // at the beginning of the game all the cells have the value -1
                    revealedCells[row, col] = false; // turn all 100 cells as false to say they are unrevealed cells

                }
            }

            lastRevealedCells = new int[2];
            lastRevealedCells[0] = -1;
            lastRevealedCells[1] = -1;
        }


    }
}
