using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureGameTEst.Classes;

namespace AdventureGameTEst.Classes
{
    public class Game : Base
    {
        public Player Player { get; set; }

        public List<Rooms> RoomList { get; set; }

        public bool Alive { get; set; }

        public bool Victory { get; set; }

        public Game()
        {
            GameBuilder gameBuilder = new GameBuilder();
            gameBuilder.NameCharacter();
            Player = gameBuilder.Player;
        }

    }





    //NewGame()
    //PlayingGame()
    //PlayerParse()
}
