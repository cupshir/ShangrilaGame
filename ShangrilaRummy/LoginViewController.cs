using System;
using UIKit;
using CoreGraphics;

namespace ShangrilaRummy
{
    public class LoginViewController : UIViewController
    {
        UITextField emailField;
        UITextField passwordField;

        public LoginViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Gray;

            emailField = new UITextField
            {
                Placeholder = "Enter your username",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new CGRect(200, 100, View.Bounds.Width - 400, 30)
            };

            passwordField = new UITextField
            {
                Placeholder = "Enter your password",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new CGRect(200,150, View.Bounds.Width - 400, 30)
            };

            var submitButton = UIButton.FromType(UIButtonType.RoundedRect);

            submitButton.Frame = new CGRect(200, 200, View.Bounds.Width - 400, 30);
            submitButton.SetTitle("Login", UIControlState.Normal);
            submitButton.BackgroundColor = UIColor.White;
            submitButton.Layer.CornerRadius = 5f;


            submitButton.TouchUpInside += (sender, e) => {
                
            };

            View.AddSubviews(new UIView[] { emailField, passwordField, submitButton });

        }
    }
}
