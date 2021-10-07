using System;

namespace EventHandler1
{
    class Program
    {

        //Write a class which has a function which can take any function as an argument.
        //Execute the function passed as an argument and Print the nameof the function to be executed.
        static void Main(string[] args)
        {
            Console.WriteLine("insert first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert  second number");
            int b = Convert.ToInt32(Console.ReadLine());


            // Func<int, int,int> func = Func_Add;

            Func<int, int, int> func = Func_Add;

            Func<int, int, int> func1 = Func_Minus;

            Console.WriteLine(func(a,b));
            Console.WriteLine(func1(a, b));


        }

       public static void Func_Argument( Func<int,int> methodName)
        {

            Console.WriteLine("Func_Argument is called");
        }

        public static int Func_Add(int a,int b)
        {
            Console.WriteLine("Func_Add is called");
            return a + b;



        }

        public static int  Func_Minus(int a, int b)
        {
            Console.WriteLine("Func_Minus is called");
            return a - b;
         
        }
    }
}
