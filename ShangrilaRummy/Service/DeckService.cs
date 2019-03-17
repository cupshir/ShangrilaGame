using System;
using System.Collections.Generic;
using GameCore.Model;

namespace GameCore
{
    public class DeckService
    {

        public static Deck BuildDecks(int numberToBuild)
        {
            // Build 1st deck
            Deck deck = BuildDeck();

            // Build multiple decks if required
            if (numberToBuild > 1)
            {
                for (int i = 1; i < numberToBuild; i++)
                {
                    Deck addDeck = BuildDeck();
                    deck.Cards.AddRange(addDeck.Cards);
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
            foreach (string suit in suits)
            {
                for (int i = 2; i < 15; i++)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Name = CardService.GetName(i);
                    card.ShortName = CardService.GetShortName(i) + suit[0];
                    card.Value = CardService.GetPointValue(i);
                    card.DealValue = i;

                    deck.Cards.Add(card);
                }
            }

            // Add 2 jokers
            for (int i = 0; i < 2; i++)
            {
                Card card = new Card();
                card.Suit = "Wild";
                card.Name = "Joker";
                card.ShortName = "JW";
                card.Value = 25;
                card.DealValue = 15;

                deck.Cards.Add(card);
            }

            return deck;
        }

        public static Deck RiffleShuffleDeck(Deck deck)
        {
            Random _rng = new Random();

            // Creat empty decks to split into
            Deck firstHalf = new Deck() { Cards = new List<Card>() };
            Deck secondHalf = new Deck() { Cards = new List<Card>() };

            // Copy cards into the two decks
            int count = 0;
            int random = _rng.Next(0, 1000);
            foreach (Card card in deck.Cards)
            {
                count++;
                // Use random number to mix up which deck gets first half of cards
                if (random > 500)
                {
                    if (count <= (deck.Cards.Count / 2))
                    {
                        firstHalf.Cards.Add(card);
                    }
                    else
                    {
                        secondHalf.Cards.Add(card);
                    }
                }
                else
                {
                    if (count <= (deck.Cards.Count / 2))
                    {
                        secondHalf.Cards.Add(card);
                    }
                    else
                    {
                        firstHalf.Cards.Add(card);
                    }
                }
            }

            // if copy was successful then clear cards from original deck
            if (deck.Cards.Count == (firstHalf.Cards.Count + secondHalf.Cards.Count))
            {
                deck.Cards.Clear();
            }
            else
            {
                Console.WriteLine("Deck did not split evenly");
                return deck;
            }

            // Recombine the two decks in random chunks (Simulate riffle shuffling)
            int totalCount = firstHalf.Cards.Count + secondHalf.Cards.Count;

            while (deck.Cards.Count != totalCount)
            {
                // Randomize Stack count for first half
                int stackCount = GetRandomStack();

                // Check that stack count is not greater than remaining cards in firstHalf
                // If it is greater, set stack count to remaining cards count
                if (stackCount > firstHalf.Cards.Count)
                {
                    stackCount = firstHalf.Cards.Count;
                }

                // Skip if stackCount = 0
                if (stackCount != 0)
                {
                    // Add stack from first half to deck
                    for (int i = 0; i < stackCount; i++)
                    {
                        Card card = firstHalf.Cards[0];
                        deck.Cards.Add(card);
                        firstHalf.Cards.Remove(card);
                    }
                }

                // Randomize Stack count for second half
                stackCount = GetRandomStack();

                // Check that stack count is not greater than remaining cards in secondHalf
                // If it is greater, set stack count to remaining cards count
                if (stackCount > secondHalf.Cards.Count)
                {
                    stackCount = secondHalf.Cards.Count;
                }

                // Skip if stackCount = 0
                if (stackCount != 0)
                {
                    // Add stack from second half to deck
                    for (int i = 0; i < stackCount; i++)
                    {
                        Card card = secondHalf.Cards[0];
                        deck.Cards.Add(card);
                        secondHalf.Cards.Remove(card);
                    }
                }
            }

            return deck;
        }

        public static Deck OverhandShuffleDeck(Deck deck)
        {
            Deck tempDeck = new Deck() { Cards = new List<Card>() };

            Random _rng = new Random();

            int numberOfShuffles = _rng.Next(2, 5);

            for (int j = 0; j < numberOfShuffles; j++)
            {
                tempDeck.Cards.Clear();

                // Get Stack size to shuffle
                int stackNumber = _rng.Next(((deck.Cards.Count / 4) / 3), (deck.Cards.Count / 4));

                // Get starting point in deck
                int startingPoint = _rng.Next(0, deck.Cards.Count);

                // Move cards from deck to temp deck, from starting point
                if ((startingPoint + stackNumber) < deck.Cards.Count)
                {
                    for (int i = startingPoint; i < (startingPoint + stackNumber); i++)
                    {
                        Card card = deck.Cards[startingPoint];
                        tempDeck.Cards.Add(card);
                        deck.Cards.Remove(card);
                    }
                }
                else
                {
                    for (int i = startingPoint; i < deck.Cards.Count; i++)
                    {
                        Card card = deck.Cards[startingPoint];
                        tempDeck.Cards.Add(card);
                        deck.Cards.Remove(card);
                    }
                }

                // Move stack to top of deck
                tempDeck.Cards.AddRange(deck.Cards);
                deck.Cards.Clear();
                deck.Cards.AddRange(tempDeck.Cards);
            }
            return deck;
        }

        private static int GetRandomStack()
        {
            Random _rng = new Random();

            int stackNumber;

            int roll = _rng.Next(0, 75);
            if (roll > 50 && roll < 76)
            {
                stackNumber = 3;
            }
            else if (roll > 25 && roll < 51)
            {
                stackNumber = 2;
            }
            else
            {
                stackNumber = 1;
            }

            return stackNumber;
        }
    }
}

