using System;

namespace Question2._1
{
    class Program
    {
        static bool loop = true;
        static char Operator;
        static void Main(string[] args)
        {

            
           
            while (loop)
            {

                LandCalculator landCalculator = new LandCalculator();

                Console.WriteLine("Input the cost per sq.ft");
                int cost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the Length of rectangle");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the breadth of rectangle");
                int breadth = Convert.ToInt32(Console.ReadLine());

                landCalculator.CalculateArea(length, breadth);
                Console.WriteLine("Area of rectangle: " +landCalculator.area);

                landCalculator.CalculateCost(landCalculator.area, cost);
                Console.WriteLine("Cost of land: " + "$" + landCalculator.totalcost);

               

            }

            

        }
    }
}
