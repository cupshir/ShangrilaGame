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
        // Create game and discard pile objects
        static Game _game = new Game();
        static List<Card> discardPile = new List<Card>();
        
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
            printCards( discardPile, rtbDiscardPile );

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
                        
                        // Clear existing text
                        rtbPlayerHand.Clear();
                        
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
                        string displayText = _game.Players[i].Hand[j].ShortName + _game.Players[i].Hand[j].Suit[0];
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
            if ( _game.GameDeck.Cards.Count > 0 )
            {
                // loop through each card
                foreach ( Card card in _game.GameDeck.Cards )
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
                    displayText = card.ShortName + card.Suit[0] + " ";
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

        // print List<Card> to RichTextBox control
        private void printCards(List<Card> hand, RichTextBox richTextBox)
        {
            // Clear textbox
            string displayText = "";
            richTextBox.Clear();

            // check for cards in list
            if ( hand.Count > 0 )
            {
                // loop through each card
                foreach ( Card card in hand )
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
                    displayText = card.ShortName + card.Suit[0] + " ";
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

                // current player array index
                int currentPlayerIndex;

                // set currentTurn for player after dealer
                if ( dealer.SeatNumber == _game.Players.Count )
                {
                    // Since dealer is last player, current player will be the first player
                    _game.Players[0].CurrentTurn = true;
                    
                    // Find the draw control
                    Button btnPlayerDraw = ( Button ) this.Controls.Find( "btnPlayer1Draw", true ).FirstOrDefault();
                    // Show Draw button
                    btnPlayerDraw.Visible = true;
                }
                else
                {
                    // to reduce confusion set current player index to dealer seat number (seat numbers do not match array index)
                    currentPlayerIndex = dealer.SeatNumber;
                    // Player after dealer is current player, remember seatnumber and array index are different
                    _game.Players[currentPlayerIndex].CurrentTurn = true;
                    
                    // build control name, ie btnPlayer1Draw. remember array index is not same as player/seat number
                    string buttonName = "btnPlayer" + ( currentPlayerIndex + 1 ) + "Draw";
                    // Find the control
                    Button btnPlayerDraw = ( Button ) this.Controls.Find( buttonName, true ).FirstOrDefault();
                    // Show Draw button
                    btnPlayerDraw.Visible = true;
                }

                // Double check 1 current player was set
                List<Player> currentPlayers = _game.Players.Where( a => a.CurrentTurn == true ).ToList();
                if ( currentPlayers.Count != 1 )
                {
                    // return if no current player or more than 1 current player found
                    MessageBox.Show( "Error setting draw button for current turn", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error );
                    return;
                }
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
            _game = GameManagement.DetermineDealer( _game );
            DrawGameTable();
        }

        private void btnOverhandShuffle_Click( object sender, EventArgs e )
        {
            _game.GameDeck = Deck.OverhandShuffleDeck( _game.GameDeck );
            DrawGameTable();
        }

        private void btnRiffleShuffle_Click( object sender, EventArgs e )
        {
            _game.GameDeck = Deck.RiffleShuffleDeck( _game.GameDeck );
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

            // get top card from deck
            Card card = _game.GameDeck.Cards[0];

            // add card to player hand
            _game.Players[(playerNumber-1)].Hand.Add( card );
            // remove card from deck
            _game.GameDeck.Cards.Remove( card );

            // hide draw button
            control.Visible = false;

            // control name of discard button
            string discardName = "btnPlayer" + playerNumber + "Discard";
            // find discard control
            Button discardButton = ( Button ) this.Controls.Find( discardName, true ).FirstOrDefault();
            // show discard button
            discardButton.Visible = true;

            // Redraw table
            DrawGameTable();
        }

        // Get number from string and return only number
        private string ExtractNumber(string original )
        {
            return new string( original.Where( c => Char.IsDigit( c ) ).ToArray() );
        }
    }
}
