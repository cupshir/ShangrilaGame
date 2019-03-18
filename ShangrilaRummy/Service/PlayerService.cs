﻿using System;
using System.Collections.Generic;
using ShangrilaRummy.Model;

namespace ShangrilaRummy.Service
{
    public class PlayerService
    {
        public PlayerService()
        {
        }

        public static Player CreatePlayer(string name, int seatNumber)
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
                Hand = new Hand(),
                TableHands = new List<Hand>()
            };

            for (int i = 0; i < 4; i++)
            {
                newPlayer.TableHands.Add(new Hand());
            }

            return newPlayer;
        }
    }
}
