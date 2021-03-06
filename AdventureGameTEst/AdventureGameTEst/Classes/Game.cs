﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureGameTEst.Classes;

namespace AdventureGameTEst.Classes
{
    public class Game
    {
        Player player;

        public List<Room> RoomList { get; set; }

        public bool Alive { get; set; }

        public bool Victory { get; set; }

        public Game()
        {
            Game.Start();
            GameBuilder gameBuilder = new GameBuilder();
            gameBuilder.NameCharacter();
            //player = gameBuilder.Player;
            gameBuilder.StartupItems();
            gameBuilder.StartupRooms();
            gameBuilder.GamePlay();
        }

        public static void Start()
        {
            Console.WriteLine("Welcome to the Haglund Prison Escape!");  
        }

        

    }





    //NewGame()
    //PlayingGame()
    //PlayerParse()
}
