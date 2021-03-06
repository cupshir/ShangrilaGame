﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
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
        public List<Card> Hand { get; set; }
        public List<List<Card>> TableHands { get; set; }

        public static Player CreatePlayer( string name, int seatNumber )
        {
            Player newPlayer = new Player()
            {
                Name = name,
                Score = 0,
                CurrentTurn = false,
                IsDealer = false,
                IsBuyer = false,
                IsWinner = false,
                SeatNumber = 0,
                Hand = new List<Card>(),
                TableHands = new List<List<Card>>()
            };

            for ( int i = 0; i < 4; i++ )
            {
                newPlayer.TableHands.Add( new List<Card>());
            }

            return newPlayer;
        }

        // Set all IsBuyer for all players to false
        public static Game ResetIsBuyer(Game game )
        {
            // Loop through all players
            for ( int i = 0; i < game.Players.Count; i++ )
            {
                // Set IsBuyer to false
                game.Players[i].IsBuyer = false;
            }
            
            // Return game
            return game;
        }

        public static Game ResetCurrentTurn( Game game )
        {
            // loop through players
            for ( int i = 0; i < game.Players.Count; i++ )
            {
                // set currentTurn false
                game.Players[i].CurrentTurn = false;
            }

            return game;
        }

        // Remove when done testing, only used for testing
        public static List<Player> CreateTestPlayers()
        {
            Player player1 = Player.CreatePlayer( "Christopher", 1 );
            player1.IsDealer = true;
            player1.SeatNumber = 1;
            Player player2 = Player.CreatePlayer( "Carissa", 2 );
            player2.SeatNumber = 2;
            Player player3 = Player.CreatePlayer( "Doug", 3 );
            player3.SeatNumber = 3;
            Player player4 = Player.CreatePlayer( "Damien", 4 );
            player4.SeatNumber = 4;
            Player player5 = Player.CreatePlayer( "Maddie", 5 );
            player5.SeatNumber = 5;
            Player player6 = Player.CreatePlayer( "Box", 6 );
            player6.SeatNumber = 6;
            Player player7 = Player.CreatePlayer( "Nicki", 7 );
            player7.SeatNumber = 7;

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
