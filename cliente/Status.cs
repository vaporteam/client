﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente
{
    class Status : Common.Status
    {
        public Status(string CurrentStatus, string Description)
        {
            this.Id = Environment.UserName + '@' + Environment.UserDomainName;
            this.Time = DateTime.Now.ToString();
            this.Stat = CurrentStatus;
            this.Description = Description;
        }
        public bool Post()
        {
            return Messenger.Post(this);
        }
    }
}
