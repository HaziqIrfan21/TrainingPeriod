using System;

namespace ExceptionHandling
{
    class Program
    {
        static int a, b, sum;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Program program = new Program();
                    Console.WriteLine("Enter first int");
                    int a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second int");
                    int b = Int32.Parse(Console.ReadLine());
                    program.Multiply(a, b);
                    program.Divide(a, b);
                  
                    //Console.WriteLine("result is : " + res);
                }
                catch (DivideByZeroException res)
                {

                    Console.WriteLine("Divided by zero");
                }
                catch (NullReferenceException res)
                {
                    Console.WriteLine("Null refrence error");
                }

                catch (FormatException res)
                {
                    Console.WriteLine("format exception error");
                }
            }
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void Divide(int a, int b)
        {
             Console.WriteLine(a / b);
        }
    }
}
