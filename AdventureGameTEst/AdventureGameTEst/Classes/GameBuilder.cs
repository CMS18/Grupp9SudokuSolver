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
        List<Inventory> inventoryList = new List<Inventory>();
        List<Room> roomList = new List<Room>();
        List<Inventory> roomInventory = new List<Inventory>();
        List<Inventory> playerInventory = new List<Inventory>();
        List<Exit> exits = new List<Exit>();

        Inventory bucket;
        //Inventory bigPlant;
        Inventory smallPlant;
        Inventory copperKey;
        Inventory broomStick;
        //Inventory painting;

        Room currentRoom;

        private bool gameIsRunning = true;

        Player player;

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
            Player player = new Player(playerName);
            
        }

        public void StartupItems()
        {

            bucket = new Inventory("0", "Bucket", "You found a bucket.It reeks but maybe there's a use for it?", false);
            bucket.AddDescriptionToRoom = "In the corner of the room, you see a bucket.";
            //painting = new Inventory("1", "Painting", "A painting of my great idol, Adobe Gitler", false);
            //bigPlant = new Inventory("2", "Big Plant", "This plant is almost as big as me. It sits in a white flower pot. How does it grow so much when there's no sunlight here?", false);
            smallPlant = new Inventory("3", "Small Plant", "This plant is about a foot tall, but it has spiky vines. Seems pretty fitting for a prison.", true);
            smallPlant.AddDescriptionToRoom = "There is a small plant.";
            copperKey = new Inventory("4", "Copper Key", "A copper key. I wonder where it goes.", true);
            copperKey.AddDescriptionToRoom = "There is a key";
            broomStick = new Inventory ("5", "Broomstick", "You found a broomstick, might it be useful?", true);
            broomStick.AddDescriptionToRoom = "There is a broomstick leaning to the wall.";
            broomStick.MatchID = smallPlant.Id;
            smallPlant.MatchID = broomStick.Id;

            
        }

        public void StartupRooms()
        {
            //Rum 0, exits: E och W, items: bucket.
            Room entrance = new Room();
            entrance.AddName("Entrance");
            entrance.AddDescription("This is the prison entrance. The walls are made of indestructible concrete but they are fairly clean. " +
            "There are two possible exits - one to the east and one to the west. Press E or W if you want to move east or west.");
            entrance.AddItem(bucket);
            entrance.AddItem(broomStick);

            //Rum 2, inga items. Exits: N och E
            Room southWestRoom = new Room();
            southWestRoom.AddName("South West Room");
            southWestRoom.AddDescription("You are in the southwest room. It's rather stuffy in this room. I wonder why? Maybe " +
            "due to a lack of windows in the prison? I guess there's a reason for not having windows " +
            "in a prison, though. The walls are dirty, except for the western wall, which seems " +
            "surprisingly clean? You can exit the room to the east or to the north. Press N or E " +
            "to proceed.");

            //Rum 3, Items: Big plant, kan ej tas med och Small plant, key Exits: N och S.
            Room eastRoom = new Room();
            eastRoom.AddName("East room");
            eastRoom.AddDescription("You are in the eastern room. There's d e f i n i t e l y blood on the eastern wall... that's " +
            "disturbing as hell. There is a plant in the corner of the room, which is weird when " +
            "you consider how bland and dark the rest of the prison is. You can exit the room to the " +
            "north or to the south. Press N or S to proceed.");
            //eastRoom.AddItem(bigPlant);
            eastRoom.AddItem(smallPlant);
            eastRoom.AddItem(copperKey);

            // Rum 8, Vinnande rummet! 
            Room secretRoom = new Room();
            secretRoom.AddName("Secret Room");
            secretRoom.AddDescription("You have found the secret room! And the rumors were true, there's a hatch, " +
            "alright! Let's climb through and escape this godforsaken prison! It leads to a tunnel. " +
            "Why are there skeletons spread around this tunnel? And what's up with these nasty spiders? " +
            "Oh well, let's press on, to freedom!");
            
            //LÄGG TILL EXITS I ROOM
            southWestRoom.AddExit(new Exit(entrance, "East"));
            eastRoom.AddExit(new Exit(entrance, "West"));
            entrance.AddExit(new Exit(southWestRoom, "West"));
            entrance.AddExit(new Exit(eastRoom, "East"));
            southWestRoom.AddExit(new Exit(secretRoom, "North", true, "Door", "Here´s a door."));

            currentRoom = entrance;
            
        }

        public void GamePlay()
        {
            do
            {
                CurrentRoom();
                Console.Write("");
                string input = Console.ReadLine().ToUpper();
                string[] inputArray = input.Split(' ');
                
                if (inputArray[0] == "LOOK")
                {
                    Console.WriteLine(currentRoom.Description);
                    continue;
                }
                if (inputArray[0] == "GET" || inputArray[0] == "TAKE" || inputArray[0] == "PICK")
                {
                    if (inputArray[1] == "UP")
                    {
                        Get(inputArray.Skip(2).ToArray());
                        continue;
                    }
                    Get(inputArray.Skip(1).ToArray());
                }
                else if (inputArray[0] == "INVENTORY" || inputArray[0] == "I")
                {
                    player.ShowInventory();
                }
                else if (inputArray[0] == "DROP")
                {
                    Drop(inputArray.Skip(1).ToArray());
                }
                else if (inputArray[0] == "GO")
                {
                    Go(inputArray.Skip(1).ToArray());
                }
                else if (inputArray[0] == "NORTH" || inputArray[0] == "EAST" || inputArray[0] == "SOUTH" || inputArray[0] == "WEST")
                {
                    Go(inputArray);
                }
                else if (inputArray[0] == "INSPECT")
                {
                    Inspect(inputArray.Skip(1).ToArray());
                }
                else if (inputArray[0] == "USE")
                {
                    Use(inputArray.Skip(1).ToArray());
                }
                
                else
                {
                    Console.WriteLine("Wat?");
                    continue;
                }

            } while (gameIsRunning);

        }

        private void Use(string[] input)
        {
            playerInventory = player.GetInventory();
            exits = currentRoom.GetExits();
            foreach (Inventory item in playerInventory)
            {
                if (input.Contains(item.Name.ToUpper()))
                {
                    if (item.IsUsable())
                    { 
                        Console.WriteLine($"Use {input} what? ");
                        input = Console.ReadLine().ToUpper().Split(' ');
                    }
                }
            }
            
        }

        private void Inspect(string[] v)
        {
            throw new NotImplementedException();
        }

        private void Go(string[] v)
        {
            throw new NotImplementedException();
        }

        private void Drop(string[] input)
        {
            if (input.Length < 1)
            {
                Console.WriteLine("Drop what? ");
                input = Console.ReadLine().ToUpper().Split(' ').ToArray();
            }
            playerInventory = player.GetInventory();

            foreach (Inventory item in playerInventory)
            {
                if (item.Name == input[0])
                {
                    player.RemoveItem(item);
                    currentRoom.AddItem(item);
                    Console.WriteLine($"Dropped {item} into room.");
                    return;
                }
            }
            Console.WriteLine("Item does not exist in your inventory. ");
            
        }

        private void Get(string[] input)
        {
            roomInventory = currentRoom.GetInventory();
            if (input.Length < 1)
            {
                Console.WriteLine("Get what? ");
                input = Console.ReadLine().ToUpper().Split(' ');
            }

            foreach (Inventory item in roomInventory)
            {
                if (input.Contains(item.Name))
                {
                    Console.WriteLine("Taken.");
                    currentRoom.RemoveItem(item);
                    player.AddItem(item);

                    return;
                }
            }
            Console.WriteLine("Wat?");
        }

        public void CurrentRoom()
        {
            Console.WriteLine(currentRoom.Name);
            Console.WriteLine(currentRoom.Description);
        }
    }




    //CreateRooms()

    //CreateItems()
}
