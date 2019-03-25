using System.Collections.Generic;
using UIKit;

namespace ShangrilaRummy.Model
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public bool CurrentTurn { get; set; }
        public bool IsDealer { get; set; }
        public bool IsBuyer { get; set; }
        public bool IsWinner { get; set; }
        public int SeatNumber { get; set; }
        public Hand Hand { get; set; }
        public List<Hand> TableHands { get; set; }

        public Player()
        {
        }
    }
}
