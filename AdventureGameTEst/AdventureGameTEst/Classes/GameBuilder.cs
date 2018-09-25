using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureGameTEst.Classes;
using AdventureGameTEst.Extension_Methods;

namespace AdventureGameTEst.Classes
{
    class GameBuilder
    {
        public static List<Inventory> InventoryList = new List<Inventory>();
        public static List<Room> RoomList = new List<Room>();

        public Player Player { get; private set; }

        public void NameCharacter()
        {
            Console.Write("So what is your name? ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Welcome " + playerName + ", you have been wrongfully sentenced to death. " +
                              "Your execution is in 24 hours and you've been sent\n" + "to this maximum security prison in the meantime. " +
                              "Before your sentencing, you heard a rumor that there was a \n" + "secret door that lead to an escape hatch. " +
                              "Find the door and escape before your execution date!\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Player player = new Player(playerName, 24);

            Player = player;
        }

    }




    //CreateRooms()

    //CreateItems()
}
