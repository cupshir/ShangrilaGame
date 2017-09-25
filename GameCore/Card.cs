using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class Card
    {
        #region Properties

        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }
        public int DealValue { get; set; }

        #endregion

    }
}
