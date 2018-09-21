using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureGameTEst.Classes;

namespace AdventureGameTEst.Classes
{

    class Player
    {
        public int Rounds { get; set; }

        //public List<Inventory> InventoryList { get; set; }
        
        public static void NameCharacter()
        { 
        Console.Write("So what is your name? ");
        string playerName = Console.ReadLine();
        Console.WriteLine("Welcome " + playerName + " You will explore the dungeons of Kallhäll, do your best to escape or you will face death!");
        Console.Read();
        }

        
    }



    //PickUpItem()

    //ShowInventory()

    //UseItem()

    //Move()



    //DropItem()

    //Look()
}
