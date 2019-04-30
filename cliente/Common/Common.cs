using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Status
    {
        public string Id { get; set; }
        public string Time { get; set; }
        public string Stat { get; set; }
        public string Description { get; set; }
    }

    public class ClientConfig
    {
        public int ActivityTimeout { get; set; } = 15 * 1000 * 60; // 15 Minutos
        public int InputCheckRate { get; set; } = 5  * 1000 * 60; // 5 Min  
    }
}
