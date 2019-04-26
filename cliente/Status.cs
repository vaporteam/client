using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente
{
    class Status
    {

        public string Id { get; set; }
        public string Time { get; set; }

        public string Stat { get; set; }

        public Status(string currentStatus)
        {
            this.Id = Environment.UserName + '@' + Environment.UserDomainName;
            this.Time = DateTime.Now.ToString();
            this.Stat = currentStatus;
        }

        public void Post()
        {
            Messenger.Post(this);
        }
    }
}
