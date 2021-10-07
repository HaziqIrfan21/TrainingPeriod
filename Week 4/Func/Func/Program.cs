using System;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {


            //Action=> enter a number,it should display square of input

            Action<int> action1 = (a) =>
            {
              

                Console.WriteLine("Product of a and b is : {0}", a * a);
            };

            Console.WriteLine("insert  number");
            int a = Convert.ToInt32(Console.ReadLine());

            action1(a);

            //Function =>return the perfect square (100) -> returns 10

            Func<int,double> func2 = (a) => { return Math.Sqrt(a); };
            Console.WriteLine(func2(100));

            //Predicate => 100 ->10 return true if perfect square

            Predicate<int> predicate1 = (a) =>
            {
                if (a == Math.Sqrt(100))
                {
                    return true;
                }
                return false;
            };

            Console.WriteLine(predicate1(10));


        }

        public static int sum (int a,int b)
        {
            return a + b;
        }

        public static int returnConstantValue()
        {
            return 100;
        }

        private static void Func_Examples()
        {
            //Func examples
            Func<int, int, int> func = sum;
            Func<int> func1 = returnConstantValue;
            Func<int, int> func2 = (a) => { return a + 100; };


            Func<int, bool> isNegative = (a) =>
            {
                if (a < 0)
                {
                    return true;
                }
                return false;
            };


            Console.WriteLine(func(10, 20));
            Console.WriteLine(func1());
            Console.WriteLine(func2(10));

            Console.ReadLine();
        }

        private static void Action_Examples()
        {
            Action action = () => { Console.WriteLine("This is an empty action"); };
            Action<int, int> action1 = (a, b) =>
            {
                Console.WriteLine("Product of a and b is : {0}", a * b);
            };

            Action<double, double> action2 = (a, b) =>
            {
                Console.WriteLine("Product of a and b is : {0}", a * b);
            };
        }

        private static void Predicate_Examples()
        {
            Predicate<string> predicate = (str) =>
            {
                if (str.Length > 10)
                {
                    return true;
                }
                return false;
            };

            Predicate<int> predicate1 = (a) =>
            {
                if (a < 0)
                {
                    return true;
                }
                return false;
            };

            Console.WriteLine(predicate("str"));
            Console.WriteLine(predicate("thisisstring"));
        }
    }
}
