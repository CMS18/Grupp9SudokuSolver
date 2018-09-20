using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameTEst.Classes
{
    class Rooms
    {
        public string entranceDescription = "";
        public string southEastRoomDescription = "";
        public string southWestRoomDescription = "";
        public string eastRoomDescription = "";
        public string westRoomDescription = "";
        public string northEastRoomDescription = "";
        public string northRoomDescription = "";
        public string northWestRoomDescription = "";
        public string secretRoomDescription = "";

        public string Entrance
        {
            get { return entranceDescription; }
            set
            {
                entranceDescription =
                    "This is the prison entrance. The walls are made of indestructible concrete but they are fairly clean. " +
                    "There are two possible exits - one to the east and one to the west. In the corner of the room, " +
                    "you see a bucket. Press E or W if you want to move east or west.";
            }
        }

        public string SouthEastRoom
        {
            get { return southEastRoomDescription; }

            set
            {
                southEastRoomDescription =
                    "You are in the southeast room now. The walls are slightly dirtier... you think " +
                    "you can see some blood on one of the walls. Surprisingly, there's also a painting hanging " +
                    "suspiciously on the wall. You can exit the room to the west or to the north. Press N or W to proceed.";
            }
        }

        public string SouthWestRoom
        {
            get { return southWestRoomDescription; }
            set
            {
                southWestRoomDescription =
                    "You are in the southwest room. It's rather stuffy in this room. I wonder why? Maybe " +
                    "due to a lack of windows in the prison? I guess there's a reason for not having windows " +
                    "in a prison, though. The walls are dirty, except for the western wall, which seems " +
                    "surprisingly clean? You can exit the room to the east or to the north. Press N or E " +
                    "to proceed.";
            }
        }

        public string EastRoom
        {
            get { return eastRoomDescription; }
            set
            {
                eastRoomDescription =
                    "You are in the eastern room. There's d e f i n i t e l y blood on the eastern wall... that's " +
                    "disturbing as hell. There are two plants in the corners of the room, which is weird when " +
                    "you consider how bland and dark the rest of the prison is. You can exit the room to the " +
                    "north or to the south. Press N or S to proceed.";
            }
        }

        public string WestRoom
        {
            get { return westRoomDescription; }
            set
            {
                westRoomDescription =
                    "You are in the western room. This room is slightly less stuffy. Strange? The walls are painted " +
                    "red. Maybe they are trying to cover up some kind of fight that happened? It seems like " +
                    "they have forgotten to paint the part behind the couch on the northern side of the room. " +
                    "You can exit the room to the north or to the south. Press N or S to proceed.";
            }
        }

        public string NorthEastRoom
        {
            get { return northEastRoomDescription; }
            set
            {
                northEastRoomDescription =
                    "You are in the northeastern room. There's a table and a few chairs in the middle of the room. " +
                    "The walls are really bloody here... the prison guards haven't even bothered to wash the blood " +
                    "off. You're pretty sure that there's teeth on the ground as well. You can exit the room to the " +
                    "west or to the south. Press W or S to proceed.";
            }
        }

        public string NorthRoom
        {
            get { return northRoomDescription; }
            set
            {
                northRoomDescription =
                    "This room is surprisingly clean, considering the state of the adjacent rooms. There's " +
                    "tapestry on the southern wall. It's slightly torn but what the hell is tapestry doing in " +
                    "a high-security prison? There's also a rug on the floor and a book shelf with plenty of " +
                    "books. You can exit the room to the west or to the east. Press W or E to proceed.";
            }
        }

        public string NorthWestRoom
        {
            get { return northWestRoomDescription; }
            set
            {
                northWestRoomDescription =
                    "Another room with bloody walls. What the hell are the prison guards doing " +
                    ", do they want the prisoners to kill each other? I would have said yes, but " +
                    "the prison gets paid for each prisoner so maybe not. Seems like this room is meant " +
                    "to be a gym, but there's only a bench press and some bloody kettle bells. There's a rug " +
                    "under the bench press for some reason? You can exit the room to the south or to the east. " +
                    "Press S or E to proceed.";
            }
        }

        public string SecretRoom
        {
            get { return secretRoomDescription; }
            set
            {
                secretRoomDescription = "You have found the secret room! And the rumors were true, there's a hatch, " +
                                        "alright! Let's climb through and escape this godforsaken prison! It leads to a tunnel. " +
                                        "Why are there skeletons spread around this tunnel? And what's up with these nasty spiders? " +
                                        "Oh well, let's press on, to freedom!";
            }


        }
    }
}