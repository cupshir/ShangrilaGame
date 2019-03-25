using System;
using UIKit;
using CoreGraphics;
using System.Collections.Generic;
using ShangrilaRummy.Model;
using ShangrilaRummy.Service;
using System.Linq;
using Foundation;

namespace ShangrilaRummy
{
    public class GameBoardViewController : UIViewController
    {
        Game _game;

        nfloat viewWidth;
        nfloat viewHeight;


        CardView GameDeckCardView;
        CardView DiscardPileCardView;

        List<CardView> PlayerHandCardViews;

        // probably temporary
        List<UILabel> OtherPlayersCardViews;

        List<CardGroupView> Player1TableCardGroups;
        List<CardGroupView> Player2TableCardGroups;
        List<CardGroupView> Player3TableCardGroups;
        List<CardGroupView> Player4TableCardGroups;
        List<CardGroupView> Player5TableCardGroups;
        List<CardGroupView> Player6TableCardGroups;
        List<CardGroupView> Player7TableCardGroups;

        public GameBoardViewController()
        {
        }

        public override void LoadView()
        {
            base.LoadView();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.LightGray;

            viewWidth = UIScreen.MainScreen.Bounds.Width;
            viewHeight = UIScreen.MainScreen.Bounds.Height;


            // initialize player hand card view
            InitializePlayerHandCardViews();

            InitializeOtherPlayersCardViews();

            InitializePlayerTableCardGroups();

            _game = GameService.CreateGame( GameService.CreateTestPlayers(), 3 );

            DrawGameBoard();

            DrawControls();

        }

        private void InitializePlayerTableCardGroups()
        {
            // Player2: 0, 192
            // Player3: 0, 576
            // Player4: 256 ,0
            // Player5: 768 ,0
            // Player6: 576, 974
            // Player7: 192, 974

            Player1TableCardGroups = InitializeTableCardGroups(1);
            Player2TableCardGroups = InitializeTableCardGroups(2);
            Player3TableCardGroups = InitializeTableCardGroups(3);
            Player4TableCardGroups = InitializeTableCardGroups(4);
            Player5TableCardGroups = InitializeTableCardGroups(5);
            Player6TableCardGroups = InitializeTableCardGroups(6);
            Player7TableCardGroups = InitializeTableCardGroups(7);

        }

        private List<CardGroupView> InitializeTableCardGroups(int playerNumber)
        {
            List<CardGroupView> playerTableCardGroups = new List<CardGroupView>();

            for (int i = 0; i < 4; i++)
            {
                playerTableCardGroups.Add(new CardGroupView());

                Card emptyCard = new Card();

                playerTableCardGroups[i].AddCardToGroup(emptyCard);

                CGRect cGRect = GetCGRectForTableCardGroup(playerNumber, i);

                if (cGRect != CGRect.Empty)
                {
                    playerTableCardGroups[i].Frame = cGRect;

                    View.AddSubview(playerTableCardGroups[i]);
                }
            }

            return playerTableCardGroups;
        }

