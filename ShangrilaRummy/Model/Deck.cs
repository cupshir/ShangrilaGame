using System.Collections.Generic;

namespace ShangrilaRummy.Model
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
        public int NumberOfDecks { get; set; }

        // deck view in future?
        public CardView CardView { get; set; }

        public Deck()
        {
        }
    }
}
