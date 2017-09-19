using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsDealer { get; set; }
        public List<Card> Hand { get; set; }

        public static Player CreatePlayer(string name )
        {
            Player newPlayer = new Player()
            {
                Name = name,
                Score = 0,
                IsDealer = false,
                Hand = new List<Card>()
            };

            return newPlayer;

        }

        public static void PrintPlayers(List<Player> players )
        {
            foreach ( Player player in players )
            {
                if ( player.IsDealer )
                {
                    player.Name = player.Name + "*";
                }
                Console.WriteLine( player.Name );
            }
        }

        public static void PrintPlayerHand(Player player)
        {
            string playerHand = "";

            foreach ( Card card in player.Hand )
            {
                playerHand += String.Format( "{0} {1} ", card.ShortName, card.Suit );
            }

            Console.WriteLine( String.Format( "{0} has {1} cards", player.Name, player.Hand.Count ) );
            Console.WriteLine( playerHand );
            Console.WriteLine();
        }

        public static List<Player> CreateTestPlayers()
        {
            Player player1 = Player.CreatePlayer( "Christopher" );
            Player player2 = Player.CreatePlayer( "Carissa" );
            Player player3 = Player.CreatePlayer( "Doug" );
            Player player4 = Player.CreatePlayer( "Damien" );
            Player player5 = Player.CreatePlayer( "Maddie" );
            Player player6 = Player.CreatePlayer( "Box" );
            Player player7 = Player.CreatePlayer( "Nicki" );

            List<Player> players = new List<Player>();
            players.Add( player1 );
            players.Add( player2 );
            players.Add( player3 );
            players.Add( player4 );
            players.Add( player5 );
            players.Add( player6 );
            players.Add( player7 );

            return players;
        }

    }


}
