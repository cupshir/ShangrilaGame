using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCore;

namespace WinApp
{
    public partial class StartGameForm : Form
    {
        public StartGameForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click( object sender, EventArgs e )
        {
            // check if text boxes have user input
            if ( tbPlayer1Name.Text == ""
                || tbPlayer2Name.Text == ""
                || tbPlayer3Name.Text == ""
                || tbPlayer4Name.Text == ""
                || tbPlayer5Name.Text == ""
                || tbPlayer6Name.Text == ""
                || tbPlayer7Name.Text == "" )
            {
                MessageBox.Show( "Please enter a name for all players", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error );
                return;
            }

            // Create list of players
            List<Player> players = new List<Player>();

            // Populate list of players
            Player player1 = Player.CreatePlayer( tbPlayer1Name.Text, 1 );
            player1.SeatNumber = 1;
            players.Add( player1 );
            Player player2 = Player.CreatePlayer( tbPlayer2Name.Text, 2 );
            player2.SeatNumber = 2;
            players.Add( player2 );
            Player player3 = Player.CreatePlayer( tbPlayer3Name.Text, 3 );
            player3.SeatNumber = 3;
            players.Add( player3 );
            Player player4 = Player.CreatePlayer( tbPlayer4Name.Text, 4 );
            player4.SeatNumber = 4;
            players.Add( player4 );
            Player player5 = Player.CreatePlayer( tbPlayer5Name.Text, 5 );
            player5.SeatNumber = 5;
            players.Add( player5 );
            Player player6 = Player.CreatePlayer( tbPlayer6Name.Text, 6 );
            player6.SeatNumber = 6;
            players.Add( player6 );
            Player player7 = Player.CreatePlayer( tbPlayer7Name.Text, 7 );
            player7.SeatNumber = 7;
            players.Add( player7 );
            
            // Create a game with players and 3 decks
            Game game = GameManagement.CreateGame( players, 3 );

            // Create new GameTable form
            Form gameTable = new GameTable( game );

            // Set form to same hidght and width of current form
            gameTable.Width = this.Width;
            gameTable.Height = this.Height;
            gameTable.StartPosition = FormStartPosition.Manual;
            gameTable.Location = new Point( this.Location.X, this.Location.Y );

            // Show GameTable form and close current form
            gameTable.Show();
            this.Close();
        }

        // Delete after testing
        private void btnTestFill_Click( object sender, EventArgs e )
        {
            tbPlayer1Name.Text = "Christopher";
            tbPlayer2Name.Text = "Carissa";
            tbPlayer3Name.Text = "Maddie";
            tbPlayer4Name.Text = "Doug";
            tbPlayer5Name.Text = "Box";
            tbPlayer6Name.Text = "Nicki";
            tbPlayer7Name.Text = "Damien";
        }

        // Exit application
        private void btnCancel_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }
    }
}
