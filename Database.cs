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
                var x = Data[input];
                x.Add(user);                
            }
            else
            {
                Console.WriteLine("Device ID:" + input.ID + " doesn't exists.");
            }                
        }
        public void getKeys()
        {
            foreach (IDevice i in Data.Keys) { Console.WriteLine(i.ID +":"+i); }
        }
        public void getDevices()
        {
            foreach(KeyValuePair<IDevice,List<User>> item in Data)
            {
                Console.WriteLine("[" + item.Key.ID + "]" + " : ("+item.Key.Hostname+";"+item.Key.MAC+") Users: "+string.Join(";",item.Value));
            }
        }
        public void getDataFromFile(string path)
        {
            try
            {
                FileStream fileStream = new FileStream(path,FileMode.Open);
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        IDevice device;
                        string line = streamReader.ReadLine();
                        string[] array = line.Split(',');
                        if (array[2] == "R")
                        {
                            device = new Router(array[0], array[1]);
                            Data.Add(device, new List<User>());
                        }
                        else if (array[2] == "S")
                        {
                            device = new Switch(array[0], array[1]);
                            Data.Add(device, new List<User>());
                        }                        
                    }     
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Process finished");
            }
        }        
    }
}
