﻿using AdventureGameTEst.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameTEst
{
    public class Exit
    {
        Room leadsTo;
        string direction;
        private bool Locked { get; set; }
        private string lockType;
        public string lockDescription;

        public Exit(Room leadsTo, string direction)
        {
            this.leadsTo = leadsTo;
            this.direction = direction;
            Locked = false;
            lockType = "/NULL/";
            lockDescription = "/NULL/";
        }

        public Exit(Room leadsTo, string direction, bool locked, string lockType, string lockDescription)
        {
            this.leadsTo = leadsTo;
            this.direction = direction;
            Locked = locked;
            this.lockType = lockType;
            this.lockDescription = lockDescription;
        }

        public string GetDirection()
        {
            return direction;
        }

        public Room LeadsTo()
        {
            return leadsTo;
        }

        public bool IsLocked()
        {
            return Locked;
        }
        
        public void Unlock()
        {
            Locked = false;
        }
        
        public string GetLockType()
        {
            return lockType;
        }
    }
}