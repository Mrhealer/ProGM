﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGM.Business.Model
{
    public class SocketReceivedData
    {
        public string msgFrom { get; set; }
        public string msgTo { get; set; }
        public string msg { get; set; }
        public string type { get; set; }
        public string macAddressFrom { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public decimal accountBlance { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeUpdate { get; set; }
        public int timeUsed { get; set; }
        public int timeRemaining { get; set; }
        public decimal price { get; set; }
    }
}