        private CGRect GetCGRectForTableCardGroup(int playerNumber, int i)
        {
            CGRect cGRect = new CGRect();

            string switchValue = playerNumber.ToString() + "." + i.ToString();

            switch (switchValue)
            {
                // Player2: 5, 423
                case "1.0":
                    cGRect = new CGRect(261, 448, 5, 75);
                    break;
                case "1.1":
                    cGRect = new CGRect(261, 528, 5, 75);
                    break;
                case "1.2":
                    cGRect = new CGRect(517, 448, 5, 75);
                    break;
                case "1.3":
                    cGRect = new CGRect(517, 528, 5, 75);
                    break;
                // Player2: 5, 423
                case "2.0":
                    cGRect = new CGRect(5, 448, 5, 75);
                    break;
                case "2.1":
                    cGRect = new CGRect(5, 528, 5, 75);
                    break;
                case "2.2":
                    cGRect = new CGRect(5, 608, 5, 75);
                    break;
                case "2.3":
                    cGRect = new CGRect(5, 688, 5, 75);
                    break;
                // Player3: 5, 30
                case "3.0":
                    cGRect = new CGRect(5, 55, 5, 75);
                    break;
                case "3.1":
                    cGRect = new CGRect(5, 135, 5, 75);
                    break;
                case "3.2":
                    cGRect = new CGRect(5, 215, 5, 75);
                    break;
                case "3.3":
                    cGRect = new CGRect(5, 295, 5, 75);
                    break;
                // Player4: 261, 30
                case "4.0":
                    cGRect = new CGRect(261, 55, 5, 75);
                    break;
                case "4.1":
                    cGRect = new CGRect(261, 135, 5, 75);
                    break;
                case "4.2":
                    cGRect = new CGRect(261, 215, 5, 75);
                    break;
                case "4.3":
                    cGRect = new CGRect(261, 295, 5, 75);
                    break;
                // Player5: 517, 30
                case "5.0":
                    cGRect = new CGRect(517, 55, 5, 75);
                    break;
                case "5.1":
                    cGRect = new CGRect(517, 135, 5, 75);
                    break;
                case "5.2":
                    cGRect = new CGRect(517, 215, 5, 75);
                    break;
                case "5.3":
                    cGRect = new CGRect(517, 295, 5, 75);
                    break;
                // Player6: 761, 30
                case "6.0":
                    cGRect = new CGRect(761, 55, 5, 75);
                    break;
                case "6.1":
                    cGRect = new CGRect(761, 135, 5, 75);
                    break;
                case "6.2":
                    cGRect = new CGRect(761, 215, 5, 75);
                    break;
                case "6.3":
                    cGRect = new CGRect(761, 295, 5, 75);
                    break;
                // Player7: 761, 423
                case "7.0":
                    cGRect = new CGRect(761, 448, 5, 75);
                    break;
                case "7.1":
                    cGRect = new CGRect(761, 528, 5, 75);
                    break;
                case "7.2":
                    cGRect = new CGRect(761, 608, 5, 75);
                    break;
                case "7.3":
                    cGRect = new CGRect(761, 688, 5, 75);
                    break;
                default:
                    break;
            }

            return cGRect;
        }

        private void InitializeOtherPlayersCardViews()
        {
            //OtherPlayersCardViews = new List<CardView>();

            OtherPlayersCardViews = new List<UILabel>();

            for (int i = 2; i < 8; i++)
            {
//                CardView newCardView = new CardView();

                UILabel uILabel = new UILabel();
                uILabel.Text = "P" + i.ToString();
                uILabel.BackgroundColor = UIColor.White;

                CGRect cGRect = new CGRect();

                // Player2: 5, 423
                // Player3: 5, 30
                // Player4: 261, 30
                // Player5: 517, 30
                // Player6: 761, 30
                // Player7: 761, 423

                switch (i)
                {
                    case 2:
                        cGRect = new CGRect(5, 423, 100, 20);
                        break;
                    case 3:
                        cGRect = new CGRect(5, 30, 100, 20);
                        break;
                    case 4:
                        cGRect = new CGRect(261, 30, 100, 20);
                        break;
                    case 5:
                        cGRect = new CGRect(517, 30, 100, 20);
                        break;
                    case 6:
                        cGRect = new CGRect(761, 30, 100, 20);
                        break;
                    case 7:
                        cGRect = new CGRect(761, 423, 100, 20);
                        break;
                }

                if ( cGRect != CGRect.Empty)
                {
                    uILabel.Frame = cGRect;

                    OtherPlayersCardViews.Add(uILabel);
                    View.AddSubview(uILabel);
                }

            }
        }

        private void InitializePlayerHandCardViews()
        {
            PlayerHandCardViews = new List<CardView>();

            nfloat phCardViewPosX = 267;
            nfloat phCardViewPosY = 613;
            int phCardViewNumber = 0;


            for (int i = 0; i < 18; i++)
            {
                phCardViewNumber++;

                CardView newCardView = new CardView();
                newCardView.Frame = new CGRect(phCardViewPosX, phCardViewPosY, 50, 75);

                // Create a new tap gesture
                UITapGestureRecognizer tapGesture = null;

                // Report touch
                Action action = () => {

                    if (newCardView.Card != null && _game.Players[0].Hand.Cards.Count > 11)
                    {
                        // move card from cardView from player hand to discard pile
                        _game = GameService.DiscardCard(_game, 0, newCardView.Card);

                        DrawGameBoard();
                    }
                };

                tapGesture = new UITapGestureRecognizer(action);

                // Configure it
                tapGesture.NumberOfTapsRequired = 2;

                // Add the gesture recognizer to the view
                newCardView.AddGestureRecognizer(tapGesture);

                PlayerHandCardViews.Add(newCardView);

                View.AddSubview(newCardView);

                // move to next position
                phCardViewPosX += 55;

                if (phCardViewNumber == 9)
                {
                    // move next card cords to next line
                    phCardViewPosX = 267;
                    phCardViewPosY = 693;
                }
            }

        }

