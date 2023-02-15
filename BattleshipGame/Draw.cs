using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    static class Draw
    {
        //static public Bitmap hitOnShip = new Bitmap(Properties.Resources.red_x, 31, 31);
        //static public Bitmap hitOnWater = new Bitmap(Properties.Resources.greenHyphen, 31, 31);
        static Image hitOnShip = Image.FromFile("hitOnShip.png");
        static Image hitOnWater = Image.FromFile("hitOnWater.png");
        

        // Draw 10x10 Grid for fields (panel must have the size 401x401)
        //public static void DrawFieldGrid(Form form, PictureBox fieldPbox)
        //{
        //    int numOfCells = 100; // 10x10 table
        //    int cellSize = 40;
        //    Pen p = new Pen(Color.Black);
        //    Graphics g = fieldPbox.CreateGraphics();

        //    for (int y = 0; y < numOfCells; y++)
        //    {
        //        g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
        //    }

        //    for (int x = 0; x < numOfCells; x++)
        //    {
        //        g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
        //    }
        //}

        // Get the X from a pointA(x,y) from fields (pictureboxes)
        public static int PositionX(Form form, PictureBox fieldPbox)
        {
           
            int borderWidth = (form.Width - form.ClientSize.Width) / 2;
            int pointX = Control.MousePosition.X - form.Location.X - fieldPbox.Location.X - borderWidth;
            //return coorX;
            return (pointX < 28 || pointX > 347) ? -1 : pointX;
        }
        // Get the Y from a pointA(x,y) from fields (pictureboxes)
        public static int PositionY(Form form, PictureBox fieldPbox)
        {
            int borderWidth = (form.Width - form.ClientSize.Width) / 2;
            int titleBarHeight = form.Height - form.ClientSize.Height - 2 * borderWidth;
            int pointY = Control.MousePosition.Y - form.Location.Y - fieldPbox.Location.Y - titleBarHeight - borderWidth;
            //return coorY;
            return (pointY < 28 || pointY > 347) ? -1 : pointY; //επιτρεπτές είναι μόνο τα points μεταξύ του 28 και του 347 και για τον αξονα χ'χ και για τον άξονα y'y
        }

        static public int WhichCell(int pos) // get which cell is by the position
        {
            // 28 is the length from the very beginning of the photo (pbox) to the first line of the grid. 
            // 32 is the length of each cell
            return (pos - 28) / 32;
        }




        static public void BorderToCell(int cellX, int cellY, Form form, PictureBox fieldPbox)
        {
            Graphics g = fieldPbox.CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            Rectangle rect = new Rectangle((cellX + 1) * 32 - 7, (cellY + 1) * 32 - 7, 38, 38);
            g.DrawRectangle(p, rect);
        }
        static public void BorderToCell(int cellX, int cellY, Form form, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Red, 3);
            Rectangle rect = new Rectangle((cellX + 1) * 32 - 7, (cellY + 1) * 32 - 7, 38, 38);
            e.Graphics.DrawRectangle(p, rect);
        }

        static public void ColorTheCell(int cellX, int cellY, int shipsSet, PaintEventArgs e)
        {
            Brush b = new HatchBrush(HatchStyle.Percent25, Color.Red, Color.Black);

            e.Graphics.FillRectangle(b, (cellX + 1) * 32 - 2, (cellY + 1) * 32 - 2, 29, 29);
        }

        
        static public void HitOnShip(int cellX, int cellY, PaintEventArgs e)
        {
            e.Graphics.DrawImage(hitOnShip, (cellX + 1) * 32 - 2, (cellY + 1) * 32 - 2);
        }

        
        static public void HitOnWater(int cellX, int cellY, PaintEventArgs e)
        {
            e.Graphics.DrawImage(hitOnWater, (cellX + 1) * 32 - 2, (cellY + 1) * 32 - 2) ;
        }

        // check every cell on the grid, if the cell shipSet[row, col] != -1 that means that the cell belongs to a ship
        static public void SetOfShips(int[,] shipsSet, PaintEventArgs e) // Draw to the field the cells that have no value -1
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    if (shipsSet[row, col] != -1)
                    {
                        ColorTheCell(row, col, shipsSet[row, col], e);
                    }
                }
            }
        }

        // check the grid, if the arg shipSet contain a value != from -1 then this cell belongs to a ship so draw the hitImage, else draw hitOnWater image
        static public void SetRightImgToCell(bool[,] isCellRevealed, int[,] shipSet, PaintEventArgs e)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    // Check if the cell is revealed
                    if (isCellRevealed[row, col])
                    {
                        if (shipSet[row, col] != -1)
                        {
                            HitOnShip(row, col, e);
                        }
                        else
                        {
                            HitOnWater(row, col, e);
                        }
                    }
                }
            }

        }

        static public void DestroyedCpuShips(int[,] shipsSet, int[] remainCellsForShips, PaintEventArgs e)
        {
            for (int shipToDeploy = 0; shipToDeploy < 4; shipToDeploy++)
            {
                if (remainCellsForShips[shipToDeploy] == 0) // check if the remaining cells for the shipToDeploy exist, if not, then display the ship to every cell existed at the field
                {
                    for (int row = 0; row < 10; row++)
                    {
                        for (int col = 0; col < 10; col++)
                        {
                            if (shipsSet[row, col] == shipToDeploy)
                            {
                                ColorTheCell(row, col, shipToDeploy, e);
                            }
                        }
                    }
                }
            }

        }

    }
}
