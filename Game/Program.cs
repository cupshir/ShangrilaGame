using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cards;

namespace Game
{
    class Program
    {
        static void Main( string[] args )
        {
            Deck gameDeck = Deck.BuildDecks(1);
            
                        
            if (gameDeck != null )
            {
                Console.WriteLine( "Total Cards " + gameDeck.Cards.Count );
                Console.WriteLine();

                Deck.PrintDeck( gameDeck );
                
                Console.WriteLine( "Shuffling..." );
                Console.WriteLine();

                gameDeck = gameDeck.RiffleShuffleDeck( gameDeck );

                Deck.PrintDeck( gameDeck );

                Console.WriteLine( "After Shuffling..." );
                Console.WriteLine();

                Deck.PrintDeck( gameDeck );

                gameDeck = gameDeck.RiffleShuffleDeck( gameDeck );

                Console.WriteLine( "After Shuffling..." );
                Console.WriteLine();

                Deck.PrintDeck( gameDeck );
                gameDeck = gameDeck.RiffleShuffleDeck( gameDeck );

                Console.WriteLine( "After Shuffling..." );
                Console.WriteLine();

                Deck.PrintDeck( gameDeck );

            }
            else
            {
                Console.WriteLine( "Deck Build Failed" );
            }
             
            Console.ReadLine();

        }
    }
}
