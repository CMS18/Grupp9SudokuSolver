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
        public string Id { get; set; }
        public string MatchID { get; set; }
        public bool Usable { get; set; }
        public string AddDescriptionToRoom { get; set; }

        public Inventory(string itemId, string itemName, string itemDescription, bool usable)
        {
            Id = itemId;
            Name = itemName;
            Description = itemDescription;
            Usable = usable;
            MatchID = "0";
        }

        public bool IsUsable()
        {
            return Usable;
        }
    }


        //Use

        //Inspect
    }
