namespace BattleshipGame
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // CREATE TABLE IF NOT EXISTS
            Game.ActionToDatabase("createdb", Game.myPlayer);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // initialize players from Game class
            Game.myPlayer = new Player();
            Game.cpuPlayer = new Player();
            // Set the player's name
            Game.myPlayer.playersName = playersNameTbox.Text;
            // Set the name for computer
            Game.cpuPlayer.playersName = "CPU";


            GameForm game = new GameForm();
            game.Location = Location;
            game.Show();

            Hide();

            //Dispose();
        }

        private void viewGameStatsBtn_Click(object sender, EventArgs e)
        {
            Game.ActionToDatabase("selectdb", Game.myPlayer);
            
        }

    }
}
