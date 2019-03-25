using System;
using ShangrilaRummy.Model;
using UIKit;

namespace ShangrilaRummy
{
    public class CardView : UIView
    {
        public Card Card;

        UILabel cardText;

        public CardView()
        {
            BackgroundColor = UIColor.White;

            cardText = new UILabel();
            cardText.Text = "Empty";

            cardText.TextColor = UIColor.Black;

            this.Layer.BorderColor = UIColor.Blue.CGColor;
            this.Layer.BorderWidth = 1;

            cardText.SizeToFit();


            AddSubview(cardText); 
        }

        public void SetCard(Card newCard)
        {
            if ( newCard != null)
            {
                Card = newCard;
            }
            else
            {
                Card = null;
                cardText.Text = "Empty";
            }

            UpdateCardView();
        }

        public void UpdateCardView()
        {
            if (Card != null)
            {
                cardText.Text = Card.ShortName;

                if (Card.Suit == "Hearts" || Card.Suit == "Diamonds")
                {
                    cardText.TextColor = UIColor.Red;
                }
                else
                {
                    cardText.TextColor = UIColor.Black;
                }
            }
            else
            {
                cardText.Text = "Empty";
                cardText.TextColor = UIColor.Black;
            }
        }
    }
}
