using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace networkDevices
{
    internal class Database
    {
        private Dictionary<IDevice,List<User>> Data { get; set; }               
        public Database() { Data = new Dictionary<IDevice, List<User>>(); }
        public void getNewDevice(IDevice device)
        {
            if(device is Router || device is Switch)
            {
                Data.Add(device, new List<User>());                
            }            
        }
        public void getAddUsersUsingDevice(IDevice input,User user)
        {
            if (Data.ContainsKey(input))
            {
                Data[input].Add(user);                
            }
            else
            {
                Console.WriteLine("Device ID:" + input.ID + " doesn't exists.");
            }                
        }        
        public void getDevices()
        {
            foreach(KeyValuePair<IDevice,List<User>> item in Data)
            {
                Console.WriteLine("[" + item.Key.ID + "]" + " : ("+item.Key.Hostname+";"+item.Key.MAC+") Users: "+string.Join(";",item.Value));
            }
        }                
    }
}
