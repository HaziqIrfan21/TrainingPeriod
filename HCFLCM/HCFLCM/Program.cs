using System;

namespace HCFLCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("LCM of " + a + " and " + b + " is " + LowestCommonMultiple(a, b));
            Console.WriteLine("HCF of " + a + " and " + b + " is " + GreatestCommonDenominator(a, b));

        }

        static int GreatestCommonDenominator(int a, int b)
        {
            if(a == 0)
            {
                return b;
            }

            return GreatestCommonDenominator(b % a, a);
        }

        static int LowestCommonMultiple(int a, int b)
        {
            return (a / GreatestCommonDenominator(a, b) * b);
        }


    }

    
}
