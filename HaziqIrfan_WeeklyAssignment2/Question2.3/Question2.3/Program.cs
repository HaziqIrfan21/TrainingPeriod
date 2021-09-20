using System;

namespace Question2._3
{
    class Program
    {
        static char Operator;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Class of travel: 1 for first , 2 for 2nd, 3 for third");
            Operator = char.Parse(Console.ReadLine());

            FirstClass firstClass = new FirstClass();
            SecondClass secondCLass = new SecondClass();
            ThirdClass ThirdClass = new ThirdClass();
            switch (Operator)
            {
                case '1':
                    Console.WriteLine("Input cost per km");

                    
                    break;
                case '2':
                    break;
                case '3':
                    break;
                default:
                    break;
            }
        }
    }

    class FirstClass : IcostCalculator
    {
        int firstClassCostPerKm;
        int firstClassTotalCost;
        public void costPerKm(int cost)
        {
            firstClassCostPerKm = cost;
        }

        public void totalCost(int distanceTravel, int cost)
        {
            firstClassTotalCost = distanceTravel / cost;
        }
    }
    class SecondClass : IcostCalculator
    {
        int SecondClassCostPerKm;
        int SecondClassTotalCost;

        public void costPerKm(int cost)
        {
            SecondClassCostPerKm = cost;
        }

        public void totalCost(int distanceTravel, int cost)
        {
            SecondClassTotalCost = distanceTravel / cost;
        }
    }
    class ThirdClass : IcostCalculator
    {
        int ThirdClassCostPerKm;
        int ThirdClassTotalCost;

        public void costPerKm(int cost)
        {
            ThirdClassCostPerKm = cost;
        }

        public void totalCost(int distanceTravel, int cost)
        {
            ThirdClassTotalCost = distanceTravel / cost;
        }

    }
}
