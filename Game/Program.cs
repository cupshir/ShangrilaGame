using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cards;

namespace ConsoleGame
{
    class Program
    {
        static void Main( string[] args )
        {
            List<Player> players = Player.CreateTestPlayers();

            Game newGame = Game.CreateGame( players, 2 );
           
                        
            if (newGame.GameDeck.Cards != null )
            {
                //Console.WriteLine( "Total Cards " + newGame.GameDeck.Cards.Count );
                //Console.WriteLine();

                //Deck.PrintDeck( newGame.GameDeck );

                //Player.PrintPlayers( newGame.Players );

                //Console.WriteLine( "Shuffling..." );
                //Console.WriteLine();

                //newGame.GameDeck = newGame.GameDeck.RiffleShuffleDeck( newGame.GameDeck );

                //Deck.PrintDeck( newGame.GameDeck );

                //Console.WriteLine( "After Shuffling..." );
                //Console.WriteLine();

                //Deck.PrintDeck( newGame.GameDeck );

                //newGame.GameDeck = newGame.GameDeck.RiffleShuffleDeck( newGame.GameDeck );

                //Console.WriteLine( "After Shuffling..." );
                //Console.WriteLine();

                //Deck.PrintDeck( newGame.GameDeck );
                //newGame.GameDeck = newGame.GameDeck.RiffleShuffleDeck( newGame.GameDeck );

                //Console.WriteLine( "After Shuffling..." );
                //Console.WriteLine();

                //Deck.PrintDeck( newGame.GameDeck );


                Game.DetermineDealer( newGame );

                Console.WriteLine();
                Console.WriteLine( "Dealer is...." );
                Console.WriteLine();

                Player.PrintPlayers( newGame.Players );

            }
            else
            {
                Console.WriteLine( "Deck Build Failed" );
            }
             
            Console.ReadLine();

        }


    }

}
