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
        public static List<Inventory> inventoryList = new List<Inventory>();
        public static List<Room> roomList = new List<Room>();
        public static List<Inventory> roomInventory = new List<Inventory>();
        Inventory bucket;
        Inventory bigPlant;
        Inventory smallPlant;
        Inventory copperKey;

        Room currentRoom;

        private bool gameIsRunning = true;

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

        public void StartupItems()
        {
            Inventory bucket = new Inventory(0, "Bucket", "You found a bucket.It reeks but maybe there's a use for it?", true, false);
            bucket.AddDescriptionToRoom = "In the corner of the room, you see a bucket.";
            Inventory painting = new Inventory(1, "Painting", "A painting of my great idol, Adobe Gitler", false, false);
            Inventory bigPlant = new Inventory(2, "Big Plant", "This plant is almost as big as me. It sits in a white flower pot. How does it grow so much when there's no sunlight here?", false, false);Inventory smallPlant = new Inventory(3, "Small Plant", "This plant is about a foot tall, but it has spiky vines. Seems pretty fitting for a prison.", false, false);
            smallPlant.AddDescriptionToRoom = "There is a small plant.";
            Inventory copperKey = new Inventory(4, "Copper Key", "A copper key. I wonder where it goes.", true, true);
            copperKey.AddDescriptionToRoom = "There is a key";

            //Inventory couch = new Inventory(5, "Couch", "The couch sits 6 people. It's beside the wall and you can see that someone has forgotten to paint the wall behind it.", false, false);
            //Inventory table = new Inventory(6, "Table", "An ordinary wood table, can seat four people.", false, false);
            //Inventory chairs = new Inventory(7, "Chairs", "Normal wood chairs. Could possibly be used to climb somewhere.", true, false);
            //chairs.AddDescriptionToRoom = "There are a few chairs here.";
            //Inventory teeth = new Inventory(8, "Teeth", "Sharp, yellow teeth.", true, false);
            //teeth.AddDescriptionToRoom = "You're pretty sure that there's teeth on the ground.";
            //Inventory tapestry = new Inventory(9, "Tapestry", "It shows some kind of tunnel, with many small spiders and one big spider descending on a man.", false, false);
            //Inventory rug = new Inventory(10, "Rug", "A dirty rug with blood stains all over it.", false, false);
            //Inventory bookShelf = new Inventory(11, "Book Shelf", "A heavy book shelf with lots of books in it. Obviously, most of them are covered in books except for Harry Potter and 50 Shades of Grey.", false, false);
            //Inventory harryPotterBook = new Inventory(12, "Harry Potter Book", "Harry Potter and The Prisoner of Azkaban. It has been read a LOT.", true, false);
            //harryPotterBook.AddDescriptionToRoom = "You can see a Harry Potter book.";
            //Inventory fiftyShadesBook = new Inventory(13, "50 Shades of Grey Book", "Wow, this book is falling apart! Must be really popular.", true, false);
            //fiftyShadesBook.AddDescriptionToRoom = "There is a book with the title \"Fifty shades of grey\"";
            //Inventory benchPress = new Inventory(14, "Bench Press", "A normal bench press.", false, false);
            //Inventory kettlebells = new Inventory(15, "Kettlebells", "40 pound kettlebells. A swing to the head could kill a man!", true, false);
            //kettlebells.AddDescriptionToRoom = "Bloody kettle bells are lying on the floor.";
            //Inventory oldRug = new Inventory(16, "Old Rug", "A really old rug.", false, false);
            //Inventory ironKey = new Inventory(17, "Iron Key", "An iron key. I wonder where it goes.", true, true);
            //ironKey.AddDescriptionToRoom = "There is a key.";
        }

        public void StartupRooms()
        {
            //Rum 0, exits: E och W, items: bucket.
            Room entrance = new Room();
            entrance.AddName("Entrance");
            entrance.AddDescription("This is the prison entrance. The walls are made of indestructible concrete but they are fairly clean. " +
            "There are two possible exits - one to the east and one to the west. Press E or W if you want to move east or west.");
            entrance.AddItem(bucket);            

            //Rum 1, painting, kan ej tas med. Exits: N och W.
            //Room southEastRoom = new Room(1, "You are in the southeast room now. The walls are slightly dirtier... you think " +
            // "you can see some blood on one of the walls. Surprisingly, there's also a painting hanging " +
            // "suspiciously on the wall. You can exit the room to the west or to the north. Press N or W to proceed.", false);

            //Rum 2, inga items. Exits: N och E
            Room southWestRoom = new Room();
            southWestRoom.AddName("South West Room");
            southWestRoom.AddDescription("You are in the southwest room.It's rather stuffy in this room. I wonder why? Maybe " +
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
            eastRoom.AddItem(bigPlant);
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

            //// Rum 4, Items: Couch, kan ej tas med. Exits: N och S
            //Room westRoom = new Room(4, "You are in the western room. This room is slightly less stuffy. Strange? The walls are painted " +
            //"red. Maybe they are trying to cover up some kind of fight that happened? It seems like " +
            //"they have forgotten to paint the part behind the couch on the northern side of the room. " +
            //"You can exit the room to the north or to the south. Press N or S to proceed.", false);

            // Rum 5, Items: Teeths, chair. Table (kan ej tas med). Exits: W och S.
            //Room northEastRoom = new Room(5, "You are in the northeastern room. There's a table in the middle of the room. " +
            //"The walls are really bloody here... the prison guards haven't even bothered to wash the blood " +
            //"off. You can exit the room to the " +
            //"west or to the south. Press W or S to proceed.", false);

            // Rum 6, Items: 2 böcker. Tapestry, rug och bookshelf som inte kan tas med. Exits: W och E.
            //Room northRoom = new Room(6, "This room is surprisingly clean, considering the state of the adjacent rooms. There's " +
            //"tapestry on the southern wall. It's slightly torn but what the hell is tapestry doing in " +
            //"a high-security prison? There's also a rug on the floor and a book shelf with plenty of " +
            //"books. You can exit the room to the west or to the east. Press W or E to proceed.", false);

            //Rum 7, Items: Nyckel och kettlebells. Bench press och rug som inte kans tas med. Exits: S och E.
            //Room northWestRoom = new Room(7, "Another room with bloody walls. What the hell are the prison guards doing " +
            //", do they want the prisoners to kill each other? I would have said yes, but " +
            //"the prison gets paid for each prisoner so maybe not. Seems like this room is meant " +
            //"to be a gym, but there's only a bench press and some other stuff. There's a rug " +
            //"under the bench press for some reason? You can exit the room to the south or to the east. " +
            //"Press S or E to proceed.", false);
            
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
                    Player.ShowInventory();
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
                else if (inputArray[0] == "H")
                {
                    ShowHelp();
                }
                else
                {
                    Console.WriteLine("What?");
                    continue;
                }

            } while (gameIsRunning);

        }

        private void ShowHelp()
        {
            throw new NotImplementedException();
        }

        private void Use(string[] v)
        {
            throw new NotImplementedException();
        }

        private void Inspect(string[] v)
        {
            throw new NotImplementedException();
        }

        private void Go(string[] v)
        {
            throw new NotImplementedException();
        }

        private void Drop(string[] v)
        {
            throw new NotImplementedException();
        }

        private void Get(string[] input)
        {
            roomInventory = currentRoom.GetInventory();
            if (input.Length < 1)
            {
                Console.WriteLine("???");
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
            Console.WriteLine("What?");
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
