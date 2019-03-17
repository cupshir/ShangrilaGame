using System;
using GameCore.Model;
using GameCore.Service;

namespace GameCore
{
    public class GamePlay
    {
        public GamePlay()
        {
            // Create player list

            // Setup new game
            Game game = GameService.CreateGame( GameService.CreateTestPlayers(), 3 );


            // Determine Dealer
            game = GameService.DetermineDealer(game);



            //

            //





        }
    }
}
