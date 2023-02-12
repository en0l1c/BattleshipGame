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

        public static int GetX(Form form, PictureBox fieldPbox)
        {
           
            int borderWidth = (form.Width - form.ClientSize.Width) / 2;
            int coorX = Control.MousePosition.X - form.Location.X - fieldPbox.Location.X - borderWidth;
            //return coorX;
            return (coorX < 28 || coorX > 347) ? -1 : coorX; //to prwto koutaki ksekinaei sto x=35 kai to kathe koutaki apexei 37 me to epomeno
        }
        public static int GetY(Form form, PictureBox fieldPbox)
        {
            int borderWidth = (form.Width - form.ClientSize.Width) / 2;
            int titleBarHeight = form.Height - form.ClientSize.Height - 2 * borderWidth;
            int coorY = Control.MousePosition.Y - form.Location.Y - fieldPbox.Location.Y - titleBarHeight - borderWidth;
            //return coorY;
            return (coorY < 28 || coorY > 347) ? -1 : coorY; //επιτρεπτές είναι μόνο τα points μεταξύ του 28 και του 347 και για τον αξονα χ'χ και για τον άξονα y'y
        }
        static public int GetCell(int coor)
        {
            return (coor - 28) / 32;
        }




        static public void DrawBorderToCell(int cellX, int cellY, Form form, PictureBox fieldPbox)
        {
            Graphics g = fieldPbox.CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            Rectangle rect = new Rectangle((cellX + 1) * 32 - 7, (cellY + 1) * 32 - 7, 38, 38);
            g.DrawRectangle(p, rect);
        }
        static public void DrawBorderToCell(int cellX, int cellY, Form form, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Red, 3);
            Rectangle rect = new Rectangle((cellX + 1) * 32 - 7, (cellY + 1) * 32 - 7, 38, 38);
            e.Graphics.DrawRectangle(p, rect);
        }

        //static public void DrawColoredCell(int cellX, int cellY, PaintEventArgs e)
        //{

        //    //Graphics g = fieldPbox.CreateGraphics();
        //    Brush b = new HatchBrush(HatchStyle.Percent50, Color.Yellow, Color.Black);
        //    //Rectangle rect = new Rectangle((cellX + 1) * 32 - 7, (cellY + 1) * 32 - 7, 38, 38);
        //    //g.FillRectangle(b, rect);

        //    e.Graphics.FillRectangle(b, (cellX + 1) * 32 - 3, (cellY + 1) * 32 - 3, 31, 31);
        //}
        //static public void DrawColoredCell(int cellX, int cellY, int shipsSet, PaintEventArgs e)
        //{

        //    //Graphics g = fieldPbox.CreateGraphics();
        //    Brush b = new HatchBrush(HatchStyle.Percent50, Color.Yellow, Color.Black);
        //    //Rectangle rect = new Rectangle((cellX + 1) * 32 - 7, (cellY + 1) * 32 - 7, 38, 38);
        //    //g.FillRectangle(b, rect);

        //    e.Graphics.FillRectangle(b, (cellX + 1) * 32 - 3, (cellY + 1) * 32 - 3, 31, 31);
        //}

        //static public void DrawColoredCell(int cellX, int cellY, int shipsSet, PictureBox fieldPbox)
        //{
        //    using (Graphics g = Graphics.FromImage(fieldPbox.Image))
        //    {
        //        //Graphics g = fieldPbox.CreateGraphics();
        //        Brush b = new HatchBrush(HatchStyle.Percent25, Color.Red, Color.Black);
        //        //Rectangle rect = new Rectangle((cellX + 1) * 32 - 7, (cellY + 1) * 32 - 7, 38, 38);
        //        //g.FillRectangle(b, rect);

        //        g.FillRectangle(b, (cellX + 1) * 32 - 4, (cellY + 1) * 32 - 4, 29, 29);
        //    }
        //    fieldPbox.Refresh();
        //}
        static public void DrawColoredCell(int cellX, int cellY, int shipsSet, PaintEventArgs e)
        {
            Brush b = new HatchBrush(HatchStyle.Percent25, Color.Red, Color.Black);

            e.Graphics.FillRectangle(b, (cellX + 1) * 32 - 2, (cellY + 1) * 32 - 2, 29, 29);
            
        }

        //static public void DrawHitOnShip(int cellX, int cellY, PictureBox fieldPbox)
        //{
        //    using (Graphics g = Graphics.FromImage(fieldPbox.Image))
        //    {
        //        g.DrawImage(hitOnShip, (cellX + 1) * 32, (cellY + 1) * 32);
        //    }
        //}
        static public void DrawHitOnShip(int cellX, int cellY, PaintEventArgs e)
        {
            e.Graphics.DrawImage(hitOnShip, (cellX + 1) * 32 - 2, (cellY + 1) * 32 - 2);
        }

        //static public void DrawHitOnWater(int cellX, int cellY, PictureBox fieldPbox)
        //{
        //    using (Graphics g = Graphics.FromImage(fieldPbox.Image))
        //    {
        //        g.DrawImage(hitOnWater, (cellX + 1) * 32, (cellY + 1) * 32);
        //    }
        //}
        static public void DrawHitOnWater(int cellX, int cellY, PaintEventArgs e)
        {
            e.Graphics.DrawImage(hitOnWater, (cellX + 1) * 32 - 2, (cellY + 1) * 32 - 2) ;
        }

        //// PictureBox paint event handler for drawing a ship set on a deck.
        //static public void DrawShipSet(int[,] shipsSet, PaintEventArgs e)
        //{
        //    for (int x = 0; x < 10; x++)
        //    {
        //        for (int y = 0; y < 10; y++)
        //        {
        //            if (shipsSet[x, y] != -1)
        //            {
        //                DrawColoredCell(x, y, shipsSet[x, y], e);
        //            }
        //        }
        //    }
        //}
        //static public void DrawShipSet(int[,] shipsSet, PictureBox fieldPbox)
        //{
        //    using (Graphics g = Graphics.FromImage(fieldPbox.Image))
        //    {
        //        for (int x = 0; x < 10; x++)
        //        {
        //            for (int y = 0; y < 10; y++)
        //            {
        //                if (shipsSet[x, y] != -1)
        //                {
        //                    DrawColoredCell(x, y, shipsSet[x, y], fieldPbox);
        //                }
        //            }
        //        }
        //    }
        //    fieldPbox.Refresh();
        //}
        static public void DrawShipSet(int[,] shipsSet, PaintEventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (shipsSet[x, y] != -1)
                    {
                        DrawColoredCell(x, y, shipsSet[x, y], e);
                    }
                }
            }
        }

        // PictureBox paint event handler for drawing a deck status of all the cells.
        //static public void DrawFieldStatus(bool[,] deckStatus, int[,] shipSet, PictureBox fieldPbox)
        //{
        //    using (Graphics g = Graphics.FromImage(fieldPbox.Image))
        //    {
        //        for (int x = 0; x < 10; x++)
        //        {
        //            for (int y = 0; y < 10; y++)
        //            {
        //                if (deckStatus[x, y])
        //                {
        //                    if (shipSet[x, y] != -1)
        //                    {
        //                        DrawHitOnShip(x, y, fieldPbox);
        //                    }
        //                    else
        //                    {
        //                        DrawHitOnWater(x, y, fieldPbox);
        //                    }
        //                }
        //            }
        //        }
        //    }
            
        //}
        static public void DrawFieldStatus(bool[,] deckStatus, int[,] shipSet, PaintEventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (deckStatus[x, y])
                    {
                        if (shipSet[x, y] != -1)
                        {
                            DrawHitOnShip(x, y, e);
                        }
                        else
                        {
                            DrawHitOnWater(x, y, e);
                        }
                    }
                }
            }

        }


        //static public void DrawDestroyedShips(int[,] shipsSet, int[] ShipLeftCells, PictureBox fieldPbox)
        //{
        //    using (Graphics g = Graphics.FromImage(fieldPbox.Image))
        //    {
        //        for (int shipToDeploy = 0; shipToDeploy < 5; shipToDeploy++)
        //        {
        //            if (ShipLeftCells[shipToDeploy] == 0)
        //            {
        //                for (int row = 0; row < 10; row++)
        //                {
        //                    for (int col = 0; col < 10; col++)
        //                    {
        //                        if (shipsSet[row, col] == shipToDeploy)
        //                        {
        //                            DrawColoredCell(row, col, shipToDeploy, fieldPbox);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
            
        //}

        static public void DrawDestroyedShips(int[,] shipsSet, int[] remainCellsForShips, PaintEventArgs e)
        {
            for (int shipToDeploy = 0; shipToDeploy < 4; shipToDeploy++)
            {
                if (remainCellsForShips[shipToDeploy] == 0)
                {
                    for (int row = 0; row < 10; row++)
                    {
                        for (int col = 0; col < 10; col++)
                        {
                            if (shipsSet[row, col] == shipToDeploy)
                            {
                                DrawColoredCell(row, col, shipToDeploy, e);
                            }
                        }
                    }
                }
            }

        }

    }
}
