using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using AdventureGameTEst.Classes;

namespace AdventureGameTEst.Classes
{

    public class Player
    {
        
        public string Name { get; set; }

        List<Inventory> inventoryList = new List<Inventory>();

        public void ShowInventory()
        {
            if (inventoryList.Count > 0)
            {
                Console.WriteLine($"You have: ");
                foreach (Inventory item in inventoryList)
                {
                    Console.WriteLine(item.Name);
                }

            }
            else
            {
                Console.WriteLine("Nothing in your inventory. ");
            }
        }

        public void AddItem(Inventory item)
        {
            inventoryList.Add(item);
        }

        public void RemoveItem(Inventory item)
        {
            inventoryList.Remove(item);
        }

        public List<Inventory> GetInventory()
        {
            return inventoryList;
        }
    }

    

    //PickUpItem()

    //ShowInventory()

    //UseItem()

    //Move()



    //DropItem()

    //Look()
}
