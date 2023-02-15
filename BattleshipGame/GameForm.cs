using System.Security.Cryptography.X509Certificates;

namespace BattleshipGame
{
    public partial class GameForm : Form
    {
        int mouseCellX;
        int mouseCellY;
 

        Player myPlayer;
        Player cpuPlayer;

        public GameForm()
        {
            InitializeComponent();

            // -1 for knowing if the cell is unselected
            mouseCellX = -1; 
            mouseCellY = -1;


            // GameForm Settings
            this.MaximizeBox = false;
            //this.CenterToScreen(1);

            myPlayer= new Player();
            cpuPlayer = new Player();

            // take the names initialized from main form by parsing to player instances on Game class
            this.myPlayer.playersName = Game.myPlayer.playersName;
            this.cpuPlayer.playersName = Game.cpuPlayer.playersName;

            label41.Text = myPlayer.playersName; // Player's label

            timer1.Start();

            // cpu player
            Game.AutoDeployShips(cpuPlayer);
            //Draw.DrawShipSet(cpuPlayer.setOfShips, enemysFieldPbox);

            // my player
            Game.AutoDeployShips(myPlayer);
            //Draw.DrawShipSet(myPlayer.setOfShips, playersFieldPbox);

            roundNumLabel.Text = Game.round.ToString();
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

                    // Increase round, add to battlelog if any ship destroyed
                    battlelogRTbox.Text = myPlayer.battlelog;
                    roundNumLabel.Text = Game.round.ToString();

                    MessageBox.Show(myPlayer.playersName + " won!");

                    // Before new game
                    // Save victories and defeats
                    myPlayer.victories += 1;
                    cpuPlayer.defeats += 1;
                    MessageBox.Show("from myPlayers win: " + myPlayer.playersName + " victories / defeats: " + myPlayer.victories + " / " + myPlayer.defeats +
                        "\n" +
                            cpuPlayer.playersName + " victories / defeats: " + cpuPlayer.victories + " / " + cpuPlayer.defeats);
                    // TIMER - Save the time took to game over
                    timer1.Stop(); // First stop the timer after the game is over
                    Game.CalculateTime(); // Return the time in format of mins and secs
                    

                    // New Game
                    newGameLabel.Visible = true;
                     

                }
                else
                {
                    // if the game continues
                    // draw again the deck
                    enemysFieldPbox.Refresh();

                    // Increase round, add to battlelog if any ship destroyed
                    battlelogRTbox.Text = myPlayer.battlelog;
                    roundNumLabel.Text = Game.round.ToString();

                    // let the cpu choose a cell from myPlayers field that is unrevelaed
                    int[] cpuMove = Game.CpuCellSelection(myPlayer);
                    if (Game.Attack(cpuMove[0], cpuMove[1], cpuPlayer, myPlayer))
                    {
                        // Increase round, add to battlelog if any ship destroyed
                        battlelogRTbox.Text = myPlayer.battlelog;
                        roundNumLabel.Text = Game.round.ToString();

                        for (int shipToDeploy = 0; shipToDeploy < 4; shipToDeploy++)
                        {
                            cpuPlayer.remainCellsForShips[shipToDeploy] = 0;
                        }

                        // cpu has won
                        MessageBox.Show("cpu won");

                        // Before new game
                        // Save victories and defeats
                        cpuPlayer.victories += 1;
                        myPlayer.defeats += 1;
                        MessageBox.Show("from cpuPlayers win: " + myPlayer.playersName + " victories / defeats: " + myPlayer.victories + " / " + myPlayer.defeats + "\n" +
                            cpuPlayer.playersName + " victories / defeats: " + cpuPlayer.victories + " / " + cpuPlayer.defeats);
                        playersFieldPbox.Refresh();

                        // New Game
                        newGameLabel.Visible = true;

                    }
                    else
                    {
                        Game.round++; // increase the round

                        // cpu has not won
                        playersFieldPbox.Refresh();

                        
                        // Increase round, add to battlelog if any ship destroyed
                        battlelogRTbox.Text = myPlayer.battlelog;
                        roundNumLabel.Text = Game.round.ToString();

                        

                    }
                }
            }
            
        }

        private void enemysFieldPbox_MouseMove(object sender, MouseEventArgs e)
        {
            // Are we on the grid of the first deck?
            if (Draw.PositionX(this, enemysFieldPbox) != -1 && Draw.PositionY(this, enemysFieldPbox) != -1)
            {
                // Have the cell selected by mouse changed?
                if (Draw.WhichCell(Draw.PositionX(this, enemysFieldPbox)) != mouseCellX || Draw.WhichCell(Draw.PositionY(this, enemysFieldPbox)) != mouseCellY)
                {
                    // Update the cell selected by mouse.
                    mouseCellX = Draw.WhichCell(Draw.PositionX(this, enemysFieldPbox));
                    mouseCellY = Draw.WhichCell(Draw.PositionY(this, enemysFieldPbox));

                    // Repaint the first deck.
                    enemysFieldPbox.Refresh();

                    // Draw the outer frame of the selected cell.
                    Draw.BorderToCell(mouseCellX, mouseCellY, this, enemysFieldPbox);
                   
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


        }

        private void enemysFieldPbox_Paint(object sender, PaintEventArgs e)
        {
            Draw.SetOfShips(cpuPlayer.setOfShips, e);
            Draw.DestroyedCpuShips(cpuPlayer.setOfShips, cpuPlayer.remainCellsForShips, e);
            Draw.SetRightImgToCell(cpuPlayer.revealedCells, cpuPlayer.setOfShips, e);

            if (cpuPlayer.lastRevealedCells[0] != -1 && cpuPlayer.lastRevealedCells[1] != -1)
            {
                Draw.BorderToCell(cpuPlayer.lastRevealedCells[0], cpuPlayer.lastRevealedCells[1], this, e);
            }
        }

        private void playersFieldPbox_Paint(object sender, PaintEventArgs e)
        {
            Draw.SetOfShips(myPlayer.setOfShips, e);
            Draw.SetRightImgToCell(myPlayer.revealedCells, myPlayer.setOfShips, e);
            if (myPlayer.lastRevealedCells[0] != -1 && myPlayer.lastRevealedCells[1] != -1)
            {
                Draw.BorderToCell(myPlayer.lastRevealedCells[0], myPlayer.lastRevealedCells[1], this, e);
            }
        }

        private void newGameLabel_MouseHover(object sender, EventArgs e)
        {
        }

        private void newGameLabel_Click(object sender, EventArgs e)
        {
            // New Game
            
            newGameLabel.Visible = false;
            Thread.Sleep(100);
            Game.NewGame(myPlayer);
            Game.NewGame(cpuPlayer);
            roundNumLabel.Text = Game.round.ToString();
            battlelogRTbox.Clear();
            
            playersFieldPbox.Refresh();
            enemysFieldPbox.Refresh();
            timer1.Start();
        }

        private void newGameLabel_MouseEnter(object sender, EventArgs e)
        {
            newGameLabel.ForeColor = Color.Red;

        }

        private void newGameLabel_MouseLeave(object sender, EventArgs e)
        {
            newGameLabel.ForeColor = Color.White;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.timeToTheEnd += 1000;
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}