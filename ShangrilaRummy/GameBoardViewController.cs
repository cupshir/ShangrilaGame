using System;
using UIKit;
using GameCore.Model;
using GameCore.Service;
using CoreGraphics;
using System.Collections.Generic;
using ShangrilaRummy.Model;
using ShangrilaRummy.Service;

namespace ShangrilaRummy
{
    public class GameBoardViewController : UIViewController
    {
        GameiOS game;

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

            game = GameServiceiOS.CreateGameiOS( GameService.CreateTestPlayers(), 3 );

            DrawGameBoard( game );



        }

        private void DrawGameBoard( Game gameToDraw )
        {
            DrawDeck(gameToDraw.GameDeck);

            DrawDiscardPile(gameToDraw.DiscardPile);

            DrawPlayers(gameToDraw.Players);

            DrawControls();


            // notes
            // width: 1024 - half: 512
            // height: 768 - half: 384
            //




        }

        private void DrawControls()
        {
            UIButton dealUIButton = UIButton.FromType(UIButtonType.RoundedRect);
            dealUIButton.Frame = new CGRect( 512, 200, 50, 25);
            dealUIButton.BackgroundColor = UIColor.White;
            dealUIButton.SetTitle("Deal", UIControlState.Normal);

            dealUIButton.TouchUpInside += (sender, e) => {
                game = GameService.Deal(game);

                DrawGameBoard(game);
            };


            View.AddSubview(dealUIButton);



        }

        private void DrawPlayers(List<Player> players)
        {
            // loop through players to draw
            DrawOtherPlayers(players);

            DrawPlayer(players[0]);
        }

        private void DrawPlayer(Player player)
        {
         
        }

        private void DrawOtherPlayers(List<Player> players)
        {
            foreach (var player in players)
            {
                if (player.SeatNumber == 1)
                {
                    // skip first player
                    continue;
                }

                Card otherPlayerCardCount = new Card();

                if ( player.Hand.Cards != null && player.Hand.Cards.Count > 0)
                {
                    otherPlayerCardCount.ShortName = player.Hand.Cards.Count.ToString();
                }
                else 
                {
                    otherPlayerCardCount.ShortName = "Empty";
                }



                CardView otherPlayerCardView = new CardView( otherPlayerCardCount );
                // Player2: 0, 192
                // Player3: 0, 576
                // Player4: 256 ,0
                // Player5: 768 ,0
                // Player6: 576, 974
                // Player7: 192, 974

                switch (player.SeatNumber)
                {
                    case 2:
                        otherPlayerCardView.Frame = new CGRect(0, 192, 50, 75);
                        break;
                    case 3:
                        otherPlayerCardView.Frame = new CGRect(0, 576, 50, 75);
                        break;
                    case 4:
                        otherPlayerCardView.Frame = new CGRect(256, 0, 50, 75);
                        break;
                    case 5:
                        otherPlayerCardView.Frame = new CGRect(718, 0, 50, 75);
                        break;
                    case 6:
                        otherPlayerCardView.Frame = new CGRect(974, 576, 50, 75);
                        break;
                    case 7:
                        otherPlayerCardView.Frame = new CGRect(974, 192, 50, 75);
                        break;
                }

                View.AddSubview(otherPlayerCardView);

            }
        }

        private void DrawDiscardPile(Deck discardPile)
        {
            Card renderCard = new Card();

            if (discardPile.Cards.Count > 0)
            {
                // get the top card of the discard pile
                renderCard = discardPile.Cards[0];
            }
            else 
            {
                // set value to -1 as way to indicate discard pile is empty
                // im guessing there is a better way lol
                //renderCard.ShortName = "Empty";
                renderCard.ShortName = View.Subviews.Length.ToString();
            
            }

            // draw the top card in the discard pile
            CardView discardPileView = new CardView( renderCard );

            discardPileView.Frame = new CGRect(viewWidth / 2 - 30, viewHeight / 2 - 35.5, 50, 75);

            View.AddSubview(discardPileView);
        }

        private void DrawDeck(Deck gameDeck)
        {
            // for now draw top card in deck
            // eventually draw game deck using DeckView
            Card renderCard = new Card();

            if (gameDeck.Cards.Count > 0)
            {
                renderCard = gameDeck.Cards[0];
            }
            else
            {
                // set value to -1 as way to indicate discard pile is empty
                // im guessing there is a better way lol
                renderCard.ShortName = "Empty";
            }

            CardView deckCardView = new CardView(renderCard);

            deckCardView.Frame = new CGRect(viewWidth / 2 + 30, viewHeight / 2 - 35.5, 50, 75);

            View.AddSubview(deckCardView);

        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            //cardView.UpdateLayout();
            
        }
    }
}
