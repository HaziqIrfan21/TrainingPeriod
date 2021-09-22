using System;

namespace DayToSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter days:");
            int days = Convert.ToInt32(Console.ReadLine());
            int seconds = days * 24 * 60 * 60;
            Console.WriteLine(seconds + " Seconds");

            //Boxing Unboxing

            int num = 12;
            object obj = num;

            object obj1 = 15;
            int num1 = (int)obj;
        }
    }
}
