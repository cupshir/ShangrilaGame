using System;
using System.Collections.Generic;
using System.Linq;
using ShangrilaRummy.Model;
using static ShangrilaRummy.Model.Game;

namespace ShangrilaRummy.Service
{
    public class GameService
    {
        public GameService()
        {
        }

        public static GameService Game = new GameService();

        public static Game CreateGame(List<Player> players, int numberOfDecks)
        {
            Game newGame = new Game()
            {
                Players = players,
                GameDeck = DeckService.BuildDecks(numberOfDecks),
                DiscardPile = new Deck() { Cards = new List<Card>() },
                Round = Rounds.NotStarted
            };

            return newGame;
        }

        public static Game Deal(Game game)
        {
            // First clear out any existing cards from player hands from determing deal or previous game
            for (int i = 0; i < game.Players.Count; i++)
            {
                game.Players[i].Hand.Cards.Clear();
            }

            // Create List of players for current deal order
            List<Player> currentPlayers = new List<Player>();

            // Create dealer object and new dealer index
            Player dealer = new Player();
            int dealerIndex = 0;

            // Get the dealer
            dealer = game.Players.Where(a => a.IsDealer == true).Single();

            // get the index number of the dealer
            if (dealer != null)
            {
                dealerIndex = game.Players.FindIndex(a => a.SeatNumber == dealer.SeatNumber);

                // Set the current turn for player after dealer
                int currentPlayerIndex = (dealerIndex + 1) % game.Players.Count;
                game.Players[currentPlayerIndex].CurrentTurn = true;

            }
            else
            {
                // no dealer set, return. Throw error at some point...
                return game;
            }

            // Add players from game into playerHands list starting with Dealer+1 (dealer should be last in list)
            // Skip if dealer is last in game list to prevent out of range
            if (dealerIndex != game.Players.Count)
            {
                // loop through each player after the dealer
                for (int i = (dealerIndex + 1); i < game.Players.Count; i++)
                {
                    // add player to players 
                    currentPlayers.Add(game.Players[i]);
                }
            }
            // Add remaining players
            for (int i = 0; i <= dealerIndex; i++)
            {
                // add player to player hands
                currentPlayers.Add(game.Players[i]);
            }

            //
            // homework build player list in single while loop with Mod
            //

            // Deal 11 cards to the players removing the cards from the deck
            for (int i = 0; i < 11; i++)
            {
                // loop through each player
                for (int j = 0; j < currentPlayers.Count; j++)
                {
                    // get first card in deck
                    Card card = game.GameDeck.Cards[0];
                    // add card to player hand
                    currentPlayers[j].Hand.Cards.Add(card);
                    // remove card from deck
                    game.GameDeck.Cards.Remove(card);
                }
            }

            // loop through each player in player hands
            foreach (Player player in currentPlayers)
            {
                // Copy player hands back into game object
                game.Players.Find(x => x.SeatNumber == player.SeatNumber).Hand = player.Hand;
            }

            // return the updated game
            return game;
        }


        // Set IsBuyer for all players to false
        public static Game ResetIsBuyer(Game game)
        {
            // Loop through all players
            for (int i = 0; i < game.Players.Count; i++)
            {
                // Set IsBuyer to false
                game.Players[i].IsBuyer = false;
            }

            // Return game
            return game;
        }

        public static Game ResetCurrentTurn(Game game)
        {
            // loop through players
            for (int i = 0; i < game.Players.Count; i++)
            {
                // set currentTurn false
                game.Players[i].CurrentTurn = false;
            }

            return game;
        }

        public static Game DrawCard(Game game, int player)
        {
            // Get top card
            Card card = game.GameDeck.Cards[0];

            // set playerIndex (index is 1 less then player number)
            int playerIndex = player - 1;

            // add card to player hand
            game.Players[playerIndex].Hand.Cards.Add(card);

            // remove card from game deck
            game.GameDeck.Cards.Remove(card);

            return game;
        }

        public static Game DrawDiscardCard(Game game, int player)
        {
            // Get top card of discard pile, should be last card added to list
            Card card = game.DiscardPile.Cards[(game.DiscardPile.Cards.Count - 1)];

            // set playerIndex (index is 1 less then player number)
            int playerIndex = player - 1;

            // add card to player hand
            game.Players[playerIndex].Hand.Cards.Add(card);

            // remove card from discard pile
            game.DiscardPile.Cards.Remove(card);

            return game;
        }

        public static Game BuyCard(Game game, int buyerIndex)
        {
            // Get last discarded card
            Card boughtCard = game.DiscardPile.Cards[(game.DiscardPile.Cards.Count - 1)];

            // Get top card
            Card extraCard = game.GameDeck.Cards[0];

            // add to player hand
            game.Players[buyerIndex].Hand.Cards.Add(boughtCard);
            game.Players[buyerIndex].Hand.Cards.Add(extraCard);

            // remove from discard pile
            game.DiscardPile.Cards.Remove(boughtCard);

            // remove from game deck
            game.GameDeck.Cards.Remove(extraCard);

            //return game
            return game;
        }


        public static Game DiscardCard(Game game, int player, Card card)
        {
            // add card to discard pile
            game.DiscardPile.Cards.Add(card);

            // set playerIndex (index is 1 less then player number)
            int playerIndex = player - 1;

            // remove card from player hand
            game.Players[playerIndex].Hand.Cards.Remove(card);

            return game;
        }

        public static Game MoveCardToTable(Game game, int player, Card card, int tableHandIndex)
        {
            // player index (1 less then player number)
            int playerIndex = player - 1;

            // remove card from player hand
            game.Players[playerIndex].Hand.Cards.Remove(card);

            // add card to table
            game.Players[playerIndex].TableHands[tableHandIndex].Cards.Add(card);

            return game;
        }

