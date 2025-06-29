using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace networkDevices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            IDevice router = new Router("XXX", "VVVV");
            IDevice switch_ = new Switch("FGSFSD", "CVCXVX");
            database.getNewDevice(router);
            database.getAddUsersUsingDevice(router,new User("jannovak"));
            database.getAddUsersUsingDevice(router, new User("jakubvjacka"));
            database.getDevices();
        }
    }
}
