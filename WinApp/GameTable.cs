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
    public partial class GameTable : Form
    {
        static Game _game = new Game();
        
        public GameTable()
        {
        }

        public GameTable(Game game)
        {
            InitializeComponent();
            // set _game object
            _game = game;

            // Draw game table
            DrawGameTable();
        }

        // Draw Game Table without drawing Hands
        private void DrawGameTable()
        {
            // Draw Deck
            printCards( _game.GameDeck, rtbDeck );

            // Draw discard pile
            printCards( _game.DiscardPile, rtbDiscardPile );

            // Draw Player Names
            DrawPlayerNames();

            // Draw player hand
            DrawPlayerHands();
        }

        // Draw player hands
        private void DrawPlayerHands()
        {
            // Loop through all players
            for ( int i = 0; i < _game.Players.Count ; i++ )
            {
                // Clear existing text in all text boxes
                for ( int k = 1; k < 19; k++ )
                {
                    string rtbControlName = "rtbPlayer" + ( i + 1 ) + "Hand" + ( k );
                    RichTextBox rtbControl = ( RichTextBox ) this.Controls.Find( rtbControlName, true ).FirstOrDefault();
                    rtbControl.Clear();
                }

                // Ensure there are cards in the players hand
                if ( _game.Players[i].Hand.Count > 0 )
                {
                    // Loop through each card in player hand
                    for ( int j = 0; j < _game.Players[i].Hand.Count; j++ )
                    {
                        // build name of control. IE rtbPlayer1Hand1
                        string controlName = "rtbPlayer" + ( i + 1 ) + "Hand" + ( j + 1 );
                        // Find the control
                        RichTextBox rtbPlayerHand = ( RichTextBox )this.Controls.Find( controlName, true ).FirstOrDefault();
                                                
                        // Set text color to red for Hearts / Diamonds suit and black for Spades / Clubs suit
                        if ( _game.Players[i].Hand[j].Suit == "Hearts" || _game.Players[i].Hand[j].Suit == "Diamonds" )
                        {
                            rtbPlayerHand.SelectionColor = Color.Red;
                        }
                        else
                        {
                            rtbPlayerHand.SelectionColor = Color.Black;
                        }
                        
                        // card info to display
                        string displayText = _game.Players[i].Hand[j].ShortName;
                        // add text to control
                        rtbPlayerHand.AppendText( displayText );
                    }
                }
            }
        }

        // Draw player names
        private void DrawPlayerNames()
        {
            // Loop through players
            for ( int i = 0; i < _game.Players.Count; i++ )
            {
                // build name of control.  IE rtbPlayer1Name 
                string controlName = "rtbPlayer" + ( i + 1 ).ToString() + "Name";
                // Find the Control
                RichTextBox rtbPlayerName = (RichTextBox)this.Controls.Find( controlName, true ).FirstOrDefault();
                
                // Reset background color to default
                rtbPlayerName.BackColor = SystemColors.Control;
                
                // Update text with player name
                rtbPlayerName.Text = _game.Players[i].Name;
                
                // Change background color of dealer
                if ( _game.Players[i].IsDealer == true )
                {                
                    rtbPlayerName.BackColor = Color.SlateBlue;
                }
                
                // Change background color of current turn and show draw button
                if( _game.Players[i].CurrentTurn == true )
                {
                    rtbPlayerName.BackColor = Color.Aquamarine;
                }
            }
        }

        // print deck cards to RichTextBox control
        private void printCards(Deck deck, RichTextBox richTextBox)
        {
            // Clear textbox
            richTextBox.Clear();
            string displayText = "";

            // check for cards in deck
            if ( deck.Cards.Count > 0 )
            {
                // loop through each card
                foreach ( Card card in deck.Cards )
                {
                    // Set text color to red for Hearts / Diamonds suit and black for Spades / Clubs suit
                    if ( card.Suit == "Hearts" || card.Suit == "Diamonds" )
                    {
                        richTextBox.SelectionColor = Color.Red;
                    }
                    else
                    {
                        richTextBox.SelectionColor = Color.Black;
                    }
                    
                    // Create short card name and append to control
                    displayText = card.ShortName + " ";
                    richTextBox.AppendText( displayText );
                }
            }
            else
            {
                // display if no cards
                displayText = "No cards to display";
                richTextBox.AppendText( displayText );
            }
        }

        private void btnDeal_Click( object sender, EventArgs e )
        {
            // Check for a dealer
            List<Player> dealers = _game.Players.Where( a => a.IsDealer == true ).ToList();
            if ( dealers.Count != 1 )
            {
                // return if no dealer or more than 1 dealer found
                MessageBox.Show( "A dealer has not been choosen", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error );
                return;
            }
            else
            {
                // get dealer object
                Player dealer = dealers.FirstOrDefault();

                // dealer array index (dealer seat number is 1 greater than array index)
                int currentPlayerIndex = dealer.SeatNumber - 1;

                // Make next player current turn
                ChangeTurn( currentPlayerIndex );
            }

            // Deal
            _game = GameManagement.Deal( _game );
            
            // Hide deal / shuffle buttons
            btnDeal.Visible = false;
            btnPickDealer.Visible = false;
            btnRifleShuffle.Visible = false;
            btnOverhandShuffle.Visible = false;
            
            // Redraw table
            DrawGameTable();
        }

        private void btnPickDealer_Click( object sender, EventArgs e )
        {
            // pick dealer
            _game = GameManagement.DetermineDealer( _game );

            // Redraw table
            DrawGameTable();
        }

        private void btnOverhandShuffle_Click( object sender, EventArgs e )
        {
            // Overhand shuffle
            _game.GameDeck = Deck.OverhandShuffleDeck( _game.GameDeck );

            // Redraw table
            DrawGameTable();
        }

        private void btnRiffleShuffle_Click( object sender, EventArgs e )
        {
            // riffle shuffle
            _game.GameDeck = Deck.RiffleShuffleDeck( _game.GameDeck );

            // redraw table
            DrawGameTable();
        }

        // Exit App
        private void btnClose_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void btnDraw_Click( object sender, EventArgs e )
        {
            // Get button that clicked draw
            Button control = ( Button )sender;

            // get playernumber from button
            int playerNumber = Convert.ToInt32(ExtractNumber( control.Name.ToString() ));

            // draw card
            _game = GameManagement.DrawCard( _game, playerNumber );

            // hide draw buttons
            HideDrawButtons( playerNumber );

            // Redraw table
            DrawGameTable();
        }

        private void btnDrawDiscard_Click( object sender, EventArgs e )
        {
            // check for cards in discard pile
            if ( _game.DiscardPile.Cards.Count > 0 )
            {
                // Get button that clicked draw
                Button control = ( Button ) sender;

                // get playernumber from button
                int playerNumber = Convert.ToInt32( ExtractNumber( control.Name.ToString() ) );

                // draw from discard pile
                _game = GameManagement.DrawDiscardCard( _game, playerNumber );

                // hide draw buttons
                HideDrawButtons( playerNumber );

                // Redraw Table
                DrawGameTable();
            }
        }

        private void btnDiscard_Click( object sender, EventArgs e )
        {
            // get control that was clicked
            RichTextBox rtbCard = ( RichTextBox ) sender;
            
            // get playerIndex for array from control name
            int playerIndex = (Convert.ToInt32( ExtractNumberHand( rtbCard.Name.ToString() ) ) -1);

            // check that it is the current players turn 
            // that the card text box wasnt empty 
            // that they have even number of cards
            if ( _game.Players[playerIndex].CurrentTurn == true && rtbCard.Text != "" && ( _game.Players[playerIndex].Hand.Count % 2 ) == 0 )
            {
                // get card to discard
                Card discardCard = _game.Players[playerIndex].Hand.Where( x => x.ShortName == rtbCard.Text ).FirstOrDefault();

                // discard card
                if ( discardCard != null )
                {
                    _game = GameManagement.DiscardCard( _game, playerIndex, discardCard );
                }

                // Change current turn to next player
                ChangeTurn( playerIndex );

                // Redraw Table
                DrawGameTable();
            }
            else
            {
                return;
            }
        }

        private void ChangeTurn(int currentPlayerIndex )
        {
            int nextPlayerIndex = (currentPlayerIndex +1) % _game.Players.Count;

            // set current player currentTurn false
            _game.Players[currentPlayerIndex].CurrentTurn = false;
            // set next player currentTurn true
            _game.Players[nextPlayerIndex].CurrentTurn = true;

            // Draw draw buttons for next player (remember player index is 1 less then player number)
            DrawDrawButtons( nextPlayerIndex + 1 );

            // Double check only 1 current player was set
            List<Player> currentPlayers = _game.Players.Where( a => a.CurrentTurn == true ).ToList();
            if ( currentPlayers.Count != 1 )
            {
                // return if no current player or more than 1 current player found
                MessageBox.Show( "Error setting draw button for current turn", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error );
                return;
            }

            // Draw buy buttons
            DrawBuyButtons();
        }

        private void DrawDrawButtons(int player)
        {
            // show controls for player
            // build control name for player, ie btnPlayer2Draw.
            string buttonName = "btnPlayer" + ( player ) + "Draw";
            // Find the control
            Button btnPlayerDraw = ( Button ) this.Controls.Find( buttonName, true ).FirstOrDefault();
            // Show Draw button
            btnPlayerDraw.Visible = true;

            // if cards in discard pile show draw discard button
            if ( _game.DiscardPile.Cards.Count > 0 )
            {
                // build control name for next player, ie btnPlayer2DrawDiscard
                buttonName = "btnPlayer" + ( player ) + "DrawDiscard";
                // Find the control
                Button btnPlayerDrawDiscard = ( Button ) this.Controls.Find( buttonName, true ).FirstOrDefault();
                // Show Draw Dicard button
                btnPlayerDrawDiscard.Visible = true;
            }
        }

        private void DrawBuyButtons()
        {   
            // Show Buy Buttons for all players but the current turn player
            foreach ( Player player in _game.Players )
            {
                // build control name for Buy button, ie btnPlayer2Buy
                string buttonName = "btnPlayer" + ( player.SeatNumber ) + "Buy";
                // Find the control
                Button btnPlayerBuy = ( Button ) this.Controls.Find( buttonName, true ).FirstOrDefault();

                if ( player.CurrentTurn == false )
                {
                    // Show Buy button
                    btnPlayerBuy.Visible = true;
                }
                else
                {
                    // hide Buy button
                    btnPlayerBuy.Visible = false;
                }
            }
        }

        private void HideBuyButtons()
        {
            // Hide Buy Buttons for all players
            foreach ( Player player in _game.Players )
            {
                // build control name for Buy button, ie btnPlayer2Buy
                string buttonName = "btnPlayer" + ( player.SeatNumber ) + "Buy";
                // Find the control
                Button btnPlayerBuy = ( Button ) this.Controls.Find( buttonName, true ).FirstOrDefault();

               // hide buy button
                btnPlayerBuy.Visible = false;                
            }
        }

        private void HideDrawButtons(int playerNumber )
        {
            // draw button name
            string drawName = "btnPlayer" + playerNumber + "Draw";
            // find draw control
            Button drawButton = ( Button ) this.Controls.Find( drawName, true ).FirstOrDefault();
            // hide draw button
            drawButton.Visible = false;

            // draw discard button name
            string discardName = "btnPlayer" + playerNumber + "DrawDiscard";
            // find draw discard control
            Button drawDiscardButton = ( Button ) this.Controls.Find( discardName, true ).FirstOrDefault();
            // hide draw discard button
            drawDiscardButton.Visible = false;
        }

        // Get number from string and return only number
        private string ExtractNumber( string original )
        {
            return new string( original.Where( c => Char.IsDigit( c ) ).ToArray() );
        }

        // Get number from hand control (control has multiple numbers, we need the number before Hand
        private string ExtractNumberHand( string original )
        {
            string[] number = original.Split( 'H' );

            return new string( number[0].Where( c => Char.IsDigit( c ) ).ToArray() );
        }
    }
}
