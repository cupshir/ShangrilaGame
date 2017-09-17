using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Card
    {
        #region Properties

        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        #endregion

        public static string PrintCard(Card card )
        {
            return String.Format( "{0}{1}", card.ShortName, card.Suit[0] );
        }

        public static string PrintCardFullInfo(Card card )
        {
            return String.Format( "{0} of {1} worth {2}", card.Name, card.Suit, card.Value );
        }

    }
}
