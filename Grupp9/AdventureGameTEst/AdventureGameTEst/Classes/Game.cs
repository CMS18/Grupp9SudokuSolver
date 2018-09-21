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
        public Player player { get; set; }

        public List<Rooms> RoomList { get; set; }

        public bool alive { get; set; }

        public bool victory { get; set; }

        public Game()
        {
            GameBuilder gameBuilder = new GameBuilder();
            player = gameBuilder.Player;
        }

    }





    //NewGame()
    //PlayingGame()
    //PlayerParse()
}
