using System.Collections.Generic;
using UIKit;

namespace ShangrilaRummy.Model
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
        public int NumberOfDecks { get; set; }

        // better way?
        public UILabel GameBoardUIControl { get; set; }

        public Deck()
        {
        }
    }
}
