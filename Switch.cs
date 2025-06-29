using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace networkDevices
{
    internal class Switch:IDevice
    {
        private string hostName, mac;
        public Guid ID { get;}
        public string Hostname { get { return hostName; } set { hostName = value; } }
        public string MAC { get { return mac; } set { mac = value; } }
        public Switch(string hostaname,string mac) { ID = Guid.NewGuid();Hostname = hostaname;MAC = mac; }
    }
}
