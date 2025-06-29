using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace networkDevices
{
    internal class Router : IDevice
    {
        private string hostName, mac;
        public Guid ID { get; }
        public string Hostname { get { return hostName; } set { hostName = value; } }
        public string MAC { get { return mac; } set { mac = value; } }
        public Router(string hostaname, string mac) { ID = Guid.NewGuid(); Hostname = hostaname; MAC = mac; }
    }
}
