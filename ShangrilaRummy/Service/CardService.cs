using System;
namespace ShangrilaRummy.Service
{
    public class CardService
    {
        public CardService()
        {
        }

        public static string GetName(int i)
        {
            switch (i)
            {
                case 14:
                    return "Ace";
                case 13:
                    return "King";
                case 12:
                    return "Queen";
                case 11:
                    return "Jack";
                default:
                    return i.ToString();
            }
        }

        public static string GetShortName(int i)
        {
            switch (i)
            {
                case 14:
                    return "A";
                case 13:
                    return "K";
                case 12:
                    return "Q";
                case 11:
                    return "J";
                default:
                    return i.ToString();
            }
        }

        public static int GetPointValue(int i)
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