        private void DrawGameBoard()
        {

            // notes
            // width: 1024 - half: 512 - qtr: 256 - 8th: 128 - 16th: 64
            // height: 768 - half: 384 - qtr: 192 - 8th:  96 - 16th: 48
            //

            DrawGameDeck();

            DrawDiscardPile();

            DrawPlayers();

        }

        private void DrawControls()
        {
            UIButton dealUIButton = UIButton.FromType(UIButtonType.RoundedRect);
            dealUIButton.Frame = new CGRect(60, 390, 50, 25);
            dealUIButton.BackgroundColor = UIColor.White;
            dealUIButton.SetTitle("Deal", UIControlState.Normal);

            UIButton shuffleUIButton = UIButton.FromType(UIButtonType.RoundedRect);
            shuffleUIButton.Frame = new CGRect(5, 390, 50, 25);
            shuffleUIButton.BackgroundColor = UIColor.White;
            shuffleUIButton.SetTitle("Shuffle", UIControlState.Normal);

            UIButton devTestButton = UIButton.FromType(UIButtonType.RoundedRect);
            devTestButton.Frame = new CGRect(115, 390, 50, 25);
            devTestButton.BackgroundColor = UIColor.White;
            devTestButton.SetTitle("Dev", UIControlState.Normal);

            devTestButton.TouchUpInside += (sender, e) => {

                AddDevCardsToTableHands();

            };

            dealUIButton.TouchUpInside += (sender, e) => {
                _game = GameService.Deal(_game);

                DrawGameBoard();

                dealUIButton.Hidden = true;
                shuffleUIButton.Hidden = true;
            };

            shuffleUIButton.TouchUpInside += (sender, e) => {
                // ensure all cards are in game deck
                if(_game.GameDeck.Cards.Count == (_game.GameDeck.NumberOfDecks * 54))
                {
                    _game.GameDeck = DeckService.ShuffleDeck(_game.GameDeck);
                }
                else
                {
                    // display error message that game deck is missing cards and have a button to reset the game deck
                }
            };

            View.AddSubview(devTestButton);
            View.AddSubview(dealUIButton);
            View.AddSubview(shuffleUIButton);
        }

        private void AddDevCardsToTableHands()
        {
            for (int i = 0; i < Player1TableCardGroups.Count; i++)
            {
                for (int h = 0; h < 4; h++)
                {
                    Card testCard = new Card();
                    testCard.ShortName = h.ToString();

                    Player1TableCardGroups[i].AddCardToGroup(testCard);


                }
            }
            for (int i = 0; i < Player2TableCardGroups.Count; i++)
            {
                for (int h = 0; h < 4; h++)
                {
                    Card testCard = new Card();
                    testCard.ShortName = h.ToString();

                    Player2TableCardGroups[i].AddCardToGroup(testCard);


                }
            }
            for (int i = 0; i < Player3TableCardGroups.Count; i++)
            {
                for (int h = 0; h < 4; h++)
                {
                    Card testCard = new Card();
                    testCard.ShortName = h.ToString();

                    Player3TableCardGroups[i].AddCardToGroup(testCard);


                }
            }
            for (int i = 0; i < Player4TableCardGroups.Count; i++)
            {
                for (int h = 0; h < 4; h++)
                {
                    Card testCard = new Card();
                    testCard.ShortName = h.ToString();

                    Player4TableCardGroups[i].AddCardToGroup(testCard);


                }
            }
            for (int i = 0; i < Player5TableCardGroups.Count; i++)
            {
                for (int h = 0; h < 4; h++)
                {
                    Card testCard = new Card();
                    testCard.ShortName = h.ToString();

                    Player5TableCardGroups[i].AddCardToGroup(testCard);


                }
            }
            for (int i = 0; i < Player6TableCardGroups.Count; i++)
            {
                for (int h = 0; h < 4; h++)
                {
                    Card testCard = new Card();
                    testCard.ShortName = h.ToString();

                    Player6TableCardGroups[i].AddCardToGroup(testCard);


                }
            }
            for (int i = 0; i < Player7TableCardGroups.Count; i++)
            {
                for (int h = 0; h < 4; h++)
                {
                    Card testCard = new Card();
                    testCard.ShortName = h.ToString();

                    Player7TableCardGroups[i].AddCardToGroup(testCard);


                }
            }
        }

