using AdventureGameTEst.Classes;
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
        private string lockName;
        private string lockType;
        private string lockId;
        public string lockDescription;

        public Exit(Room leadsTo, string direction)
        {
            this.leadsTo = leadsTo;
            this.direction = direction;
            Locked = false;
            lockType = "/NULL/";
            lockDescription = "/NULL/";
        }

        public Exit(Room leadsTo, string direction, bool locked, string lockName, string lockId, string lockType, string lockDescription)
        {
            this.lockName = lockName;
            this.lockId = lockId;
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

        public string GetLockDescription()
        {
            return lockDescription;
        }

        public void Unlock()
        {
            Locked = false;
        }
        
        public string GetLockType()
        {
            return lockType;
        }

        public string GetId()
        {
            return lockId;
        }


    }
}
