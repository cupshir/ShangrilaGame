using System;
using UIKit;
using GameCore.Model;
using CoreGraphics;
using System.Drawing;

namespace ShangrilaRummy
{
    public class CardView : UIView
    {
        public Card card;

        UILabel value;

        public CardView( Card newCard)
        {
            BackgroundColor = UIColor.Red;

            value = new UILabel();
            value.Text = newCard.ShortName;
            value.TextColor = UIColor.Green;

            value.SizeToFit();

            AddSubview(value);  

        

        }


        public void UpdateLayout() 
        {
            Frame = new CGRect(0, 0, 50, 50);
            value.Frame = new CGRect(0, 0, value.Frame.Width, value.Frame.Height);

        }



    }
}