        public static Game MoveAllCardsBackToDeck(Game game)
        {
            // loop through players
            for (int i = 0; i < game.Players.Count; i++)
            {
                // check if player has cards
                if (game.Players[i].Hand.Cards.Count > 0)
                {
                    // loop through cards in player hand
                    foreach (Card card in game.Players[i].Hand.Cards)
                    {
                        game.GameDeck.Cards.Add(card);
                    }

                    // clear player hand
                    game.Players[i].Hand.Cards.Clear();
                }
            }

            // check if cards in discard pile
            if (game.DiscardPile.Cards.Count > 0)
            {
                // loop through cards in discard pile
                foreach (Card card in game.DiscardPile.Cards)
                {
                    game.GameDeck.Cards.Add(card);
                }

                // clear discard pile
                game.DiscardPile.Cards.Clear();
            }

            return game;
        }

        public static Game DetermineDealer(Game game)
        {
            // Clear Player cards, score, isdealer, and current turn
            for (int i = 0; i < game.Players.Count; i++)
            {
                game.Players[i].Hand.Cards.Clear();
                game.Players[i].Score = 0;
                game.Players[i].IsDealer = false;
                game.Players[i].CurrentTurn = false;
            }

            // Create card list of single suit and one joker to use to determine dealer (deck cant have duplicate cards)
            Deck deck = new Deck() { Cards = new List<Card>() };

            // Build a single suit of cards and add to list
            for (int i = 2; i < 15; i++)
            {
                Card card = new Card();
                card.Suit = "Spades";
                card.Name = CardService.GetName(i);
                card.ShortName = CardService.GetShortName(i) + card.Suit[0];
                card.Value = CardService.GetPointValue(i);
                card.DealValue = i;
                deck.Cards.Add(card);
            }

            // add Joker ro list
            Card joker = new Card();
            joker.Suit = "Wild";
            joker.Name = "Joker";
            joker.ShortName = "JW";
            joker.Value = 25;
            joker.DealValue = 15;
            deck.Cards.Add(joker);

            // Riffle and Overhand Shuffle Deck 7x
            for (int i = 0; i < 7; i++)
            {
                deck = DeckService.OverhandShuffleDeck(deck);
                deck = DeckService.RiffleShuffleDeck(deck);
            }

            // Deal each player a card from the top of the deck
            foreach (Player player in game.Players)
            {
                // get card
                Card card = deck.Cards[0];
                // add card to player hand
                player.Hand.Cards.Add(card);
                // remove card from list
                deck.Cards.Remove(card);
                // Set player score to cards deal value, used later to determine dealer
                player.Score = card.DealValue;
            }

            // get player with highest score
            Player dealer = game.Players.OrderByDescending(x => x.Score).First();
            if (dealer != null)
            {
                // set the isdealer true on player with highest score
                game.Players.Find(x => x.Score == dealer.Score).IsDealer = true;

                // clear player scores for game
                for (int i = 0; i < game.Players.Count; i++)
                {
                    game.Players[i].Score = 0;
                }

                // pretty sure this doesnt work, but for sanity check leaving to vefiry thru a debug before fixing
                foreach (Player player in game.Players)
                {
                    player.Score = 0;
                }
            }
            else
            {
                // throw error eventually
                return game;
            }

            return game;
        }

        public static Game AdvancedDealer(Game game)
        {
            // get list of player(s) flagged as dealer
            List<Player> dealers = game.Players.Where(x => x.IsDealer == true).ToList();

            // check that only 1 was returned
            if (dealers.Count == 1)
            {
                // get dealer
                Player dealer = dealers.FirstOrDefault();

                // get dealer index
                int dealerIndex = game.Players.FindIndex(a => a.SeatNumber == dealer.SeatNumber);

                // remove dealer from dealer
                game.Players[dealerIndex].IsDealer = false;

                int nextDealer = (dealerIndex + 1) % game.Players.Count;

                // make next player dealer
                game.Players[nextDealer].IsDealer = true;

            }
            else
            {
                // throw error
            }

            return game;
        }

        public static Game CalculateRoundScores(Game game)
        {
            // loop through players
            for (int i = 0; i < game.Players.Count; i++)
            {
                // loop through cards in player hand
                foreach (Card card in game.Players[i].Hand.Cards)
                {
                    // add card value to player score
                    game.Players[i].Score += card.Value;
                }
            }

            return game;
        }

        public static Game ZeroScores(Game game)
        {
            // loop through players
            foreach (Player player in game.Players)
            {
                player.Score = 0;
            }

            return game;
        }






        // Remove when done testing, only used for testing
        public static List<Player> CreateTestPlayers()
        {
            Player player1 = CreateTestPlayer(PlayerService.CreatePlayer("Player1", 1));
            player1.IsDealer = true;

            Player player2 = CreateTestPlayer(PlayerService.CreatePlayer("Player2", 2));
            Player player3 = CreateTestPlayer(PlayerService.CreatePlayer("Player3", 3));
            Player player4 = CreateTestPlayer(PlayerService.CreatePlayer("Player4", 4));
            Player player5 = CreateTestPlayer(PlayerService.CreatePlayer("Player5", 5));
            Player player6 = CreateTestPlayer(PlayerService.CreatePlayer("Player6", 6));
            Player player7 = CreateTestPlayer(PlayerService.CreatePlayer("Player7", 7));

            List<Player> players = new List<Player>
            {
                player1,
                player2,
                player3,
                player4,
                player5,
                player6,
                player7
            };

            return players;
        }

        private static Player CreateTestPlayer(Player player)
        { 
            player.Hand.Cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                player.TableHands[i].Cards = new List<Card>();
            }

            return player;
        }
    }
}
