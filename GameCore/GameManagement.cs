﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class GameManagement
    {
        public static Game CreateGame( List<Player> players, int numberOfDecks )
        {
            Game newGame = new Game()
            {
                Players = players,
                GameDeck = Deck.BuildDecks( numberOfDecks )
            };

            return newGame;
        }

        public static Game Deal( Game game )
        {
            // First clear out any existing cards from player hands from determing deal or previous game
            for ( int i = 0; i < game.Players.Count; i++ )
            {
                game.Players[i].Hand.Clear();
            }
            
            // Create List of players for current deal order
            List<Player> playerHands = new List<Player>();

            // Create dealer object and new dealer index
            Player dealer = new Player();
            int dealerIndex = 0;

            // Get a list of players that are IsDealer true
            List<Player> dealers = game.Players.Where( a => a.IsDealer == true ).ToList();

            // Check that only 1 player was returned as dealer
            if ( dealers.Count != 1 )
            {
                // no dealer set or multiple dealers set, return. Throw error at some point...
                return game;
            }
            else
            {
                // set dealer object
                dealer = dealers[0];
            }
            
            // get the index number of the dealer
            if ( dealer != null )
            {
                dealerIndex = game.Players.FindIndex( a => a.SeatNumber == dealer.SeatNumber );

                // Set the current turn for player after dealer
                // if last player in list is dealer, set first player in list as current turn
                if((dealerIndex + 1) == game.Players.Count )
                {
                    game.Players[0].CurrentTurn = true;
                }
                else
                {
                    // set the player in list after dealer as current turn
                    game.Players[( dealerIndex + 1 )].CurrentTurn = true;
                }
            }
            else
            {
                // no dealer set, return. Throw error at some point...
                return game;
            }

            // Add players from game into playerHands list starting with Dealer+1 (dealer should be last in list)
            // Skip if dealer is last in game list to prevent out of range
            if ( dealerIndex != game.Players.Count )
            {
                // loop through each player after the dealer
                for ( int i = ( dealerIndex + 1 ); i < game.Players.Count; i++ )
                {
                    // get player
                    Player player = game.Players[i];
                    // add player to player hands
                    playerHands.Add( player );
                }
            }
            // Add remaining players
            for ( int i = 0; i <= dealerIndex; i++ )
            {
                // get player
                Player player = game.Players[i];
                // add player to player hands
                playerHands.Add( player );
            }

            // Deal 11 cards to the players removing the cards from the deck
            for ( int i = 0; i < 11; i++ )
            {
                // loop through each player
                for ( int j = 0; j < playerHands.Count; j++ )
                {
                    // get first card in deck
                    Card card = game.GameDeck.Cards[0];
                    // add card to player hand
                    playerHands[j].Hand.Add( card );
                    // remove card from deck
                    game.GameDeck.Cards.Remove( card );
                }                
            }

            // loop through each player in player hands
            foreach ( Player player in playerHands )
            {
                // Copy player hands back into game object
                game.Players.Find( x => x.SeatNumber == player.SeatNumber ).Hand = player.Hand;
            }
            
            // return the updated game
            return game;
        }

        public static Game DetermineDealer( Game game )
        {
            // Clear Player cards, score, isdealer, and current turn
            for ( int i = 0; i < game.Players.Count; i++ )
            {
                game.Players[i].Hand.Clear();
                game.Players[i].Score = 0;
                game.Players[i].IsDealer = false;
                game.Players[i].CurrentTurn = false;
            }
            
            // Create card list of single suit and one joker to use to determine dealer (deck cant have duplicate cards)
            Deck deck = new Deck() { Cards = new List<Card>()};

            // Build a single suit of cards and add to list
            for ( int i = 2; i < 15; i++ )
            {
                Card card = new Card();
                card.Suit = "Spades";
                card.Name = Deck.GetName( i );
                card.ShortName = Deck.GetShortName( i );
                card.Value = Deck.GetValue( i );
                card.DealValue = i;
                deck.Cards.Add( card );
            }

            // add Joker ro list
            Card joker = new Card();
            joker.Suit = "Wild";
            joker.Name = "Joker";
            joker.ShortName = "J";
            joker.Value = 25;
            joker.DealValue = 15;
            deck.Cards.Add( joker );

            // Riffle and Overhand Shuffle Deck 7x
            for ( int i = 0; i < 7; i++ )
            {
                deck = Deck.OverhandShuffleDeck( deck );
                deck = Deck.RiffleShuffleDeck( deck );
            }

            // Deal each player a card from the top of the deck
            foreach ( Player player in game.Players )
            {
                // get card
                Card card = deck.Cards[0];
                // add card to player hand
                player.Hand.Add( card );
                // remove card from list
                deck.Cards.Remove( card );
                // Set player score to cards deal value, used later to determine dealer
                player.Score = card.DealValue;
            }

            // get player with highest score
            Player dealer = game.Players.OrderByDescending( x => x.Score ).First();
            if ( dealer != null )
            {
                // set the isdealer true on player with highest score
                game.Players.Find( x => x.Score == dealer.Score ).IsDealer = true;
            }
            else
            {
                // throw error eventually
                return game;
            }

            return game;
        }
    }
}
