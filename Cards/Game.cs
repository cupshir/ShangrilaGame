using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public Deck GameDeck { get; set; }

        public static Game CreateGame(List<Player> players, int numberOfDecks )
        {
            Game newGame = new Game()
            {
                Players = players,
                GameDeck = Deck.BuildDecks( numberOfDecks )
            };

            return newGame;
        }

        public static Game DetermineDealer(Game game )
        {
            // Create Deck to use to determine dealer (deck cant have duplicate cards)
            Deck deck = Deck.BuildDecks( 1 );

            // Shuffle Deck 7x
            for ( int i = 0; i < 7; i++ )
            {
                deck.RiffleShuffleDeck( deck );
            }

            // Deal each player a card from the top of the deck
            foreach ( Player player in game.Players )
            {
                Card card = deck.Cards[0];
                player.Hand.Add( card );
                deck.Cards.Remove( card );

                // Set score to cards deal value, used later to determine dealer
                player.Score = card.DealValue;
            }
           
            // Player with highest score is the dealer
            Player dealer = game.Players.OrderByDescending( x => x.Score ).First();
            dealer.IsDealer = true;
            game.Players.Remove( dealer );
            game.Players.Add( dealer );

            return game;
        }

    }
}
