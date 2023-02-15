using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //Game.Initialize();
            Game.myPlayer = new Player();
            Game.cpuPlayer = new Player();
            // Set the player's name
            Game.myPlayer.playersName = playersNameTbox.Text;
            // Set the name for computer
            Game.cpuPlayer.playersName = "Computer";


            GameForm game = new GameForm();
            game.Location = Location;
            game.Show();

            Hide();

            //Dispose();
        }
    }
}
