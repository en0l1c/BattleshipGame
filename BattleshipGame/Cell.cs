using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Cell
    {
        static int x;
        static int y;
        static Point pt;



        public static List<Point> coordinates = new List<Point>(); // store all the coordinates
        public static Dictionary<List<Point>, string> cells = new Dictionary<List<Point>, string>(); // store a coordinate with the cell's name that belongs (for example (51,51) belongs to cell A1
        
        

        /// <summary>
        /// i methodos pou akolouthei vazei ola tis suntetagmenes poy uparxoyn se ena keli se ena onoma. px (28,28) kai (29,28) mexri kai (59,28) antistoixoun sto keli A1. k.o.k
        /// </summary>
        public static void DefineCells()
        {

            int cnt = 0;
            int lengthOfGrid = 348; // total points needed to the end line of the grid
            char rowName = '@'; // @ is the char before A
            int columnNum = 0;

            
            for (y = 28; y < lengthOfGrid; y++)
            {
                
                // Find when new line/row starts
                if ((y + 4) % 32 == 0)
                {

                    rowName++; // A, B, C, ..., J
                }
                for (x = 28; x < lengthOfGrid; x++)
                {
                    coordinates.Add(new Point(x, y)); //add coordinate to the list

                    //Find when new cell/column starts
                    if ((x + 4) % 32 == 0) //at 28 starts a cell, next cell starts at 60... gia x= 28 ==> (28+4)%32==0,gia x = 60 ===> (60+4)%32 ==0
                    {
                        columnNum = (x + 4) / 32;// to (x+4)/32 mas dinei ton arithmo 1, 2, 3... gia A1, A2, A3 etc
                    }
                    cells.Add(new List<Point> { coordinates[cnt] }, rowName + columnNum.ToString()); //every coordinate in specific column and row goes to specific name (ex A1, A2,... , J9,J10

                    cnt++;

                }
                
            }
            

        }


        public static Point GetPointOfRequestedCell(string nameOfCell) // row, column
        {
            DefineCells(); // call the DefineCell() method to store all the coordinates
            
            int x;
            int y;
            bool keepGoing = true;

            // searching for the requested cell
            for (int i = 0; i < 10 && keepGoing; i++) // 10 times, one time for each row of the grid
            {
                foreach (KeyValuePair<List<Point>, string> cell in cells)
                {
                    if (nameOfCell == cell.Value) //cell.Value is char
                    {
                        x = cell.Key[i].X; // keep the X from the point
                        y = cell.Key[i].Y; // keep the y from the point
                        pt = new Point(x, y);
                        // Print testing message
                        StringBuilder sb = new StringBuilder();
                        sb.AppendFormat("{0} => {1}", cell.Key[i], cell.Value);
                        MessageBox.Show(sb.ToString() + Environment.NewLine + "X = " + x + Environment.NewLine + "Y = " + y);

                        // if the loop finds the first point is inside the cell.Value break the two loops and keep this point
                        keepGoing = false; // To break the outer loop for(i)
                        break; // if we get the X and Y we break the for because we found the point we wanted.

                    }
                    //StringBuilder sb = new StringBuilder();
                    //sb.AppendFormat("{0} => {1}", cell.Key[i], cell.Value);
                    //MessageBox.Show(sb.ToString());
                }
            }
            return pt;
        }








    }
}
