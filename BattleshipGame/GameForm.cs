namespace BattleshipGame
{
    public partial class GameForm : Form
    {
        int mouseCellX;
        int mouseCellY;

        // Declare players
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

            // Initializing the players
            myPlayer = new Player();
            cpuPlayer = new Player();


            // take the names initialized from Game class
            this.myPlayer.playersName = Game.myPlayer.playersName;
            this.cpuPlayer.playersName = Game.cpuPlayer.playersName;

            label41.Text = myPlayer.playersName; // Player's label

            timer1.Start(); // timer to count seconds

            // CPU PLAYER
            Game.AutoDeployShips(cpuPlayer);

            // MY PLAYER
            Game.AutoDeployShips(myPlayer);
            

            roundNumLabel.Text = Game.round.ToString(); // set roundNumLabels text taken from round variable (from Game)
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            //Game.connection = new SQLiteConnection(Game.connectionString);
            // drop db
            //Game.ActionToDatabase("dropdb", myPlayer);

            //// db connection (Create table if not exists)
            Game.ActionToDatabase("createdb", myPlayer);
        }

        private void enemysFieldPbox_Click(object sender, EventArgs e)
        {
            // check the cell, where is the mouse, and cell must be unreleaved
            if (mouseCellX != -1 && mouseCellY != -1 && !cpuPlayer.revealedCells[mouseCellX, mouseCellY])
            {
                // check if the game is over
                if (Game.Attack(mouseCellX, mouseCellY, myPlayer, cpuPlayer))
                {
                    enemysFieldPbox.Refresh();

                    // increase the round and add the battlelog if any ship destroyed
                    battlelogRTbox.Text = myPlayer.battlelog;
                    roundNumLabel.Text = Game.round.ToString();

                    MessageBox.Show(myPlayer.playersName + " won!");

                    // BEFORE NEW GAME (before reset stats)
                    Game.winner = true; // true for myPlayer
                    // Save victories and defeats
                    myPlayer.victories += 1;
                    cpuPlayer.defeats += 1;
                    MessageBox.Show("from myPlayers win: " + myPlayer.playersName + " victories / defeats: " + myPlayer.victories + " / " + myPlayer.defeats +
                        "\n" +
                            cpuPlayer.playersName + " victories / defeats: " + cpuPlayer.victories + " / " + cpuPlayer.defeats);
                    // TIMER - Save the time took to game over
                    timer1.Stop(); // First stop the timer after the game is over
                    //Game.CalculateTime(); // Return the time in format of mins and secs

                    // New Game
                    timeLabel.Visible = true;
                    timeTakenLabel.Text = Game.CalculateTime();
                    timeTakenLabel.Visible = true;
                    newGameLabel.Visible = true;


                }
                else
                {
                    // MOVE OF THE CPU PLAYER //

                    // if the game continues
                    enemysFieldPbox.Refresh();

                    // increase the round and add the battlelog if any ship destroyed
                    battlelogRTbox.Text = myPlayer.battlelog;
                    roundNumLabel.Text = Game.round.ToString();

                    // let the cpu choose a cell from myPlayers field that is unrevelaed
                    int[] cpuMove = Game.CpuCellSelection(myPlayer);
                    if (Game.Attack(cpuMove[0], cpuMove[1], cpuPlayer, myPlayer))
                    {
                        // increase the round and add the battlelog if any ship destroyed
                        battlelogRTbox.Text = myPlayer.battlelog;
                        roundNumLabel.Text = Game.round.ToString();

                        for (int shipToDeploy = 0; shipToDeploy < 4; shipToDeploy++)
                        {
                            cpuPlayer.remainCellsForShips[shipToDeploy] = 0;
                        }

                        // cpu has won
                        MessageBox.Show("cpu won");

                        // Before new game
                        Game.winner = false; // false for cpuPlayer
                        // Save victories and defeats
                        cpuPlayer.victories += 1;
                        myPlayer.defeats += 1;
                        MessageBox.Show("from cpuPlayers win: " + myPlayer.playersName + " victories / defeats: " + myPlayer.victories + " / " + myPlayer.defeats + "\n" +
                            cpuPlayer.playersName + " victories / defeats: " + cpuPlayer.victories + " / " + cpuPlayer.defeats);
                        playersFieldPbox.Refresh();


                        // New Game
                        timeLabel.Visible = true;
                        timeTakenLabel.Text = Game.CalculateTime();
                        timeTakenLabel.Visible = true;
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
            // check if the mouse cursor is on the grid
            if (Draw.PositionX(this, enemysFieldPbox) != -1 && Draw.PositionY(this, enemysFieldPbox) != -1)
            {
                // is the cell selected 
                if (Draw.WhichCell(Draw.PositionX(this, enemysFieldPbox)) != mouseCellX || Draw.WhichCell(Draw.PositionY(this, enemysFieldPbox)) != mouseCellY)
                {
                    // update mouseCellX and mouseCellY values
                    mouseCellX = Draw.WhichCell(Draw.PositionX(this, enemysFieldPbox));
                    mouseCellY = Draw.WhichCell(Draw.PositionY(this, enemysFieldPbox));

                    enemysFieldPbox.Refresh();

                    Draw.BorderToCell(mouseCellX, mouseCellY, this, enemysFieldPbox); // draw the border to the cell


                }
            }
            else
            {
                // mark the cell as unselected
                mouseCellX = -1;
                mouseCellY = -1;

                enemysFieldPbox.Refresh(); // refresh the field
            }
        }

        private void enemysFieldPbox_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void enemysFieldPbox_Paint(object sender, PaintEventArgs e)
        {
            Draw.SetOfShips(cpuPlayer.setOfShips, e);
            // check if the is destroyed ship and draw it
            Draw.DestroyedCpuShips(cpuPlayer.setOfShips, cpuPlayer.remainCellsForShips, e); 
            // draw the right image to the cell
            Draw.SetRightImgToCell(cpuPlayer.revealedCells, cpuPlayer.setOfShips, e);

            if (cpuPlayer.lastRevealedCells[0] != -1 && cpuPlayer.lastRevealedCells[1] != -1)
            {
                // draw the border to the last selected (revealed) cell
                Draw.BorderToCell(cpuPlayer.lastRevealedCells[0], cpuPlayer.lastRevealedCells[1], this, e);
            }
        }

        private void playersFieldPbox_Paint(object sender, PaintEventArgs e)
        {
            // draw the ships to the field
            Draw.SetOfShips(myPlayer.setOfShips, e);
            // draw the right image to the cell
            Draw.SetRightImgToCell(myPlayer.revealedCells, myPlayer.setOfShips, e);
            if (myPlayer.lastRevealedCells[0] != -1 && myPlayer.lastRevealedCells[1] != -1)
            {
                // draw the border to the last selected (revealed) cell
                Draw.BorderToCell(myPlayer.lastRevealedCells[0], myPlayer.lastRevealedCells[1], this, e);
            }
        }

        private void newGameLabel_MouseHover(object sender, EventArgs e)
        {
        }

        private void newGameLabel_Click(object sender, EventArgs e)
        {
            // New Game Label
            newGameLabel.Visible = false;
            timeTakenLabel.Visible = false;
            timeLabel.Visible = false;
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
            Game.timeToTheEnd += 1;
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Game.ActionToDatabase("insertdb", myPlayer);

            ////Before the form closed, save to db the stats
            //if (Game.winner)
            //{

            //    Game.ActionToDatabase("insertdb", myPlayer);
            //}
            //else
            //{
            //    Game.ActionToDatabase("insertdb", cpuPlayer);
            //}
            

        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Before the form closed, save to db the stats
            if (Game.winner)
            {
                // if winner is player
                Game.ActionToDatabase("insertdb", myPlayer);
            }
            else
            {
                // if winner is cpu
                Game.ActionToDatabase("insertdb", cpuPlayer);
            }

            Application.Exit();
        }

    }
}