using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    static class Draw
    {

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
            return (coorY < 28 || coorY > 347) ? -1 : coorY;
        }
        static public int GetCell(int coor)
        {
            return (coor - 28) / 32;
        }




        static public void DrawBorderToCell(int cellX, int cellY, Form form, PictureBox fieldPbox)
        {
            Graphics g = fieldPbox.CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            g.DrawRectangle(p, (cellX + 1) * 32 - 7, (cellY + 1) * 32 - 7, 38, 38);

        }

    }
}
