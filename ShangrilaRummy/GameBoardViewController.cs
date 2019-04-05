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
        List<CardView> PlayerHandSelectedCards;

        // probably temporary
        List<UILabel> OtherPlayersUIViews;
        List<UIButton> OtherPlayerCardCountUIViews;

        List<List<CardGroupView>> PlayerTableCardGroups;

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

            InitializeGameViews();

            _game = GameService.CreateGame(GameService.CreateTestPlayers(), 3);

            DrawGameBoard();

            DrawControls();

        }

        private void InitializeGameViews()
        {
            InitializeGameDeckView();

            InitializeDiscardPileView();

            InitializePlayerHandCardViews();

            InitializeOtherPlayersViews();

            InitializeTableCardViews();
        }

        private void InitializeTableCardViews()
        {
            PlayerTableCardGroups = new List<List<CardGroupView>>();

            for (int i = 0; i < 7; i++)
            {
                List<CardGroupView> cardGroupViews = InitializeTableCardGroups(i);

                PlayerTableCardGroups.Add(cardGroupViews);
            }
        }

        private void InitializeDiscardPileView()
        {
            // create a new card view for dicard pile
            DiscardPileCardView = new CardView
            {
                Frame = new CGRect(261, 390, 50, 50)
            };

            // Create a new tap gesture
            UITapGestureRecognizer tapGesture = null;

            // Report touch
            void action()
            {
                if (PlayerHandSelectedCards.Count == 0 && _game.DiscardPile.Cards.Count > 0 && _game.Players[0].Hand.Cards.Count > 10 && _game.Players[0].Hand.Cards.Count < 18)
                {
                    // no selected cards, assume drawing from discard pile
                    _game = GameService.DrawDiscardCard(_game, 1);
                }
                else if (PlayerHandSelectedCards.Count == 1 && _game.Players[0].Hand.Cards.Count > 11)
                {
                    // 1 selected card, assume discarding
                    CardView selectedCardView = PlayerHandCardViews.SingleOrDefault(a => a.IsSelected == true);

                    _game = GameService.DiscardCard(_game, 1, selectedCardView.Card);

                    selectedCardView.SetCard(null);
                    PlayerHandSelectedCards.Remove(selectedCardView);
                }

                DrawGameBoard();
            }

            tapGesture = new UITapGestureRecognizer(action)
            {
                NumberOfTapsRequired = 2
            };

            // Add the gesture recognizer to the view
            DiscardPileCardView.AddGestureRecognizer(tapGesture);

            View.AddSubview(DiscardPileCardView);
        }

        private void InitializeGameDeckView()
        {
            GameDeckCardView = new CardView
            {
                Frame = new CGRect(316, 390, 50, 50)
            };

            // Create a new tap gesture
            UITapGestureRecognizer tapGesture = null;

            // Report touch
            void action()
            {
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
            }

            tapGesture = new UITapGestureRecognizer(action)
            {
                NumberOfTapsRequired = 2
            };

            // Add the gesture recognizer to the view
            GameDeckCardView.AddGestureRecognizer(tapGesture);

            View.AddSubview(GameDeckCardView);
        }

        private void InitializeOtherPlayersViews()
        {
            OtherPlayersUIViews = new List<UILabel>();

            OtherPlayerCardCountUIViews = new List<UIButton>();

            for (int i = 2; i < 8; i++)
            {
                UILabel nameUILabel = new UILabel
                {
                    Text = "P" + i.ToString(),
                    BackgroundColor = UIColor.White
                };

                UIButton countUIButton = new UIButton(UIButtonType.System);

                countUIButton.BackgroundColor = UIColor.White;

                countUIButton.SetTitle("0", UIControlState.Normal);

                CGRect cGRectName = new CGRect();
                CGRect cGRectCount = new CGRect();

                // Player2: 5, 423
                // Player3: 5, 30
                // Player4: 261, 30
                // Player5: 517, 30
                // Player6: 761, 30
                // Player7: 761, 423

                switch (i)
                {
                    case 2:
                        cGRectName = new CGRect(5, 423, 80, 20);
                        cGRectCount = new CGRect(80, 423, 20, 20);
                        break;
                    case 3:
                        cGRectName = new CGRect(5, 30, 80, 20);
                        cGRectCount = new CGRect(80, 30, 20, 20);
                        break;
                    case 4:
                        cGRectName = new CGRect(261, 30, 80, 20);
                        cGRectCount = new CGRect(341, 30, 20, 20);
                        break;
                    case 5:
                        cGRectName = new CGRect(517, 30, 80, 20);
                        cGRectCount = new CGRect(597, 30, 20, 20);
                        break;
                    case 6:
                        cGRectName = new CGRect(761, 30, 80, 20);
                        cGRectCount = new CGRect(841, 30, 20, 20);
                        break;
                    case 7:
                        cGRectName = new CGRect(761, 423, 80, 20);
                        cGRectCount = new CGRect(841, 423, 20, 20);
                        break;
                }

                if (cGRectName != CGRect.Empty)
                {
                    nameUILabel.Frame = cGRectName;

                    OtherPlayersUIViews.Add(nameUILabel);
                    View.AddSubview(nameUILabel);
                }

                if (cGRectCount != CGRect.Empty)
                {
                    countUIButton.Frame = cGRectCount;

                    int test = i;

                    countUIButton.TouchUpInside += (sender, e) =>
                    {


                        AdvancePlayer(test);

                        DrawGameBoard();
                    };

                    OtherPlayerCardCountUIViews.Add(countUIButton);
                    View.AddSubview(countUIButton);
                }
            }
        }

        private void InitializePlayerHandCardViews()
        {
            PlayerHandCardViews = new List<CardView>();
            PlayerHandSelectedCards = new List<CardView>();

            nfloat posX = 267;
            nfloat posY = 613;

            for (int i = 0; i < 18; i++)
            {
                CardView cardView = new CardView()
                {
                    Frame = new CGRect(posX, posY, 50, 75)
                };

                // Create a new tap gesture
                UITapGestureRecognizer tapGesture = null;

                // Report touch
                void action()
                {
                    if (cardView.Card != null)
                    {
                        if (PlayerHandSelectedCards.Contains(cardView))
                        {
                            cardView.ToggleSelection(false);
                            PlayerHandSelectedCards.Remove(cardView);
                        }
                        else
                        {
                            cardView.ToggleSelection(true);
                            PlayerHandSelectedCards.Add(cardView);
                        }

                        DrawGameBoard();
                    }
                }

                tapGesture = new UITapGestureRecognizer(action)
                {
                    NumberOfTapsRequired = 1
                };

                // Add the gesture recognizer to the view
                cardView.AddGestureRecognizer(tapGesture);

                PlayerHandCardViews.Add(cardView);

                View.AddSubview(cardView);

                posX += 25;
            }
        }

        private List<CardGroupView> InitializeTableCardGroups(int playerIndex)
        {
            List<CardGroupView> playerTableCardGroups = new List<CardGroupView>();

            for (int i = 0; i < 4; i++)
            {
                CGRect cGRect = GetCGRectForTableCardGroup(playerIndex, i);

                if (cGRect != CGRect.Empty)
                {
                    CardGroupView cardGroupView = new CardGroupView();

                    cardGroupView.AddCardToGroup(new Card());

                    cardGroupView.Frame = cGRect;

                    // Create a new tap gesture
                    UITapGestureRecognizer tapGesture = null;

                    int tableHandIndex = i;

                    // Report touch
                    void action()
                    {
                        if (PlayerHandSelectedCards.Count > 3)
                        {
                            foreach (var cardView in PlayerHandSelectedCards)
                            {

                                _game = GameService.MoveCardToTable(_game, 1, cardView.Card, tableHandIndex);

                            }
                        }

                        DrawGameBoard();

                    }

                    tapGesture = new UITapGestureRecognizer(action)
                    {
                        NumberOfTapsRequired = 2
                    };

                    // Add the gesture recognizer to the view
                    cardGroupView.AddGestureRecognizer(tapGesture);

                    View.AddSubview(cardGroupView);

                    playerTableCardGroups.Add(cardGroupView);
                }
            }

            return playerTableCardGroups;
        }

        private CGRect GetCGRectForTableCardGroup(int playerIndex, int i)
        {
            CGRect cGRect = new CGRect();

            string switchValue = playerIndex.ToString() + "." + i.ToString();

            switch (switchValue)
            {
                // Player1: 5, 423
                case "0.0":
                    cGRect = new CGRect(261, 448, 50, 75);
                    break;
                case "0.1":
                    cGRect = new CGRect(261, 528, 50, 75);
                    break;
                case "0.2":
                    cGRect = new CGRect(517, 448, 50, 75);
                    break;
                case "0.3":
                    cGRect = new CGRect(517, 528, 50, 75);
                    break;
                // Player2: 5, 423
                case "1.0":
                    cGRect = new CGRect(5, 448, 50, 75);
                    break;
                case "1.1":
                    cGRect = new CGRect(5, 528, 50, 75);
                    break;
                case "1.2":
                    cGRect = new CGRect(5, 608, 50, 75);
                    break;
                case "1.3":
                    cGRect = new CGRect(5, 688, 50, 75);
                    break;
                // Player3: 5, 30
                case "2.0":
                    cGRect = new CGRect(5, 55, 50, 75);
                    break;
                case "2.1":
                    cGRect = new CGRect(5, 135, 50, 75);
                    break;
                case "2.2":
                    cGRect = new CGRect(5, 215, 50, 75);
                    break;
                case "2.3":
                    cGRect = new CGRect(5, 295, 50, 75);
                    break;
                // Player4: 261, 30
                case "3.0":
                    cGRect = new CGRect(261, 55, 50, 75);
                    break;
                case "3.1":
                    cGRect = new CGRect(261, 135, 50, 75);
                    break;
                case "3.2":
                    cGRect = new CGRect(261, 215, 50, 75);
                    break;
                case "3.3":
                    cGRect = new CGRect(261, 295, 50, 75);
                    break;
                // Player5: 517, 30
                case "4.0":
                    cGRect = new CGRect(517, 55, 50, 75);
                    break;
                case "4.1":
                    cGRect = new CGRect(517, 135, 50, 75);
                    break;
                case "4.2":
                    cGRect = new CGRect(517, 215, 50, 75);
                    break;
                case "4.3":
                    cGRect = new CGRect(517, 295, 50, 75);
                    break;
                // Player6: 761, 30
                case "5.0":
                    cGRect = new CGRect(761, 55, 50, 75);
                    break;
                case "5.1":
                    cGRect = new CGRect(761, 135, 50, 75);
                    break;
                case "5.2":
                    cGRect = new CGRect(761, 215, 50, 75);
                    break;
                case "5.3":
                    cGRect = new CGRect(761, 295, 50, 75);
                    break;
                // Player7: 761, 423
                case "6.0":
                    cGRect = new CGRect(761, 448, 50, 75);
                    break;
                case "6.1":
                    cGRect = new CGRect(761, 528, 50, 75);
                    break;
                case "6.2":
                    cGRect = new CGRect(761, 608, 50, 75);
                    break;
                case "6.3":
                    cGRect = new CGRect(761, 688, 50, 75);
                    break;
                default:
                    break;
            }

            return cGRect;
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

            DrawTableCardGroups();

        }

        private void DrawTableCardGroups()
        {
            for (int i = 0; i < _game.Players.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // clear existing views
                    //PlayerTableCardGroups[j].Clear();

                    if ( _game.Players[i].TableHands[j].Cards.Count > 0)
                    {
                        // build new list of cards
                        CardGroupView cardGroupView = new CardGroupView();

                        for (int k = 0; k < _game.Players[i].TableHands[j].Cards.Count; k++)
                        {
                            PlayerTableCardGroups[i][j].AddCardToGroup(_game.Players[i].TableHands[j].Cards[k]);

                        }

                        PlayerTableCardGroups[j].Add(cardGroupView);

                    }

                }

            }

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

            devTestButton.TouchUpInside += (sender, e) =>
            {

                //AddDevCardsToTableHands();

            };

            dealUIButton.TouchUpInside += (sender, e) =>
            {
                _game = GameService.Deal(_game);

                DrawGameBoard();

                dealUIButton.Hidden = true;
                shuffleUIButton.Hidden = true;
            };

            shuffleUIButton.TouchUpInside += (sender, e) =>
            {
                // ensure all cards are in game deck
                if (_game.GameDeck.Cards.Count == (_game.GameDeck.NumberOfDecks * 54))
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


        private void DrawPlayers()
        {
            DrawPlayer();

            DrawOtherPlayers();

        }

        private void DrawPlayer()
        {
            for (int i = 0; i < PlayerHandCardViews.Count; i++)
            {
                if (i < _game.Players[0].Hand.Cards.Count)
                {
                    PlayerHandCardViews[i].SetCard(_game.Players[0].Hand.Cards[i]);
                }
                else
                {
                    PlayerHandCardViews[i].SetCard(null);
                }
            }
        }



        private void DrawOtherPlayers()
        {
            for (int i = 0; i < OtherPlayerCardCountUIViews.Count; i++)
            {
                OtherPlayerCardCountUIViews[i].SetTitle(_game.Players[i + 1].Hand.Cards.Count.ToString(), UIControlState.Normal);
            }
        }

        private void DrawDiscardPile()
        {
            if (DiscardPileCardView != null)
            {
                // update discard pile
                if (_game.DiscardPile.Cards.Count > 0)
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
            if (GameDeckCardView != null)
            {
                // update the game deck
                if (_game.GameDeck.Cards.Count > 0)
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




        // dev stuff

        private void AdvancePlayer(int player)
        {
            // draw the top card
            _game = GameService.DrawCard(_game, player);

            // discard the bottom card from players hand
            Card discardCard = _game.Players[player - 1].Hand.Cards[0];

            _game = GameService.DiscardCard(_game, player, discardCard);

        }


        //private void AddDevCardsToTableHands()
        //{
        //    for (int i = 0; i < Player1TableCardGroups.Count; i++)
        //    {
        //        for (int h = 0; h < 4; h++)
        //        {
        //            Player1TableCardGroups[i].AddCardToGroup(CreateTestCard(h.ToString()));
        //        }
        //    }
        //    for (int i = 0; i < Player2TableCardGroups.Count; i++)
        //    {
        //        for (int h = 0; h < 4; h++)
        //        {
        //            Player2TableCardGroups[i].AddCardToGroup(CreateTestCard(h.ToString()));
        //        }
        //    }
        //    for (int i = 0; i < Player3TableCardGroups.Count; i++)
        //    {
        //        for (int h = 0; h < 4; h++)
        //        {
        //            Player3TableCardGroups[i].AddCardToGroup(CreateTestCard(h.ToString()));
        //        }
        //    }
        //    for (int i = 0; i < Player4TableCardGroups.Count; i++)
        //    {
        //        for (int h = 0; h < 4; h++)
        //        {
        //            Player4TableCardGroups[i].AddCardToGroup(CreateTestCard(h.ToString()));
        //        }
        //    }
        //    for (int i = 0; i < Player5TableCardGroups.Count; i++)
        //    {
        //        for (int h = 0; h < 4; h++)
        //        {
        //            Player5TableCardGroups[i].AddCardToGroup(CreateTestCard(h.ToString()));
        //        }
        //    }
        //    for (int i = 0; i < Player6TableCardGroups.Count; i++)
        //    {
        //        for (int h = 0; h < 4; h++)
        //        {
        //            Player6TableCardGroups[i].AddCardToGroup(CreateTestCard(h.ToString()));
        //        }
        //    }
        //    for (int i = 0; i < Player7TableCardGroups.Count; i++)
        //    {
        //        for (int h = 0; h < 4; h++)
        //        {
        //            Player7TableCardGroups[i].AddCardToGroup(CreateTestCard(h.ToString()));
        //        }
        //    }
        //}

        private Card CreateTestCard(string v)
        {
            Card card = new Card
            {
                ShortName = v
            };

            return card;
        }
    }
}

// notes

// Player2: 0, 192
// Player3: 0, 576
// Player4: 256 ,0
// Player5: 768 ,0
// Player6: 576, 974
// Player7: 192, 974

// Player2: 5, 423
// Player3: 5, 30
// Player4: 261, 30
// Player5: 517, 30
// Player6: 761, 30
// Player7: 761, 423