using System;
using ShangrilaRummy.Model;

namespace ShangrilaRummy.Service
{
    public class HandService
    {
        public HandService()
        {
        }

        public static Game MoveCardInHand(Game game, int player, int card1, int card2)
        {
            // player index (1 less then player number)
            int playerIndex = player - 1;

            // Get Card to move
            Card moveCard = game.Players[playerIndex].Hand.Cards[(card1 - 1)];

            // remove card from player hand
            game.Players[playerIndex].Hand.Cards.Remove(moveCard);

            // insert card back into hand at old card index
            game.Players[playerIndex].Hand.Cards.Insert((card2 - 1), moveCard);

            return game;
        }
    }
}
