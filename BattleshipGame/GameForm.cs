namespace BattleshipGame
{
    public partial class GameForm : Form
    {
        int mouseCellX;
        int mouseCellY;

        int totalShips;
        int totalEnemyShips;
        int rounds;


        //Index of the selected ship\
        //[-1] for none, [0] for patrol .......
        int currentShip;
        //Ship rotation (true->vertical), (false->horizontal)
        bool shipRotation;
        // Which ship is already deployed
        bool[] shipDeployed = new bool[4];

        Player myPlayer;
        Player cpuPlayer;

        public GameForm()
        {
            InitializeComponent();

            mouseCellX = -1;
            mouseCellY = -1;

            currentShip = -1; // -1 for none
            shipRotation = true; // true for vertical


            //this.myPlayer = Game.myPlayer;
            //this.cpuPlayer = Game.cpuPlayer;
            // GameForm Settings
            this.MaximizeBox = false;
            //this.CenterToScreen(1);


            myPlayer= new Player();
            cpuPlayer = new Player();


            // cpu player
            Game.AutoDeployShips(cpuPlayer);
            //Draw.DrawShipSet(cpuPlayer.setOfShips, enemysFieldPbox);

            // my player
            Game.AutoDeployShips(myPlayer);
            //Draw.DrawShipSet(myPlayer.setOfShips, playersFieldPbox);



            Game.Initialize();
        }

        private void enemysFieldPbox_Click(object sender, EventArgs e)
        {
            //Player testPlayer = new Player();
            //Game.AutoDeployShips(testPlayer);
            
            // check the cell where is the mouse, and cell must be unreleaved
            if(mouseCellX != -1 && mouseCellY != -1 && !cpuPlayer.revealedCells[mouseCellX, mouseCellY])
            {
                // check if the game is over
                if (Game.Attack(mouseCellX, mouseCellY, myPlayer, cpuPlayer))
                {
                    enemysFieldPbox.Refresh();
                    MessageBox.Show("the game is over");

                }
                else
                {
                    // if the game continues
                    // draw again the deck
                    enemysFieldPbox.Refresh();

                    int[] cpuMove = Game.CpuCellSelection(myPlayer);
                    if (Game.Attack(cpuMove[0], cpuMove[1], cpuPlayer, myPlayer))
                    {
                        for(int shipToDeploy = 0; shipToDeploy < 5; shipToDeploy++)
                        {
                            cpuPlayer.remainCellsForShips[shipToDeploy] = 0;
                        }

                        // cpu has won
                        playersFieldPbox.Refresh();
                    }
                    else
                    {
                        Game.round++; // increase the round

                        // cpu has not won
                        playersFieldPbox.Refresh();
                    }
                }
            }
            
        }

        private void enemysFieldPbox_MouseMove(object sender, MouseEventArgs e)
        {
            // Are we on the grid of the first deck?
            if (Draw.GetX(this, enemysFieldPbox) != -1 && Draw.GetY(this, enemysFieldPbox) != -1)
            {
                // Have the cell selected by mouse changed?
                if (Draw.GetCell(Draw.GetX(this, enemysFieldPbox)) != mouseCellX || Draw.GetCell(Draw.GetY(this, enemysFieldPbox)) != mouseCellY)
                {
                    // Update the cell selected by mouse.
                    mouseCellX = Draw.GetCell(Draw.GetX(this, enemysFieldPbox));
                    mouseCellY = Draw.GetCell(Draw.GetY(this, enemysFieldPbox));

                    // Repaint the first deck.
                    enemysFieldPbox.Refresh();

                    // Draw the outer frame of the selected cell.
                    Draw.DrawBorderToCell(mouseCellX, mouseCellY, this, enemysFieldPbox);
                   
                }
            }
            else
            {
                // Unselect the cell in the first deck.
                mouseCellX = -1;
                mouseCellY = -1;

                // Repaint the first deck.
                enemysFieldPbox.Refresh();
            }
        }

        private void enemysFieldPbox_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(Draw.GetX(this, enemysFieldPbox).ToString() + Environment.NewLine + Draw.GetY(this, enemysFieldPbox).ToString());

           

        }

        private void enemysFieldPbox_Paint(object sender, PaintEventArgs e)
        {
            //int x, y;
            //x = Cell.GetPointOfRequestedCell("E6").X;
            //y = Cell.GetPointOfRequestedCell("E6").Y;

            //MessageBox.Show("X = " + Cell.GetPointOfRequestedCell("A3").X.ToString() + "Y = " + Cell.GetPointOfRequestedCell("A3").Y.ToString());
            //MessageBox.Show("GetCell(x): " + Draw.GetCell(x).ToString() + "GetCell(y): " + Draw.GetCell(y).ToString());

            //Draw.DrawColoredCell(Draw.GetCell(x), Draw.GetCell(y), e);


            //Game.AutoDeployShips(cpuPlayer);
            //Draw.DrawShipSet(cpuPlayer.setOfShips, e);
            //Draw.DrawFieldStatus(cpuPlayer.revealedCells,  cpuPlayer.setOfShips, e);

            Draw.DrawShipSet(cpuPlayer.setOfShips, e);
            Draw.DrawDestroyedShips(cpuPlayer.setOfShips, cpuPlayer.remainCellsForShips, e);
            Draw.DrawFieldStatus(cpuPlayer.revealedCells, cpuPlayer.setOfShips, e);

            if (cpuPlayer.lastRevealedCells[0] != -1 && cpuPlayer.lastRevealedCells[1] != -1)
            {
                Draw.DrawBorderToCell(cpuPlayer.lastRevealedCells[0], cpuPlayer.lastRevealedCells[1], this, e);
            }
        }

        private void playersFieldPbox_Paint(object sender, PaintEventArgs e)
        {
            Draw.DrawShipSet(myPlayer.setOfShips, e);
            Draw.DrawFieldStatus(myPlayer.revealedCells, myPlayer.setOfShips, e);
            if (myPlayer.lastRevealedCells[0] != -1 && myPlayer.lastRevealedCells[1] != -1)
            {
                Draw.DrawBorderToCell(myPlayer.lastRevealedCells[0], myPlayer.lastRevealedCells[1], this, e);
            }
        }
    }
}