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
        // game object
        private static Game _game = new Game();
        
        // for drag drop
        private Size dragSize = SystemInformation.DragSize;
        private Rectangle dragBounds = Rectangle.Empty;

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

        // Draw Game Table
        private void DrawGameTable()
        {
            drawGameTitle();

            // Draw Deck
            printCards( _game.GameDeck, rtbDeck );

            // Draw discard pile
            printCards( _game.DiscardPile, rtbDiscardPile );

            // draw player scores
            printPlayerScores( _game );

            // Draw Player Names
            drawPlayerNames();

            // Draw player hand
            drawPlayerHands();

            // Draw player table hands
            drawPlayerTableHands();
        }

        private void drawPlayerTableHands()
        {
            // loop through all players
            for ( int i = 0; i < _game.Players.Count; i++ )
            {
                // loop through all table hands (where players lay cards)
                for ( int j = 0; j < 4; j++ )
                {
                    // check if table hand has cards
                    if ( _game.Players[i].TableHands[0].Count > 0 )
                    {
                        // build name of table hand text control. add 1 to each index to get correct player / table hand
                        string tableHand = "rtbPlayer" + (i + 1) + "Table" + (j +1);

                        // find table control
                        RichTextBox rtbTableHand = ( RichTextBox ) this.Controls.Find( tableHand, true ).FirstOrDefault();

                        // center text
                        rtbTableHand.SelectionAlignment = HorizontalAlignment.Center;

                        // print hand to box
                        printCards( _game.Players[i].TableHands[j], rtbTableHand );
                    }
                }
            }
        }

        // Draw player hands
        private void drawPlayerHands()
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

                        // center text
                        rtbPlayerHand.SelectionAlignment = HorizontalAlignment.Center;

                        // add events if current turn (remove event and add each round to fix timing issue)
                        if ( _game.Players[i].CurrentTurn == true )
                        {
                            // add discard click event
                            rtbPlayerHand.Click -= btnDiscard_Click;
                            rtbPlayerHand.Click += btnDiscard_Click;

                            // add drag drop events
                            rtbPlayerHand.MouseDown -= rtbPlayerHand_MouseDown;
                            rtbPlayerHand.MouseMove -= rtbPlayerHand_MouseMove;
                            rtbPlayerHand.DragEnter -= rtbPlayerHand_DragEnter;
                            rtbPlayerHand.DragDrop -= rtbPlayerHand_DragDrop;

                            rtbPlayerHand.MouseDown += rtbPlayerHand_MouseDown;
                            rtbPlayerHand.MouseMove += rtbPlayerHand_MouseMove;
                            rtbPlayerHand.AllowDrop = true;
                            rtbPlayerHand.DragEnter += rtbPlayerHand_DragEnter;
                            rtbPlayerHand.DragDrop += rtbPlayerHand_DragDrop;
                        }
                        else
                        {
                            // remove events from textbox
                            rtbPlayerHand.Click -= btnDiscard_Click;
                            rtbPlayerHand.MouseDown -= rtbPlayerHand_MouseDown;
                            rtbPlayerHand.MouseMove -= rtbPlayerHand_MouseMove;
                            rtbPlayerHand.AllowDrop = false;
                            rtbPlayerHand.DragEnter -= rtbPlayerHand_DragEnter;
                            rtbPlayerHand.DragDrop -= rtbPlayerHand_DragDrop;
                        }

                        // card info to display
                        string displayText = _game.Players[i].Hand[j].ShortName;

                        // add text to control
                        rtbPlayerHand.AppendText( displayText );
                    }
                }
            }
        }

        private void rtbPlayerHand_MouseDown( object sender, MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
            {
                // left mouse button was clicked, set rectangle location where mouse was clicked
                dragBounds = new Rectangle(new Point(e.X - dragSize.Width / 2, e.Y - dragSize.Height / 2), dragSize);
            }
            else
            {
                // button was clicked, clear dragBounds
                dragBounds = Rectangle.Empty;
            }
        }

        private void rtbPlayerHand_MouseMove( object sender, MouseEventArgs e )
        {
            // check if left mouse button was clicked and was moved
            if ( e.Button == MouseButtons.Left && dragBounds != Rectangle.Empty && !dragBounds.Contains(e.X, e.Y ))
            {
                // set sender control
                RichTextBox rtbControl = ( RichTextBox ) sender;

                // start drag drop event passing control name
                rtbControl.DoDragDrop( rtbControl.Name, DragDropEffects.Move );
                
                // clear dragBounds
                dragBounds = Rectangle.Empty;
            }
        }

        private void rtbPlayerHand_DragDrop( object sender, DragEventArgs e )
        {
            // set sender control
            RichTextBox rtbControl = ( RichTextBox ) sender;

            // get player of new card and old card
            int newCardPlayer = Convert.ToInt32(extractPlayerNumberHand(e.Data.GetData(DataFormats.Text).ToString()));
            int oldCardPlayer = Convert.ToInt32(extractPlayerNumberHand( rtbControl.Name ));

            // check that player index is the same
            if ( newCardPlayer == oldCardPlayer )
            {
                // get card number of new and old card
                int newCard = Convert.ToInt32( extractHandNumberHand( e.Data.GetData( DataFormats.Text ).ToString() ));
                int oldCard = Convert.ToInt32( extractHandNumberHand( rtbControl.Name ) );

                // check that the card numbers are different
                if ( newCard != oldCard )
                {
                    // move the cards in the players hand
                    _game = GameManagement.MoveCardInHand( _game, newCardPlayer, newCard, oldCard );
                }            
            }

            // Redraw game table
            DrawGameTable();
        }

        private void rtbPlayerHand_DragEnter( object sender, DragEventArgs e )
        {
            // test if the control accepts the format being dragged
            if ( e.Data.GetDataPresent( DataFormats.Text ) )
            {
                // if so, show move effect
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                // if not, show no effect
                e.Effect = DragDropEffects.None;
            }
        }

        // Draw player names
        private void drawPlayerNames()
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
                
                // Update text with player name (for testing include card count
                rtbPlayerName.Text = String.Format("{0} ({1})", _game.Players[i].Name, _game.Players[i].Hand.Count);
                
                // Change background color of dealer
                if ( _game.Players[i].IsDealer == true )
                {                
                    rtbPlayerName.BackColor = Color.SlateBlue;
                }
                
                // Change background color of current turn
                if( _game.Players[i].CurrentTurn == true )
                {
                    rtbPlayerName.BackColor = Color.Aquamarine;
                }

                // Change background color of buyer to green
                if ( _game.Players[i].IsBuyer == true )
                {
                    rtbPlayerName.BackColor = Color.Green;
                }
            }
        }

        // guessing this doesnt need comments...
        private void drawGameTitle()
        {
            string gameTitle = "";

            switch ( _game.Round )
            {
                case Rounds.NotStarted:
                     gameTitle = "Game Not Yet Started";
                    break;
                case Rounds.TwoSetsOneRun:
                    gameTitle = "Two Sets One Run";
                    break;
                case Rounds.TwoRunsOneSet:
                    gameTitle = "Two Runs One Set";
                    break;
                case Rounds.ThreeSets:
                    gameTitle = "Three Sets";
                    break;
                case Rounds.ThreeRuns:
                    gameTitle = "Three Runs";
                    break;
                case Rounds.ThreeSetsOneRun:
                    gameTitle = "Three Sets One Run";
                    break;
                case Rounds.TwoSetsTwoRuns:
                    gameTitle = "Two Sets Two Runs";
                    break;
                case Rounds.FourSets:
                    gameTitle = "Four Sets";
                    break;
                case Rounds.Ended:
                    {
                        Player winner = _game.Players.Where( x => x.IsWinner == true ).FirstOrDefault();
                        if( winner != null )
                        {
                            lblGameRound.Text = String.Format("Game Ended: {0} is Winner!", winner.Name);
                        }
                        else
                        {
                            lblGameRound.Text = "Game Ended: Missing Winner Error";
                        }
                        break;
                    }
                default:
                    lblGameRound.Text = "Error getting game round";
                    break;
            }

            lblGameRound.Text = String.Format( "{0} ({1})", gameTitle, _game.GameDeck.Cards.Count );
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

        // print deck cards to RichTextBox control
        private void printCards( List<Card> hand, RichTextBox richTextBox )
        {
            // Clear textbox
            richTextBox.Clear();
            string displayText = "";

            // check for cards in deck
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

        private void printPlayerScores(Game game )
        {
            // clear current text
            rtbPlayerScores.Clear();

            // loop through all players
            foreach ( Player player in game.Players )
            {
                // build player score
                string scoreBoard = String.Format( "{0} - {1}", player.Name, player.Score );

                // add player score and new line
                rtbPlayerScores.AppendText( scoreBoard + Environment.NewLine );
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
                changeTurn( currentPlayerIndex );
            }

            // Deal
            _game = GameManagement.Deal( _game );
            
            // Hide deal / shuffle buttons
            btnDeal.Visible = false;
            btnPickDealer.Visible = false;
            btnRifleShuffle.Visible = false;
            btnOverhandShuffle.Visible = false;
            btnAdvDealer.Visible = false;

            // show reset cards button
            btnResetCards.Visible = true;
            
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
            int playerNumber = Convert.ToInt32(extractPlayerNumber( control.Name.ToString() ));

            // draw card
            _game = GameManagement.DrawCard( _game, playerNumber );

            // hide draw buttons
            hideDrawButtons( playerNumber );

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
                int playerNumber = Convert.ToInt32( extractPlayerNumber( control.Name.ToString() ) );

                // draw from discard pile
                _game = GameManagement.DrawDiscardCard( _game, playerNumber );

                // hide draw buttons
                hideDrawButtons( playerNumber );

                // hide AllowBuy button
                hideButton( "AllowBuy", playerNumber );

                // reset IsBuyer incase someone clicked buy, but didnt get the card
                _game = Player.ResetIsBuyer( _game );

                // Redraw Table
                DrawGameTable();
            }
        }

        private void btnDiscard_Click( object sender, EventArgs e )
        {
            // get control that was clicked
            RichTextBox rtbCard = ( RichTextBox ) sender;
            
            // get playerIndex for array from control name
            int playerIndex = (Convert.ToInt32( extractPlayerNumberHand( rtbCard.Name.ToString() ) ) -1);

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
                changeTurn( playerIndex );

                // Redraw Table
                DrawGameTable();
            }
            else
            {
                return;
            }
        }

        private void btnBuy_Click( object sender, EventArgs e )
        {
            // Get button that clicked
            Button button = ( Button ) sender;

            // get playerIndex for array from control name ( index is 1 less than player number)
            int playerIndex = ( Convert.ToInt32( extractPlayerNumber( button.Name.ToString() ) ) - 1 );

            // Check if someone else has already clicked buy
            List<Player> currentBuyer = _game.Players.Where( x => x.IsBuyer == true ).ToList();

            // If there is already currentBuyer, return
            if ( currentBuyer.Count == 0 )
            {
                // Set IsBuyer for player that clicked buy
                _game.Players[playerIndex].IsBuyer = true;

                // Get the current turn player
                Player currentTurnPlayer = _game.Players.Where( x => x.CurrentTurn == true ).FirstOrDefault();

                // Hide draw and show the allow buy button of the current player
                if ( currentTurnPlayer != null )
                {
                    // hide draw button
                    hideButton( "Draw", currentTurnPlayer.SeatNumber );
                    // show allow buy button
                    showButton( "AllowBuy", currentTurnPlayer.SeatNumber );
                }
            }
            else
            {
                return;
            }

            // Redraw game table
            DrawGameTable();
        }

        private void btnAllowBuy_Click( object sender, EventArgs e )
        {
            // Get button that clicked
            Button button = ( Button ) sender;

            // get playerIndex for array from button name ( index is 1 less than player number)
            int currentPlayer = Convert.ToInt32( extractPlayerNumber( button.Name.ToString() ) );

            // get Buyer
            Player buyer = _game.Players.Where( x => x.IsBuyer == true ).FirstOrDefault();

            if ( buyer != null )
            {
                // Buyer buys card
                _game = GameManagement.BuyCard( _game, (buyer.SeatNumber -1) );

                // Hide Allow Buy button
                hideButton( "AllowBuy", currentPlayer );

                // Show Draw button
                showButton( "Draw", currentPlayer );

                // reset isBuyer
                _game = Player.ResetIsBuyer( _game );
            }
            else
            {
                // no buyer, error
                return;
            }

            // discard given to buyer so hide draw discard button
            hideButton( "DrawDiscard", currentPlayer );

            // redraw buy buttons to hide if persons is out of buys
            drawBuyButtons();

            // Redraw table
            DrawGameTable();
        }

        private void btnResetCards_Click( object sender, EventArgs e )
        {
            // Move all cards back to deck
            _game = GameManagement.MoveAllCardsBackToDeck( _game );

            // unhide buttons
            btnRifleShuffle.Visible = true;
            btnOverhandShuffle.Visible = true;
            btnDeal.Visible = true;
            btnAdvDealer.Visible = true;

            // hide reset button
            btnResetCards.Visible = false;

            // Redraw game table
            DrawGameTable();
        }

        private void btnTallyScore_Click( object sender, EventArgs e )
        {
            // total scores
            _game = GameManagement.CalculateRoundScores( _game );

            // Redraw game table
            DrawGameTable();
        }

        private void btnAdvDealer_Click( object sender, EventArgs e )
        {
            // this button is for testing

            // advance dealer
            _game = GameManagement.AdvancedDealer( _game );

            // clear current turn
            _game = Player.ResetCurrentTurn( _game );

            // redraw game table
            DrawGameTable();
        }

        private void changeTurn(int currentPlayerIndex )
        {
            int nextPlayerIndex = (currentPlayerIndex +1) % _game.Players.Count;

            // set current player currentTurn false
            _game.Players[currentPlayerIndex].CurrentTurn = false;
            // set next player currentTurn true
            _game.Players[nextPlayerIndex].CurrentTurn = true;

            // Draw draw buttons for next player (remember player index is 1 less then player number)
            drawDrawButtons( nextPlayerIndex + 1 );

            // Double check only 1 current player was set
            List<Player> currentPlayers = _game.Players.Where( a => a.CurrentTurn == true ).ToList();
            if ( currentPlayers.Count != 1 )
            {
                // return if no current player or more than 1 current player found
                MessageBox.Show( "Error setting draw button for current turn", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error );
                return;
            }

            // Draw buy buttons
            drawBuyButtons();
        }

        private void drawDrawButtons(int player)
        {
            // Show draw button
            showButton( "Draw", player );

            // if cards in discard pile show draw discard button
            if ( _game.DiscardPile.Cards.Count > 0 )
            {
                // Show Draw Dicard button
                showButton( "DrawDiscard", player );
            }
        }

        private void drawBuyButtons()
        {   
            // Show Buy Buttons for all players but the current turn player
            foreach ( Player player in _game.Players )
            {
                // If player has 17 cards, hide the buy button
                if ( player.Hand.Count != 17 )
                {
                    if ( player.CurrentTurn == false )
                    {
                        // show Buy button
                        showButton( "Buy", player.SeatNumber );
                    }
                    else
                    {
                        // hide Buy button
                        hideButton( "Buy", player.SeatNumber );
                    }
                }
                else
                {
                    hideButton( "Buy", player.SeatNumber );
                }
            }
        }

        private void hideButton( string buttonType, int playerNumber )
        {
            // build button name
            string buttonName = "btnPlayer" + playerNumber.ToString() + buttonType;

            // find button control
            Button button = ( Button ) this.Controls.Find( buttonName, true ).FirstOrDefault();

            // hide button
            button.Visible = false;
        }

        private void showButton( string buttonType, int playerNumber )
        {
            // build button name
            string buttonName = "btnPlayer" + playerNumber.ToString() + buttonType;

            // find button control
            Button button = ( Button ) this.Controls.Find( buttonName, true ).FirstOrDefault();

            // show button
            button.Visible = true;
        }

        private void hideBuyButtons()
        {
            // Hide Buy Buttons for all players
            foreach ( Player player in _game.Players )
            {
                hideButton( "Buy", player.SeatNumber );
            }
        }

        private void hideDrawButtons(int playerNumber )
        {
            // Hide draw buttons
            hideButton( "Draw", playerNumber );
            hideButton( "DrawDiscard", playerNumber );
        }

        // Get player number from string and return only number
        private string extractPlayerNumber( string original )
        {
            return new string( original.Where( c => Char.IsDigit( c ) ).ToArray() );
        }

        // Get player number from hand control (control has multiple numbers, we need the number after Hand
        private string extractPlayerNumberHand( string original )
        {
            string[] number = original.Split( 'H' );

            return new string( number[0].Where( c => Char.IsDigit( c ) ).ToArray() );
        }

        // Get hand number from hand control (control has multiple numbers, we need the number after Hand
        private string extractHandNumberHand( string original )
        {
            string[] number = original.Split( 'd' );

            return new string( number[1].Where( c => Char.IsDigit( c ) ).ToArray() );
        }


    }
}
