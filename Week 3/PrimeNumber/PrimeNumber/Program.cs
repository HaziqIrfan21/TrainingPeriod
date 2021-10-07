using System;
using System.Collections.Generic;
namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primelist = new List<int>();

            Console.WriteLine("Enter number for Prime checker");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PrimeCheck(input));
            primelist.Add(input);
        }

        static bool PrimeCheck(int n)
        {

            //Prime one
            if (n <= 1)
            {
                return false;
            }

            //prime checker
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
