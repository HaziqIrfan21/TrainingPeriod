using System;

namespace GeometricalShape
{
    class Program
    {

        public static int sides = 0;
        public static int angle1 = 0;
        public static int angle2 = 0;
        public static int angle3 = 0;
        public static int angle4 = 0;
        public static int angle5 = 0;
        public static int angle6 = 0;
        static void Main(string[] args)
        {
            bool isLoop = true;
            //write a c# program to find out from the given angle values whether
            //a geometrical shape can be formed or not .
            //if yes then what type of shape it is.
            //Use anonymous method, event and delegate and exception handling

            
            while (isLoop)
            {
                Console.WriteLine("Insert amount of sides");
                sides = int.Parse(Console.ReadLine());

                switch (sides)
                {
                    //Triangle
                    //Sum of interior == 180
                    //Each angle == 60
                    //Sides == 3
                    case 3:
                        try
                        {
                            Console.WriteLine("Insert first angle");
                            angle1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insert second angle");
                            angle2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insert third angle");
                            angle3 = int.Parse(Console.ReadLine());
                            Triangle(angle1, angle2, angle3);
                        }
                        catch (FormatException)
                        {

                            Console.WriteLine("Unable to take in float variables.Try again");
                        }

                       
                        break;

                    //Quadrilateral/square/rectangle
                    //Sum of interior == 360
                    //Each angle == 90
                    //Sides == 4
                    case 4:
                        Console.WriteLine("Insert first angle");
                        angle1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert second angle");
                        angle2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert third angle");
                        angle3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert fourth angle");
                        angle4 = int.Parse(Console.ReadLine());
                        Quadilateral(angle1, angle2, angle3, angle4);
                        break;
                    //Pentagon
                    //Sum of interior == 540
                    //Each angle == 108
                    //Sides == 5
                    case 5:
                        Console.WriteLine("Insert first angle");
                        angle1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert second angle");
                        angle2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert third angle");
                        angle3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert fourth angle");
                        angle4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert fifth angle");
                        angle5 = int.Parse(Console.ReadLine());
                        Pentagon(angle1, angle2, angle3, angle4, angle5);
                        break;

                    //Hexagon
                    //Sum of interior == 720
                    //Each angle == 120
                    //Sides == 6
                    case 6:
                        Console.WriteLine("Insert first angle");
                        angle1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert second angle");
                        angle2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert third angle");
                        angle3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert fourth angle");
                        angle4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert fifth angle");
                        angle5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert sixth angle");
                        angle6 = int.Parse(Console.ReadLine());
                        Hexagon(angle1, angle2, angle3, angle4, angle5, angle6);
                        break;
                    default:
                        break;
                }



            }





        }

        public static bool Triangle(int angle1, int angle2, int angle3)
        {

            int result = angle1 + angle2 + angle3;
            if (result == 180)
            {
                Console.WriteLine("Triangle is formed");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid degrees for Triangle to form");
                return false;
            }
              

        }

        public static bool Quadilateral(int angle1, int angle2, int angle3, int angle4)
        {

            int result = angle1 + angle2 + angle3 + angle4;
            if (result == 360)
            {
                Console.WriteLine("Quadilateral is formed");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid degrees for Quadilateral to form");
                return false;
            }

        }

        public static bool Pentagon(int angle1, int angle2, int angle3, int angle4, int angle5)
        {

            int result = angle1 + angle2 + angle3 + angle4 + angle5;
            if (result == 540)
            {
                Console.WriteLine("Pentagon is formed");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid degrees for Pentagon to form");
                return false;
            }

        }

        public static bool Hexagon(int angle1, int angle2, int angle3, int angle4, int angle5,int angle6)
        {

            int result = angle1 + angle2 + angle3 + angle4 + angle5;
            if (result == 720)
            {
                Console.WriteLine("Pentagon is formed");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid degrees for Hexagon to form");
                return false;
            }

        }

    }
}
