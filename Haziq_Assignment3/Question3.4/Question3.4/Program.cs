using System;
using System.Collections.Generic;

namespace Question3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int tracking_Id = 0;

            PackageManager packageManager = new PackageManager();

            packageManager.Receive();

            foreach (var package in packageManager.PackageList )
            {
                Console.WriteLine("Package Details: {0}, {1}, {2}, {3},", package.id, package.sender_Name, package.receiver_Name, package.receiver_Address);
            }

            packageManager.Dispatch(tracking_Id);

            foreach (var package in packageManager.PackageList)
            {
                Console.WriteLine("Package Details: {0}, {1}, {2}, {3},", package.id, package.sender_Name, package.receiver_Name, package.receiver_Address);
            }
        }
    }


    public class Package
    {
        public int id;
        public string sender_Name;
        public string receiver_Name;
        public string receiver_Address;

        public Package(int ID, string Sender_Name,string Receiver_Name,string Receiver_Address)
        {
            this.id = ID;
            this.sender_Name = Sender_Name;
            this.receiver_Name = Receiver_Name;
            this.receiver_Address = Receiver_Address;
        }

        int ID
        {
            get 
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        string Sender_Name
        {
            get
            {
                return sender_Name;
            }

            set
            {
                sender_Name = value;
            }
        }
        string Receiver_Name
        {
            get
            {
                return receiver_Name;
            }

            set
            {
                receiver_Name = value;
            }
        }
        string Receiver_Address
        {
            get
            {
                return receiver_Address;
            }

            set
            {
                receiver_Address = value;
            }
        }


    }

     class PackageManager
    {
        public List<Package> PackageList = new List<Package>();

        //Test Package
        
       public void Receive()
        {
            PackageList.Add(new Package(0, "Sender_name", "receiver_name", "receiver_adress"));
        }

        public void Dispatch(int tracking_ID)
        {
           

            PackageList.RemoveAt(tracking_ID);
        }
    }
}
