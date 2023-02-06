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

        public GameForm()
        {
            InitializeComponent();

            mouseCellX = -1;
            mouseCellY = -1;

            currentShip = -1; // -1 for none
            shipRotation = true; // true for vertical

            // GameForm Settings
            this.MaximizeBox = false;
            //this.CenterToScreen(1);

            Cell.DefineCell();
        }

        private void enemysFieldPbox_Click(object sender, EventArgs e)
        {
  
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
            MessageBox.Show(Draw.GetX(this, enemysFieldPbox).ToString() + Environment.NewLine + Draw.GetY(this, enemysFieldPbox).ToString());

            
            
        }

        private void enemysFieldPbox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}