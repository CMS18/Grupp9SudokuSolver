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

        public static void StartupItems()
        {
            Inventory bucket = new Inventory(0, "Bucket", "You found a bucket.It reeks but maybe there's a use for it?", true, false);
            bucket.AddDescriptionToRoom = "In the corner of the room, you see a bucket.";
            Inventory painting = new Inventory(1, "Painting", "A painting of my great idol, Adobe Gitler", false, false);
            Inventory bigPlant = new Inventory(2, "Big Plant", "This plant is almost as big as me. It sits in a white flower pot. How does it grow so much when there's no sunlight here?", false, false);
            Inventory smallPlant = new Inventory(3, "Small Plant", "This plant is about a foot tall, but it has spiky vines. Seems pretty fitting for a prison.", false, false);
            Inventory copperKey = new Inventory(4, "Copper Key", "A copper key. I wonder where it goes.", true, true);
            Inventory couch = new Inventory(5, "Couch", "The couch sits 6 people. It's beside the wall and you can see that someone has forgotten to paint the wall behind it.", false, false);
            Inventory table = new Inventory(6, "Table", "An ordinary wood table, can seat four people.", false, false);
            Inventory chairs = new Inventory(7, "Chairs", "Normal wood chairs. Could possibly be used to climb somewhere.", true, false);
            Inventory teeth = new Inventory(8, "Teeth", "Sharp, yellow teeth.", true, false);
            Inventory tapestry = new Inventory(9, "Tapestry", "It shows some kind of tunnel, with many small spiders and one big spider descending on a man.", false, false);
            Inventory rug = new Inventory(10, "Rug", "A dirty rug with blood stains all over it.", false, false);
            Inventory bookShelf = new Inventory(11, "Book Shelf", "A heavy book shelf with lots of books in it. Obviously, most of them are covered in books except for Harry Potter and 50 Shades of Grey.", false, false);
            Inventory harryPotterBook = new Inventory(12, "Harry Potter Book", "Harry Potter and The Prisoner of Azkaban. It has been read a LOT.", true, false);
            Inventory fiftyShadesBook = new Inventory(13, "50 Shades of Grey Book", "Wow, this book is falling apart! Must be really popular.", true, false);
            Inventory benchPress = new Inventory(14, "Bench Press", "A normal bench press.", false, false);
            Inventory kettlebells = new Inventory(15, "Kettlebells", "40 pound kettlebells. A swing to the head could kill a man!", true, false);
            Inventory oldRug = new Inventory(16, "Old Rug", "A really old rug.", false, false);
            Inventory ironKey = new Inventory(17, "Iron Key", "An iron key. I wonder where it goes.", true, true);
        }

        public static void StartupRooms()
        {
            Room entrance = new Room(0, "This is the prison entrance. The walls are made of indestructible concrete but they are fairly clean. " +
        "There are two possible exits - one to the east and one to the west. Press E or W if you want to move east or west.", false);

            Room southEastRoom = new Room(1, "You are in the southeast room now. The walls are slightly dirtier... you think " +
             "you can see some blood on one of the walls. Surprisingly, there's also a painting hanging " +
             "suspiciously on the wall. You can exit the room to the west or to the north. Press N or W to proceed.", false);

            Room southWestRoom = new Room(2, "You are in the southwest room.It's rather stuffy in this room. I wonder why? Maybe " +
            "due to a lack of windows in the prison? I guess there's a reason for not having windows " +
            "in a prison, though. The walls are dirty, except for the western wall, which seems " +
            "surprisingly clean? You can exit the room to the east or to the north. Press N or E " +
            "to proceed.", false);

            Room eastRoom = new Room(3, "You are in the eastern room. There's d e f i n i t e l y blood on the eastern wall... that's " +
            "disturbing as hell. There are two plants in the corners of the room, which is weird when " +
            "you consider how bland and dark the rest of the prison is. You can exit the room to the " +
            "north or to the south. Press N or S to proceed.", false);

            Room westRoom = new Room(4, "You are in the western room. This room is slightly less stuffy. Strange? The walls are painted " +
            "red. Maybe they are trying to cover up some kind of fight that happened? It seems like " +
            "they have forgotten to paint the part behind the couch on the northern side of the room. " +
            "You can exit the room to the north or to the south. Press N or S to proceed.", false);

            Room northEastRoom = new Room(5, "You are in the northeastern room. There's a table and a few chairs in the middle of the room. " +
            "The walls are really bloody here... the prison guards haven't even bothered to wash the blood " +
            "off. You're pretty sure that there's teeth on the ground as well. You can exit the room to the " +
            "west or to the south. Press W or S to proceed.", false);

            Room northRoom = new Room(6, "This room is surprisingly clean, considering the state of the adjacent rooms. There's " +
            "tapestry on the southern wall. It's slightly torn but what the hell is tapestry doing in " +
            "a high-security prison? There's also a rug on the floor and a book shelf with plenty of " +
            "books. You can exit the room to the west or to the east. Press W or E to proceed.", false);

            Room northWestRoom = new Room(7, "Another room with bloody walls. What the hell are the prison guards doing " +
            ", do they want the prisoners to kill each other? I would have said yes, but " +
            "the prison gets paid for each prisoner so maybe not. Seems like this room is meant " +
            "to be a gym, but there's only a bench press and some bloody kettle bells. There's a rug " +
            "under the bench press for some reason? You can exit the room to the south or to the east. " +
            "Press S or E to proceed.", false);

            Room secretRoom = new Room(8, "You have found the secret room! And the rumors were true, there's a hatch, " +
            "alright! Let's climb through and escape this godforsaken prison! It leads to a tunnel. " +
            "Why are there skeletons spread around this tunnel? And what's up with these nasty spiders? " +
            "Oh well, let's press on, to freedom!", true);
        }

    }




    //CreateRooms()

    //CreateItems()
}
