using System;
using System.Collections.Generic;
using UIKit;

namespace ShangrilaRummy.Model
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public Deck GameDeck { get; set; }
        public Deck DiscardPile { get; set; }
        public Rounds Round { get; set; }

        public Game()
        {
        }

        public enum Rounds
        {
            NotStarted,
            TwoSetsOneRun,
            TwoRunsOneSet,
            ThreeSets,
            ThreeRuns,
            ThreeSetsOneRun,
            TwoSetsTwoRuns,
            FourSets,
            Ended
        }
    }
}
