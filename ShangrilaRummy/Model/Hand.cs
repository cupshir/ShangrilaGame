using System.Collections.Generic;

namespace ShangrilaRummy.Model
{
    public class Hand
    {
        public List<Card> Cards { get; set; }
        public bool IsDown { get; set; }

        public Hand()
        {
        }
    }
}
