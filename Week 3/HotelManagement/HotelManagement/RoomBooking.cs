using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement
{
    class RoomBooking
    {
        public string nameOfRoom;
        public string services;
        public double bill;

        public RoomBooking(string i, string x, double z)
        {
            nameOfRoom = i;
            services = x;
            bill = z;
        }

       
        public void print()
        {
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("ID: " + ID );
            //Console.WriteLine("Name: " + Name);
            Console.WriteLine(nameOfRoom);
            Console.WriteLine(services);
            Console.WriteLine(bill);
        }
    }
}
