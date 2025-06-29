using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace networkDevices
{
    internal class User
    {
        private Guid ID;
        public string UserName { get; set; }
        public User(string userName) { UserName = userName; ID = Guid.NewGuid(); }
        public override string ToString() { return UserName; }
    }
}
