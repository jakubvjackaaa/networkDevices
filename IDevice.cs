using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace networkDevices
{
    internal interface IDevice
    {
        Guid ID { get; }
        string Hostname { get; set; }
        string MAC { get; set; }        
    }
}
