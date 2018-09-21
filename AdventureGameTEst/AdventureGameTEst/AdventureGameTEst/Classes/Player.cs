using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureGameTEst.Classes;

namespace AdventureGameTEst.Classes
{

    public class Player
    {
        public int Rounds { get; set; }
        public string Name { get; set; }
        public List<Inventory> InventoryList { get; set; }

        public Player(string name, int rounds)
        {
            Rounds = rounds;
            Name = name;
            InventoryList = new List<Inventory>();
        }

    }

    

    //PickUpItem()

    //ShowInventory()

    //UseItem()

    //Move()



    //DropItem()

    //Look()
}
