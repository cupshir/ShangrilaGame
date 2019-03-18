using System;
using System.Collections.Generic;
using CoreGraphics;
using ShangrilaRummy.Model;
using UIKit;

namespace ShangrilaRummy
{
    public class HandView : UIView
    {
        Hand Hand;

        List<CardView> _hand;

        public HandView(Hand hand)
        {
            RemoveFromSuperview();

            nfloat cardPosX = 267;
            nfloat cardPosY = 613;

            int cardNumber = 0;

            foreach (var handCard in hand.Cards)
            {
                CardView cardView = new CardView(handCard);

                cardView.Frame = new CGRect(cardPosX, cardPosY, 50, 75);

                AddSubview(cardView);

                cardNumber++;

                // move to next position
                cardPosX += 55;

                if(cardNumber == 9)
                {
                    // move next card cords to next line
                    cardPosX = 267;
                    cardPosY = 693;
                }



            }



        }
    }
}
