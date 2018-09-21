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
        Console.WriteLine("Welcome " + playerName + "Welcome " + playerName + " you have been wrongfully sentenced to death. " +
                          "Your execution is in 24 hours and you've been sent to this maximum security prison in the meantime. " +
                          "Before your sentencing, you heard a rumor that there was a secret door that lead to an escape hatch. " +
                          "Find the door and escape before your execution date!");
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