        private void DrawPlayers()
        {
            DrawPlayer();

            // loop through players to draw
            //DrawOtherPlayers();

        }

        private void DrawPlayer()
        {
            for (int i = 0; i < PlayerHandCardViews.Count; i++)
            {
                if ( _game.Players[0].Hand.Cards.Count > 0 && i < _game.Players[0].Hand.Cards.Count)
                {
                    if (_game.Players[0].Hand.Cards[i] != null)
                    {
                        PlayerHandCardViews[i].SetCard(_game.Players[0].Hand.Cards[i]);
                    }
                    else
                    {
                        PlayerHandCardViews[i].SetCard(null);
                    }
                }
                else
                {
                    PlayerHandCardViews[i].SetCard(null);
                }
            }

        }



        private void DrawOtherPlayers()
        {

        }

        private void DrawDiscardPile()
        {
            if (DiscardPileCardView == null)
            {
                // create a new card view for dicard pile
                DiscardPileCardView = new CardView();

                DiscardPileCardView.Frame = new CGRect(261, 390, 50, 50);

                // Create a new tap gesture
                UITapGestureRecognizer tapGesture = null;

                // Report touch
                Action action = () => {

                    // ensure cards in discard pile
                    if (_game.DiscardPile.Cards.Count > 0 && _game.Players[0].Hand.Cards.Count > 10 && _game.Players[0].Hand.Cards.Count < 18)
                    {
                        _game = GameService.DrawDiscardCard(_game, 1);

                        DrawGameBoard();
                    }
                    else
                    {
                        // add message about no cards
                    }

                };

                tapGesture = new UITapGestureRecognizer(action);

                // Configure it
                tapGesture.NumberOfTapsRequired = 2;

                // Add the gesture recognizer to the view
                DiscardPileCardView.AddGestureRecognizer(tapGesture);

                View.AddSubview(DiscardPileCardView);
            }
            else
            {
                // update discard pile
                if ( _game.DiscardPile.Cards.Count > 0)
                {
                    // always show the newest card discarded
                    int bottomCardIndex = _game.DiscardPile.Cards.Count - 1;

                    DiscardPileCardView.SetCard(_game.DiscardPile.Cards[bottomCardIndex]);
                }
                else
                {
                    // discard pile empty
                    DiscardPileCardView.SetCard(null);
                }
            }
        }


        private void DrawGameDeck()
        {
            if (GameDeckCardView == null)
            {
                // create a new card view for game deck
                GameDeckCardView = new CardView();

                GameDeckCardView.Frame = new CGRect(316, 390, 50, 50);

                // Create a new tap gesture
                UITapGestureRecognizer tapGesture = null;

                // Report touch
                Action action = () => {

                    // ensure cards in deck
                    if (_game.GameDeck.Cards.Count > 0 && _game.Players[0].Hand.Cards.Count > 10 && _game.Players[0].Hand.Cards.Count < 18)
                    {
                        _game = GameService.DrawCard(_game, 1);

                        DrawGameBoard();
                    }
                    else
                    {
                        // add message about no cards
                    }

                };

                tapGesture = new UITapGestureRecognizer(action);

                // Configure it
                tapGesture.NumberOfTapsRequired = 2;

                // Add the gesture recognizer to the view
                GameDeckCardView.AddGestureRecognizer(tapGesture);



                View.AddSubview(GameDeckCardView);
            }
            else
            {
                // update the game deck
                if ( _game.GameDeck.Cards.Count >0)
                {
                    // for now show top card, eventually just show flipped over card
                    GameDeckCardView.SetCard(_game.GameDeck.Cards[0]);
                }
                else
                {
                    // deck empty
                    GameDeckCardView.SetCard(null);
                }
            }
        }
    }
}
