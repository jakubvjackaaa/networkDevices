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
            Console.WriteLine(database.GetType());
        }
    }
}
