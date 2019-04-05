using System;
using System.Collections.Generic;
using CoreGraphics;
using ShangrilaRummy.Model;
using UIKit;

namespace ShangrilaRummy
{
    public class CardGroupView : UIView
    {

        List<CardView> CardViews;

        public CardGroupView()
        {
            // initialize new list
            CardViews = new List<CardView>();
        }

        public void AddCardToGroup(Card card)
        {
            CardView cardView = CardViews.Find(a => a.Card == card);

            if (cardView == null)
            {
                nfloat posX = 0;
                nfloat posY = 0;

                if (CardViews.Count == 1)
                {
                    posX = 25;

                } else if ( CardViews.Count > 1)
                {
                    posX = 25 * CardViews.Count;

                }

                // create new cardView and add to group views
                cardView = new CardView
                {
                    Frame = new CGRect(posX, posY, 50, 75)
                };

                cardView.SetCard(card);
                CardViews.Add(cardView);

                AddSubview(cardView);

            }
        }

        public void RemoveCardFromGroup(Card card)
        {
            CardView cardView = CardViews.Find(a => a.Card == card);

            if (cardView != null)
            {
                CardViews.Remove(cardView);
                                
            }
        }
    }
}
