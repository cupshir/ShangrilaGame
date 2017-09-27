using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public Deck GameDeck { get; set; }
        public Deck DiscardPile { get; set; }
        public Rounds Round { get; set; }
    }


    public enum Rounds
    {
        NotStarted = 0,
        TwoSetsOneRun = 1,
        TwoRunsOneSet = 2,
        ThreeSets = 3,
        ThreeRuns = 4,
        ThreeSetsOneRun = 5,
        TwoSetsTwoRuns = 6,
        FourSets = 7,
        Ended = 8
    }
}
