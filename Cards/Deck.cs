using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Deck
    {
        #region Properties

        public List<Card> Cards { get; set; }

        #endregion

        private Random _rng = new Random();

        public static Deck BuildDecks(int numberToBuild)
        {
            // Build 1st deck
            Deck deck = BuildDeck();

            // Build multiple decks if required
            if(numberToBuild > 1 )
            {
                for ( int i = 1; i < numberToBuild; i++ )
                {
                    Deck addDeck = BuildDeck();
                    deck.Cards.AddRange( addDeck.Cards );
                }
            }

            return deck;
        }

        private static Deck BuildDeck()
        {
            // Create empty deck
            Deck deck = new Deck() { Cards = new List<Card>() };

            // Suits in Deck
            string[] suits = new string[4] { "Hearts", "Diamonds", "Clubs", "Spades" };

            // Add cards for each suit
            foreach ( string suit in suits )
            {
                for ( int i = 2; i < 15; i++ )
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Name = GetName( i );
                    card.ShortName = GetShortName( i );
                    card.Value = GetValue( i );

                    deck.Cards.Add( card );
                }
            }

            // Add in jokers here...

            return deck;
        }

        private static string GetName( int i )
        {
            if ( i == 14 )
            {
                return "Ace";
            }
            else if ( i == 13 )
            {
                return "King";
            }
            else if ( i == 12 )
            {
                return "Queen";
            }
            else if ( i == 11 )
            {
                return "Jack";
            }
            else
            {
                return i.ToString();
            }            
        }

        private static string GetShortName( int i )
        {
            if ( i == 14 )
            {
                return "A";
            }
            else if ( i == 13 )
            {
                return "K";
            }
            else if ( i == 12 )
            {
                return "Q";
            }
            else if ( i == 11 )
            {
                return "J";
            }
            else
            {
                return i.ToString();
            }
        }

        private static int GetValue( int i )
        {
            if ( i == 14 )
            {
                return 15;
            }
            else if ( i > 8 && i < 14 )
            {
                return 10;
            }
            else
            {
                return 5;
            }
        }

        public Deck RiffleShuffleDeck(Deck deck )
        {
            // Creat empty decks to split into
            Deck firstHalf = new Deck() { Cards = new List<Card>() };
            Deck secondHalf = new Deck() { Cards = new List<Card>() };
            
            // Copy cards into the two decks
            int count = 0;
            foreach ( Card card in deck.Cards )
            {
                count++;
                if ( count <= ( deck.Cards.Count / 2 ))
                {
                    firstHalf.Cards.Add( card );
                }
                else
                {
                    secondHalf.Cards.Add( card );
                }
            }

            // if copy was successful then clear cards from original deck
            if (deck.Cards.Count == (firstHalf.Cards.Count + secondHalf.Cards.Count ) )
            {
                deck.Cards.Clear();
            }
            else
            {
                Console.WriteLine( "Deck did not split evenly" );
                return deck;
            }
            
            // Recombine the two decks in random chunks (Simulate shuffling)
            int totalCount = firstHalf.Cards.Count + secondHalf.Cards.Count;

            while ( deck.Cards.Count != totalCount )
            {
                // Randomize Stack count for first half
                int stackCount = GetRandomStack();

                // Check that stack count is not greater than remaining cards in firstHalf
                // If it is greater, set stack count to remaining cards count
                if ( stackCount > firstHalf.Cards.Count )
                {
                    stackCount = firstHalf.Cards.Count;
                }

                // Skip if stackCount = 0
                if ( stackCount != 0 )
                {
                    // Add stack from first half to deck
                    for ( int i = 0; i < stackCount; i++ )
                    {
                        Card card = firstHalf.Cards[0];
                        deck.Cards.Add( card );
                        firstHalf.Cards.Remove( card );
                    }
                }

                // Randomize Stack count for second half
                stackCount = GetRandomStack();

                // Check that stack count is not greater than remaining cards in secondHalf
                // If it is greater, set stack count to remaining cards count
                if ( stackCount > secondHalf.Cards.Count )
                {
                    stackCount = secondHalf.Cards.Count;
                }

                // Skip if stackCount = 0
                if (stackCount != 0 )
                {
                    // Add stack from second half to deck
                    for ( int i = 0; i < stackCount; i++ )
                    {
                        Card card = secondHalf.Cards[0];
                        deck.Cards.Add( card );
                        secondHalf.Cards.Remove( card );
                    }
                }               
            }

            return deck;
        }

        private int GetRandomStack()
        {
            int stackNumber;
           
            int roll = _rng.Next( 0, 100 );
            if (roll > 100 )
            {
                stackNumber = 5;
            }
            else if (roll > 75 && roll < 101 )
            {
                stackNumber = 4;
            }
            else if (roll > 50 && roll < 76 )
            {
                stackNumber = 3;
            }
            else if (roll > 25 && roll < 51 )
            {
                stackNumber = 2;
            }
            else
            {
                stackNumber = 1;
            }

            return stackNumber;
        }

        public static void PrintDeck(Deck deck)
        {
            if(deck.Cards.Count != 0 )
            {
                int count = 0;
                foreach ( Card card in deck.Cards )
                {
                    count++;

                    Console.Write( Card.PrintCard( card ) );
                    Console.Write( " " );
                    if ( count == 13 )
                    {
                        Console.WriteLine();
                        count = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine( "No Cards in the deck" );
            }

            Console.WriteLine();
        }
    }
}
