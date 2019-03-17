using System;
namespace GameCore
{
    public class CardService
    {

        public static string GetName(int i)
        {
            if (i == 14)
            {
                return "Ace";
            }
            else if (i == 13)
            {
                return "King";
            }
            else if (i == 12)
            {
                return "Queen";
            }
            else if (i == 11)
            {
                return "Jack";
            }
            else
            {
                return i.ToString();
            }
        }

        public static string GetShortName(int i)
        {
            if (i == 14)
            {
                return "A";
            }
            else if (i == 13)
            {
                return "K";
            }
            else if (i == 12)
            {
                return "Q";
            }
            else if (i == 11)
            {
                return "J";
            }
            else
            {
                return i.ToString();
            }
        }

        public static int GetValue(int i)
        {
            if (i == 14)
            {
                return 15;
            }
            else if (i > 8 && i < 14)
            {
                return 10;
            }
            else
            {
                return 5;
            }
        }



    }
}
