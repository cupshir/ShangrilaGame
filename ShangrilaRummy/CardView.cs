using System;
using ShangrilaRummy.Model;
using UIKit;

namespace ShangrilaRummy
{
    public class CardView : UIView
    {
        public Card Card;
        public bool IsSelected;

        UILabel cardText;

        public CardView()
        {
            BackgroundColor = UIColor.White;

            cardText = new UILabel
            {
                Text = "Empty",
                TextColor = UIColor.Black
            };

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
                ResetCard();


            }

            UpdateCardView();
        }

        public void ToggleSelection(bool selection)
        {
            if (selection)
            {
                IsSelected = true;
            }
            else
            {
                IsSelected = false;
            }

            UpdateCardView();
        }

        public void UpdateCardView()
        {
            if (Card != null)
            {
                cardText.Text = Card.ShortName;

                if ( IsSelected )
                {
                    cardText.BackgroundColor = UIColor.Red;

                    cardText.TextColor = UIColor.White;
                }
                else
                {
                    cardText.BackgroundColor = UIColor.White;

                    if (Card.Suit == "Hearts" || Card.Suit == "Diamonds")
                    {
                        cardText.TextColor = UIColor.Red;
                    }
                    else
                    {
                        cardText.TextColor = UIColor.Black;
                    }
                }
            }
            else
            {
                ResetCard();
            }
        }

        private void ResetCard()
        {
            Card = null;
            cardText.Text = "Empty";
            cardText.BackgroundColor = UIColor.White;
            cardText.TextColor = UIColor.Black;
            IsSelected = false;
        }
    }
}
