using System;

namespace HotelManagement
{
    class Program
    {

        static string roomName;
        static bool SingleChoosen;
        static bool DoubleChoosen;
        static bool DeluxeChoosen;

        static bool ServiceX;
        static bool ServiceY;
        static bool ServiceZ;

        static void Main(string[] args)
        {


            Console.WriteLine("Single Room");
            RoomBooking single = new RoomBooking("Single","Services", 300);
            single.print();
            Console.WriteLine("");

            Console.WriteLine("Double Room");
            RoomBooking Double = new RoomBooking("Double", "Services", 600);
            Double.print();
            Console.WriteLine("");

            Console.WriteLine("Deluxe Room");
            RoomBooking Deluxe = new RoomBooking("Deluxe", "Services", 900);
            Deluxe.print();
            Console.WriteLine("");

            Console.WriteLine("Type out room you want");
            roomName = Console.ReadLine();

            switch (roomName)
            {
                case "Single":

                    Console.WriteLine("Single Room was choosen");
                    SingleChoosen = true;
                    break;

                case "Double":
                    Console.WriteLine("Single Double was choosen");
                    DoubleChoosen = true;
                    break;

                case "Deluxe":
                    Console.WriteLine("Deluxe Room was choosen");
                    DeluxeChoosen = true;
                    break;

                default:
                    break;
            }

        }

      
    }
}
