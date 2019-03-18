using System;
using UIKit;
using CoreGraphics;
using System.Collections.Generic;
using ShangrilaRummy.Model;
using ShangrilaRummy.Service;
using System.Linq;

namespace ShangrilaRummy
{
    public class GameBoardViewController : UIViewController
    {
        Game _game;

        nfloat viewWidth;
        nfloat viewHeight;

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

            _game = GameService.CreateGame( GameService.CreateTestPlayers(), 3 );

            DrawGameBoard();


            DrawControls();

        }

        private void DrawGameBoard()
        {

            // notes
            // width: 1024 - half: 512
            // height: 768 - half: 384
            //

            DrawDeck();

            DrawDiscardPile();

            DrawPlayers();

        }

        private void DrawControls()
        {
            UIButton dealUIButton = UIButton.FromType(UIButtonType.RoundedRect);
            dealUIButton.Frame = new CGRect(viewWidth / 2 - 55, viewHeight / 2 - 70.5, 50, 25);
            dealUIButton.BackgroundColor = UIColor.White;
            dealUIButton.SetTitle("Deal", UIControlState.Normal);

            UIButton shuffleUIButton = UIButton.FromType(UIButtonType.RoundedRect);
            shuffleUIButton.Frame = new CGRect(viewWidth / 2 + 5, viewHeight / 2 - 70.5, 50, 25);
            shuffleUIButton.BackgroundColor = UIColor.White;
            shuffleUIButton.SetTitle("Shuffle", UIControlState.Normal);

            UIButton drawUIButton = UIButton.FromType(UIButtonType.RoundedRect);
            drawUIButton.Frame = new CGRect(viewWidth / 2 + 5, viewHeight / 2 + 45.5, 50, 25);
            drawUIButton.BackgroundColor = UIColor.White;
            drawUIButton.SetTitle("Draw", UIControlState.Normal);
            drawUIButton.Hidden = true;

            UIButton drawDiscardUIButton = UIButton.FromType(UIButtonType.RoundedRect);
            drawDiscardUIButton.Frame = new CGRect(viewWidth / 2 - 55, viewHeight / 2 + 45.5, 50, 25);
            drawDiscardUIButton.BackgroundColor = UIColor.White;
            drawDiscardUIButton.SetTitle("Draw Discard", UIControlState.Normal);
            drawDiscardUIButton.Hidden = true;

            dealUIButton.TouchUpInside += (sender, e) => {
                _game = GameService.Deal(_game);

                DrawGameBoard();

                dealUIButton.Hidden = true;
                shuffleUIButton.Hidden = true;
                drawUIButton.Hidden = false;
                drawDiscardUIButton.Hidden = false;
            };

            drawUIButton.TouchUpInside += (sender, e) => {
                // ensure cards in deck
                if (_game.GameDeck.Cards.Count > 0)
                {
                    _game = GameService.DrawCard(_game, 1);

                    DrawGameBoard();
                }
                else
                {
                    // add message about no cards
                }

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

            drawDiscardUIButton.TouchUpInside += (sender, e) => {
                // ensure cards in discard pile
                if (_game.DiscardPile.Cards.Count > 0) 
                {
                    _game = GameService.DrawDiscardCard(_game, 1);

                    DrawGameBoard();
                }
                else
                {
                    // add message about no cards
                }

            };

            View.AddSubview(dealUIButton);
            View.AddSubview(shuffleUIButton);
            View.AddSubview(drawUIButton);
            View.AddSubview(drawDiscardUIButton);
        }

        private void DrawPlayers()
        {
            // loop through players to draw
            DrawOtherPlayers();

            DrawPlayer();
        }

        private void DrawPlayer()
        {
            HandView playerHand = new HandView(_game.Players[0].Hand);

            View.AddSubview(playerHand);
         
        }

        private void DrawOtherPlayers()
        {
            // loop through players in game, skipping first player
            for (int i = 1; i < _game.Players.Count; i++)
            {
                Card otherPlayerCardCount = new Card { ShortName = "Empty" };

                // update Shortname to be card count if player has cards
                if (_game.Players[i].Hand.Cards != null && _game.Players[i].Hand.Cards.Count > 0)
                {
                    otherPlayerCardCount.ShortName = _game.Players[i].Hand.Cards.Count.ToString();
                }

                if (_game.Players[i].CardView == null)
                {
                    // create new card view
                    _game.Players[i].CardView = new CardView(otherPlayerCardCount);

                    View.AddSubview(_game.Players[i].CardView);
                }
                else 
                {
                    // update existing card view
                    _game.Players[i].CardView.UpdateCard(otherPlayerCardCount.ShortName);
                }

                // Player2: 0, 192
                // Player3: 0, 576
                // Player4: 256 ,0
                // Player5: 768 ,0
                // Player6: 576, 974
                // Player7: 192, 974

                switch (_game.Players[i].SeatNumber)
                {
                    case 2:
                        _game.Players[i].CardView.Frame = new CGRect(0, 192, 50, 75);
                        break;
                    case 3:
                        _game.Players[i].CardView.Frame = new CGRect(0, 576, 50, 75);
                        break;
                    case 4:
                        _game.Players[i].CardView.Frame = new CGRect(256, 0, 50, 75);
                        break;
                    case 5:
                        _game.Players[i].CardView.Frame = new CGRect(718, 0, 50, 75);
                        break;
                    case 6:
                        _game.Players[i].CardView.Frame = new CGRect(974, 576, 50, 75);
                        break;
                    case 7:
                        _game.Players[i].CardView.Frame = new CGRect(974, 192, 50, 75);
                        break;
                }
            }
        }

        private void DrawDiscardPile()
        {

            if(_game.DiscardPile.CardView == null) 
            {
                // initialize new card view with Empty
                _game.DiscardPile.CardView = new CardView(new Card() { ShortName = "Empty" });

                _game.DiscardPile.CardView.Frame = new CGRect(viewWidth / 2 - 55, viewHeight / 2 - 35.5, 50, 75);

                View.AddSubview(_game.DiscardPile.CardView);
            }

            if (_game.DiscardPile.Cards.Count > 0)
            {
                // get the top card of the discard pile
                _game.DiscardPile.CardView.UpdateCard(_game.DiscardPile.Cards[0].ShortName);
            }
        }

        private void DrawDeck()
        {
            // for now draw top card in deck
            // eventually draw game deck using DeckView

            if(_game.GameDeck.CardView == null)
            {
                // create new cardview with empty card
                _game.GameDeck.CardView = new CardView(new Card() { ShortName = "Empty" });

                _game.GameDeck.CardView.Frame = new CGRect(viewWidth / 2 + 5, viewHeight / 2 - 35.5, 50, 75);

                View.AddSubview(_game.GameDeck.CardView);
            }
           
            // update to top card if exists
            if(_game.GameDeck.Cards.Count > 0)
            {
                //_game.GameDeck.CardView.Value.Text = _game.GameDeck.Cards[0].ShortName;
                _game.GameDeck.CardView.UpdateCard(_game.GameDeck.Cards[0].ShortName);

            }
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            //cardView.UpdateLayout();
            
        }
    }
}
