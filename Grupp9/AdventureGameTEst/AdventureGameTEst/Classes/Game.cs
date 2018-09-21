using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameTEst.Classes
{
    class Game
    {
        public Player player { get; set; }

        public List<Rooms> RoomList { get; set; }

        public bool alive { get; set; }

        public bool victory { get; set; }
    }

    //NewGame()
    //PlayingGame()
    //PlayerParse()
}
