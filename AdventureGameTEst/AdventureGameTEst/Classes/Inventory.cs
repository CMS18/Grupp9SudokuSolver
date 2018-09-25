using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureGameTEst.Extension_Methods;

namespace AdventureGameTEst.Classes
{
    public class Inventory 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public bool Key { get; set; }
        public bool CanTake { get; set; }

        public Inventory(int itemId, string itemName, string itemDescription, bool canTake, bool key)
        {
            Id = itemId;
            Name = itemName;
            Description = itemDescription;
            Key = key;
            CanTake = canTake;
        }


        public static List<Inventory> InventoryList()
        {
            List<Inventory> list = new List<Inventory>();

            Inventory bucket = new Inventory(0, "Bucket", "You found a bucket.It reeks but maybe there's a use for it?", true, false);
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

            list.ListAdd(bucket, painting, bigPlant, smallPlant, copperKey, couch, table, chairs, teeth, tapestry, rug,
                bookShelf, harryPotterBook, fiftyShadesBook, benchPress, kettlebells, oldRug, ironKey);
            return list;

        }

    }

        /*Olika föremål vi ska ha med
         Entrance: Bucket - ska kunna ta med den men ingen nytta.
         SouthEastRoom: Painting - ska kunna undersöka om det finns något bakom den.
         SouthWestRoom: Inget.
         EastRoom: Two plants - Ska kunna undersöka båda. En av dem ska innehålla en nyckel.
         WestRoom: Couch - Ska kunna undersöka bakom soffan. Inget ska finnas.
         NorthEastRoom: Table, chairs, teeth - Ska kunna undersöka. En stol samt tänder kan tas med.
         NorthRoom: Tapestry, rug, book shelf - ska alla kunna undersökas. Preliminärt ska man hitta hemliga nyckelhål bakom bokhyllan.
         Ska kunna ta böcker från bokhyllan.
         NorthWestRoom: Bench press, kettlebells, rug ska kunna undersökas. Ska kunna ta kettlebell. Under mattan ska det finnas en nyckel.
         */

        /*Item descriptions:
         0 Bucket = "You found a bucket. It reeks but maybe there's a use for it?"
         1 Painting = "A painting of my great idol, Adobe Gitler"
         3 Big Plant = "This plant is almost as big as me. It sits in a white flower pot. How does it grow so much when there's no 
         sunlight here?"
         4 Small Plant = "This plant is about a foot tall, but it has spiky vines. Seems pretty fitting for a prison."
         5 Copper Key = "A copper key. I wonder where it goes."
         6 Couch = "The couch sits 6 people. It's beside the wall and you can see that someone has forgotten to paint the wall behind it."
         7 Table = "An ordinary wood table, can seat four people."
         8 Chairs = "Normal wood chairs. Could possibly be used to climb somewhere."
         9 Teeth = "Sharp, yellow teeth."
         10 Tapestry = "It shows some kind of tunnel, with many small spiders and one big spider descending on a man."
         11 Rug = "A dirty rug with blood stains all over it."
         12 Book shelf = "A heavy book shelf with lots of books in it. Obviously, most of them are covered in books except for Harry Potter and 50 Shades of Grey."
         13 Harry Potter book = "Harry Potter and The Prisoner of Azkaban. It has been read a LOT."
         14 50 Shades of Grey = "Wow, this book is falling apart! Must be really popular."
         15 Bench press = "A normal bench press."
         16 Kettlebells = "40 pound kettlebells. A swing to the head could kill a man!"
         17 Rug2 = "A really old rug."
         18 Iron Key = "An iron key. I wonder where it goes."


         */


        //Use

        //Inspect
    }
