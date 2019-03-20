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

        // recreate the cardview class that has a pointer to a card
        //   create a SetCard method for setting/changing the pointer

        // gameboard view controller
        // create a cardview list object
        // create 17 player hand card views and add them to the list
        //    each cardView index will be 1 to 1 with the index of the player hand
        //    each cardview will display empty placeholder if no card pointer is set


        CardView GameDeckCardView;
        CardView DiscardPileCardView;

        List<CardView> PlayerHandCardViews;

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

            PlayerHandCardViews = new List<CardView>();

            nfloat phCardViewPosX = 267;
            nfloat phCardViewPosY = 613;
            int phCardViewNumber = 0;


            for (int i = 0; i < 18; i++)
            {
                phCardViewNumber++;

                CardView newCardView = new CardView();
                newCardView.Frame = new CGRect(phCardViewPosX, phCardViewPosY, 50, 75);

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

            _game = GameService.CreateGame( GameService.CreateTestPlayers(), 3 );

            DrawGameBoard();

            DrawControls();

        }

        private void DrawGameBoard()
        {

            // notes
            // width: 1024 - half: 512 - qtr: 256 - 8th: 128 - 16th: 64
            // height: 768 - half: 384 - qtr: 192 - 8th:  96 - 16th: 48
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
            drawDiscardUIButton.SetTitle("Draw D", UIControlState.Normal);
            drawDiscardUIButton.Hidden = true;

            UIButton drawDiscardTestUIButton = UIButton.FromType(UIButtonType.RoundedRect);
            drawDiscardTestUIButton.Frame = new CGRect(viewWidth / 2 - 55, viewHeight / 2 - 70.5, 50, 25);
            drawDiscardTestUIButton.BackgroundColor = UIColor.White;
            drawDiscardTestUIButton.SetTitle("T Dis", UIControlState.Normal);
            drawDiscardTestUIButton.Hidden = true;

            dealUIButton.TouchUpInside += (sender, e) => {
                _game = GameService.Deal(_game);

                DrawGameBoard();

                dealUIButton.Hidden = true;
                shuffleUIButton.Hidden = true;
                drawUIButton.Hidden = false;
                drawDiscardUIButton.Hidden = false;
                drawDiscardTestUIButton.Hidden = false;
            };

            drawUIButton.TouchUpInside += (sender, e) => {
                // ensure cards in deck
                if (_game.GameDeck.Cards.Count > 0)
                {
                    _game = GameService.DrawCard(_game, 1);

                    if (_game.Players[0].Hand.Cards.Count >= 18)
                    {
                        drawUIButton.Hidden = true;
                    }

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

            drawDiscardTestUIButton.TouchUpInside += (sender, e) => { 
                // this is just a test button for dev work
                if ( _game.Players[0].Hand.Cards.Count > 0)
                {
                    // move dicard top card in players hand
                    _game = GameService.DiscardCard(_game, 0, _game.Players[0].Hand.Cards[0]);

                    DrawGameBoard();
                }
            };

            View.AddSubview(dealUIButton);
            View.AddSubview(shuffleUIButton);
            View.AddSubview(drawUIButton);
            View.AddSubview(drawDiscardUIButton);
            View.AddSubview(drawDiscardTestUIButton);
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

            //for (int i = 0; i < _game.Players[0].Hand.Cards.Count; i++)
            //{
            //    if ( _game.Players[0].Hand.Cards[i] != null)
            //    {
            //        PlayerHandCardViews[i].SetCard(_game.Players[0].Hand.Cards[i]);
            //    }
            //    else
            //    {
            //        PlayerHandCardViews[i].SetCard(null);
            //    }
            //}



            //int cardNumber = 0;
            //if(_game.Players[0].Hand.Cards != null && _game.Players[0].Hand.Cards.Count > 0)
            //{
            //    for (int i = 0; i < _game.Players[0].Hand.Cards.Count; i++)
            //    {
            //        if (_game.Players[0].Hand.Cards[i].CardUIControl == null)
            //        {
            //            // if control doesnt exist create a new one
            //            _game.Players[0].Hand.Cards[i].CardUIControl = new UILabel();
            //            _game.Players[0].Hand.Cards[i].CardUIControl.BackgroundColor = UIColor.Orange;
            //            _game.Players[0].Hand.Cards[i].CardUIControl.TextColor = UIColor.Black;
            //            _game.Players[0].Hand.Cards[i].CardUIControl.TextAlignment = UITextAlignment.Center;
            //            _game.Players[0].Hand.Cards[i].CardUIControl.Text = _game.Players[0].Hand.Cards[i].ShortName;

            //            UIPanGestureRecognizer gesture = new UIPanGestureRecognizer();

            //            gesture.AddTarget(() => HandleDrag(gesture));


            //            View.AddSubview(_game.Players[0].Hand.Cards[i].CardUIControl);

            //            _game.Players[0].Hand.Cards[i].CardUIControl.AddGestureRecognizer(gesture);

            //            _game.Players[0].Hand.Cards[i].CardUIControl.UserInteractionEnabled = true;

            //        }

            //        _game.Players[0].Hand.Cards[i].CardUIControl.Frame = new CGRect(cardPosX, cardPosY, 50, 75);

            //        cardNumber++;

            //        // move to next position
            //        cardPosX += 55;

            //        if (cardNumber == 9)
            //        {
            //            // move next card cords to next line
            //            cardPosX = 267;
            //            cardPosY = 693;
            //        }
            //    }
            //}
        }



        //private void DrawOtherPlayers()
        //{
        //    // loop through players in game, skipping first player
        //    for (int i = 1; i < _game.Players.Count; i++)
        //    {

        //        if (_game.Players[i].GameBoardUIControl == null)
        //        {
        //            // create new card control
        //            _game.Players[i].GameBoardUIControl = new UILabel();

        //            _game.Players[i].GameBoardUIControl.BackgroundColor = UIColor.Red;
        //            _game.Players[i].GameBoardUIControl.TextColor = UIColor.Green;
        //            _game.Players[i].GameBoardUIControl.Text = "Empty";
        //            _game.Players[i].GameBoardUIControl.TextAlignment = UITextAlignment.Center;

        //            View.AddSubview(_game.Players[i].GameBoardUIControl);
        //        }


        //        if (_game.Players[i].Hand.Cards != null && _game.Players[i].Hand.Cards.Count > 0)
        //        {
        //            _game.Players[i].GameBoardUIControl.Text = _game.Players[i].Hand.Cards.Count.ToString();
        //        }

        //        // Player2: 0, 192
        //        // Player3: 0, 576
        //        // Player4: 256 ,0
        //        // Player5: 768 ,0
        //        // Player6: 576, 974
        //        // Player7: 192, 974

        //        switch (_game.Players[i].SeatNumber)
        //        {
        //            case 2:
        //                _game.Players[i].GameBoardUIControl.Frame = new CGRect(0, 192, 50, 75);
        //                break;
        //            case 3:
        //                _game.Players[i].GameBoardUIControl.Frame = new CGRect(0, 576, 50, 75);
        //                break;
        //            case 4:
        //                _game.Players[i].GameBoardUIControl.Frame = new CGRect(256, 0, 50, 75);
        //                break;
        //            case 5:
        //                _game.Players[i].GameBoardUIControl.Frame = new CGRect(718, 0, 50, 75);
        //                break;
        //            case 6:
        //                _game.Players[i].GameBoardUIControl.Frame = new CGRect(974, 576, 50, 75);
        //                break;
        //            case 7:
        //                _game.Players[i].GameBoardUIControl.Frame = new CGRect(974, 192, 50, 75);
        //                break;
        //        }
        //    }
        //}

        private void DrawDiscardPile()
        {
            if (DiscardPileCardView == null)
            {
                DiscardPileCardView = new CardView();

                DiscardPileCardView.Frame = new CGRect(viewWidth / 2 - 55, viewHeight / 2 - 35.5, 50, 75);

                View.AddSubview(DiscardPileCardView);
            }
            else
            {
                if ( _game.DiscardPile.Cards.Count > 0)
                {
                    int bottomCardIndex = _game.DiscardPile.Cards.Count - 1;

                    DiscardPileCardView.SetCard(_game.DiscardPile.Cards[bottomCardIndex]);
                }
            }



            //if(_game.DiscardPile.GameBoardUIControl == null) 
            //{
            // create new card control
            //_game.DiscardPile.GameBoardUIControl = new UILabel();
            //_game.DiscardPile.GameBoardUIControl.BackgroundColor = UIColor.Cyan;
            //_game.DiscardPile.GameBoardUIControl.Text = "Empty";
            //_game.DiscardPile.GameBoardUIControl.TextColor = UIColor.Blue;
            //_game.DiscardPile.GameBoardUIControl.TextAlignment = UITextAlignment.Center;

            //_game.DiscardPile.GameBoardUIControl.Frame = new CGRect(viewWidth / 2 - 55, viewHeight / 2 - 35.5, 50, 75);

            //View.AddSubview(_game.DiscardPile.GameBoardUIControl);
            //}

            //if (_game.DiscardPile.Cards != null && _game.DiscardPile.Cards.Count > 0)
            //{
            // get the top card of the discard pile
            //_game.DiscardPile.GameBoardUIControl.Text = _game.DiscardPile.Cards[0].ShortName;
            //}
        }

        private void DrawDeck()
        {
            if (GameDeckCardView == null)
            {
                GameDeckCardView = new CardView();

                GameDeckCardView.Frame = new CGRect(viewWidth / 2 + 5, viewHeight / 2 - 35.5, 50, 75);

                View.AddSubview(GameDeckCardView);
            }
            else
            {
                if ( _game.GameDeck.Cards.Count >0)
                {
                    // for now show top card, eventually just show flipped over card
                    GameDeckCardView.SetCard(_game.GameDeck.Cards[0]);
                }
            }


            //if(_game.GameDeck.GameBoardUIControl == null)
            //{
            //    // create new card control
            //    _game.GameDeck.GameBoardUIControl = new UILabel();
            //    _game.GameDeck.GameBoardUIControl.BackgroundColor = UIColor.Cyan;
            //    _game.GameDeck.GameBoardUIControl.Text = "Empty";
            //    _game.GameDeck.GameBoardUIControl.TextColor = UIColor.Black;
            //    _game.GameDeck.GameBoardUIControl.TextAlignment = UITextAlignment.Center;

            //    _game.GameDeck.GameBoardUIControl.Frame = new CGRect(viewWidth / 2 + 5, viewHeight / 2 - 35.5, 50, 75);

            //    View.AddSubview(_game.GameDeck.GameBoardUIControl);
            //}

            //// update to top card if exists
            //if(_game.GameDeck.Cards != null && _game.GameDeck.Cards.Count > 0)
            //{
            //    //_game.GameDeck.CardView.Value.Text = _game.GameDeck.Cards[0].ShortName;
            //    _game.GameDeck.GameBoardUIControl.Text = _game.GameDeck.Cards[0].ShortName;
            //}
        }

        private void HandleDrag(UIPanGestureRecognizer recognizer)
        {
            //CGRect originalFrame = CGRect.Empty;

            ////UILabel labelDragged = View.Subviews

            //if(recognizer.State == UIGestureRecognizerState.Began)
            //{
            //    // set postion at start of drag
            //    originalFrame = recognizer.View.Frame;
            //}

            //if(recognizer.State != (UIGestureRecognizerState.Cancelled | UIGestureRecognizerState.Failed | UIGestureRecognizerState.Possible))
            //{
            //    // move the image
            //    CGPoint offset = recognizer.TranslationInView(recognizer.View);
            //    CGRect newFrame = originalFrame;
            //    newFrame.Offset(offset.X, offset.Y);
            //    recognizer.View.Frame = newFrame;
            //}

            //if(recognizer.State == UIGestureRecognizerState.Ended)
            //{
            //    CGRect temp = CGRect.Empty;
            //}
        }
    }
}
