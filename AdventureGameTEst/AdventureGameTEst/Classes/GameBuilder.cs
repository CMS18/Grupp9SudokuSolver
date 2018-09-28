using System;
using System.Collections.Generic;
using System.Linq;

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
        Inventory plant;
        Inventory key;
        Inventory shovel;
        Inventory painting;

        Room currentRoom;
        

        private bool gameIsRunning = true;

        Player player;

        public void NameCharacter()
        {
            player = new Player();
            Console.Write("So what is your name? ");
            player.Name = Console.ReadLine();
            Console.WriteLine("Welcome " + player.Name + ". You have been wrongfully sentenced to death. " +
                              "Your execution is in 24 hours and you've been sent\n" + "to this maximum security prison in the meantime. " +
                              "Before your sentencing, you heard a rumor that there was a \n" + "secret door that lead to an escape hatch. " +
                              "Find the door and escape before your execution date!\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            
        }

        public void StartupItems()
        {

            bucket = new Inventory("0", "BUCKET", "You found a bucket. It reeks but maybe there's a use for it?", false);
            bucket.AddDescriptionToRoom = "In the corner of the room, you see a bucket.";
            painting = new Inventory("1", "PAINTING", "A painting of Haglund's great idol, Adobe Gitler", false);
            painting.AddDescriptionToRoom = "A perfectly centered painting hangs on the western wall.";
            //bigPlant = new Inventory("2", "Big Plant", "This plant is almost as big as me. It sits in a white flower pot. How does it grow so much when there's no sunlight here?", false);
            plant = new Inventory("3", "PLANT", "This plant is about a foot tall, but it has spiky vines. Seems pretty fitting for a prison.", true);
            plant.AddDescriptionToRoom = "There is a small plant.";
            key = new Inventory("id1", "KEY", "A copper key. I wonder where it goes.", true);
            key.AddDescriptionToRoom = "There is a key.";
            shovel = new Inventory ("5", "SHOVEL", "You found a shovel, might it be useful?", true);
            shovel.AddDescriptionToRoom = "There is a shovel leaning to the wall.";

            shovel.MatchID = plant.Id;
            plant.MatchID = shovel.Id;

            
        }

        public void StartupRooms()
        {
            //Rum 0, exits: E och W, items: bucket.
            Room entrance = new Room();
            entrance.AddName("Entrance");
            entrance.AddDescription("This is the prison entrance. The walls are made of indestructible concrete but they are fairly clean. " +
            "\nThere are two possible exits - one to the east and one to the west. Type east or west if you want to move east or west.");
            entrance.AddItem(bucket);
            entrance.AddItem(shovel);
            roomList.Add(entrance);


            //Rum 2, inga items. Exits: N och E
            Room southWestRoom = new Room();
            southWestRoom.AddName("South West Room");
            southWestRoom.AddDescription("You are in the southwest room. It's rather stuffy in this room. I wonder why? \n Maybe " +
            "due to a lack of windows in the prison? \n I guess there's a reason for not having windows " +
            "in a prison, though. The walls are dirty, except for the western wall...? " +
            "You can exit the room to the east or to the north. Type north or east. " +
            "to proceed.");
            southWestRoom.AddItem(painting);
            roomList.Add(southWestRoom);

            //Rum 3, Items: Big plant, kan ej tas med och Small plant, key Exits: N och S.
            Room eastRoom = new Room();
            eastRoom.AddName("East room");
            eastRoom.AddDescription("You are in the eastern room. There's d e f i n i t e l y blood on the eastern wall... that's " +
            "disturbing as hell. \nThere is a plant in the corner of the room, which is weird when " +
            "you consider how bland and dark the rest of the \nprison is. You can exit the room to the " +
            "west. Type west to proceed.");
            //eastRoom.AddItem(bigPlant);
            eastRoom.AddItem(plant);
            //eastRoom.AddItem(key);
            roomList.Add(eastRoom);

            // Rum 8, Vinnande rummet! 
            Room secretRoom = new Room();
            secretRoom.AddName("Secret Room");
            secretRoom.AddDescription("You have found the secret room! And the rumors were true, there's a hatch, " +
            "alright! Let's climb through and escape this godforsaken prison! It leads to a tunnel. " +
            "\nWhy are there skeletons spread around this tunnel? And what's up with these nasty spiders? " +
            "Oh well, let's press on, to freedom!");
            roomList.Add(secretRoom);
            
            //LÄGG TILL EXITS I ROOM
            southWestRoom.AddExit(new Exit(entrance, "East"));
            eastRoom.AddExit(new Exit(entrance, "West"));
            entrance.AddExit(new Exit(southWestRoom, "West"));
            entrance.AddExit(new Exit(eastRoom, "East"));
            southWestRoom.AddExit(new Exit(secretRoom, "North", true, "The Door is locked", "id1", "Door", "Here´s a door. It seems to be locked."));

            currentRoom = entrance;
            
        }

        public void GamePlay()
        {
            CurrentRoom();
            do
            {
                Console.Write("");
                string input = Console.ReadLine().ToUpper();
                string[] inputArray = input.Split(' ');

                if (inputArray[0] == "LOOK")
                {
                    Console.WriteLine(currentRoom.GetDescription());
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
                else if (inputArray[0] == "CLEAR")
                {
                    Console.Clear();
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
                        if (input.Length < 3)
                        {
                            Console.WriteLine("Use on what? ");
                            input = Console.ReadLine().ToUpper().Split(' ');
                        }
                        else
                        {
                            input = input.Skip(1).ToArray();
                        }

                        foreach (Exit exit in exits)
                        {
                            if (input.Contains(exit.GetLockType().ToUpper()))
                            {
                                if (exit.GetId() == item.GetId())
                                {
                                    exit.Unlock();
                                    Console.WriteLine("You have unlocked the door!");
                                    player.RemoveItem(item);
                                    return;
                                }
                            }
                        }

                        foreach (Inventory inventoryItem in playerInventory)
                        {
                            if (input.Contains(inventoryItem.Name))
                            {
                                if (inventoryItem.GetMatchId() == item.GetMatchId())
                                {
                                    player.RemoveItem(item);
                                    player.RemoveItem((inventoryItem));
                                    player.AddItem(key);
                                    Console.WriteLine("Wow, you found a copper key!");
                                    return;
                                }
                            }
                        }
                    }

                    else
                        {
                            Console.WriteLine("Can't use that");
                        }
                    }
                }
            }
            
        

        private void Inspect(string[] input)
        {
            playerInventory = player.GetInventory();
            exits = currentRoom.GetExits();
            if (input.Length < 1)
            {
                Console.WriteLine("What do you want to inspect?");
                Console.Write("");
                input = Console.ReadLine().ToUpper().Split(' ');
            }

            foreach (Inventory inventory in playerInventory)
            {
                if (input.Contains(inventory.Name.ToUpper()))
                {
                    Console.WriteLine(inventory.Description);
                    return; 
                }
            }

            foreach (Exit exit in exits)
            {
                if (exit.GetLockType().ToUpper() == input[0])
                {
                    Console.WriteLine(exit.GetLockDescription());
                    return;
                }
            }

            Console.WriteLine("Can't do that, you dumbo.");
        }

        private void Go(string[] input)
        {
            exits = currentRoom.GetExits();
            foreach (Exit exit in exits)
            {
                if (exit.GetDirection().ToUpper() == input[0])
                {
                    if (!exit.IsLocked())
                    {
                        currentRoom = exit.LeadsTo();
                        CurrentRoom();
                        return;
                    }
                    else if (exit.IsLocked())
                    {
                        Console.WriteLine(exit.GetLockDescription());
                        return;
                    }
                }
            }
            Console.WriteLine("Can't go that way, you idiot.");
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
                    Console.WriteLine($"Dropped {item.Name.ToLower()} into room.");
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
            //Console.WriteLine(currentRoom.Description);
            Console.WriteLine(currentRoom.GetDescription());



            if (currentRoom.Name == "Secret Room")
            {
                gameIsRunning = false;
            }
           
           
            
        }
    }




    //CreateRooms()

    //CreateItems()
}
