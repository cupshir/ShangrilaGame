using System;
using UIKit;
using CoreGraphics;
using System.Drawing;
using ShangrilaRummy.Model;

namespace ShangrilaRummy
{
    public class CardView : UIView
    {
        public Card Card;

        UILabel _Value;

        public CardView(Card newCard)
        {
            BackgroundColor = UIColor.Red;

            _Value = new UILabel();
            _Value.Text = newCard.ShortName;
            _Value.TextColor = UIColor.Green;

            _Value.SizeToFit();

            AddSubview(_Value);  

        

        }


        public void UpdateLayout() 
        {
            Frame = new CGRect(0, 0, 50, 50);
            _Value.Frame = new CGRect(0, 0, _Value.Frame.Width,_Value.Frame.Height);
        }

        public void UpdateCard(string shortName)
        {
            _Value.Text = shortName;
        }


    }
}
