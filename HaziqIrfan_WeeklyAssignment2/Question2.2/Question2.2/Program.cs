using System;

namespace Question2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();

            Console.WriteLine("Enter Starting x");
            line.x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Starting Y");
            line.y1 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter Ending X");
            line.x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Y");
            line.y2 = Convert.ToInt32(Console.ReadLine());

        
            line.Display(line.x1,line.y1,line.x2,line.y2);
            Console.WriteLine("Display: " + line.x1 + "x");
            Console.WriteLine("Display: " +  line.y1 + "y");
            Console.WriteLine("Display: " +  line.x2 + "x");
            Console.WriteLine("Display: " + line.y2 + "y");


            line.Slope(line.y2, line.y1, line.x2 ,line.x1);
            Console.WriteLine("Slope: " + line.slope );

        }
    }
}
