using System;
using System.Threading;

namespace WeeklylAssignment5._4
{
    class Program
    {
        static char Operator;
        static double num1, num2;
        static bool loop = true;
        static int plus = 0;
        static int minus = 0;
        static int times = 0;
        static int divide = 0;
        static int sum = 0;

        static void Main(string[] args)
        {


            Console.WriteLine("Calculator");

            while (loop)
            {
                ThreadInit();

                switch (Operator)
                {
                    case '+':

                        Thread t = new Thread((x) => { Add(num1,num2); });
                        t.Start();
                        break;

                    case '-':
                        Thread t2 = new Thread((x) => { Subtract(num1, num2); });
                        t2.Start();

                        break;

                    case '*':
                        Thread t3 = new Thread((x) => { Times(num1, num2); });
                        t3.Start();

                        break;

                    case '/':
                        Thread t4 = new Thread((x) => { Divide(num1, num2); });
                        t4.Start();

                        break;

                    case '%':
                        Thread t5 = new Thread((x) => { Modulo(num1, num2); });
                        t5.Start();
                        break;

                    case '^':
                        Thread t6 = new Thread((x) => { Power(num1, num2); });
                        t6.Start();
                        break;


                    case '~':
                        loop = false;
                        break;

                    default:

                        break;
                }
            }
        }

        public static void ThreadInit()
        {
            try
            {
                Console.WriteLine("Input first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input operator");
                Operator = char.Parse(Console.ReadLine());
                Console.WriteLine("Input second number");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {

                throw new FormatException("Input proper numbers", ex);
                
            }
          
        }

        public static void Add(double a, double b)
        {
            Console.WriteLine(a + b);

        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine(a - b);

        }

        public static void Times(double a, double b)
        {
            Console.WriteLine(a * b);

        }

        public static void Divide(double a, double b)
        {
            Console.WriteLine(a / b);

        }
        public static void Modulo(double a, double b)
        {
            Console.WriteLine(a % b);

        }
        public static void Power(double a, double b)
        {
            double power_ab = Math.Pow(a, b);
            Console.WriteLine(power_ab);

        }

    }
}
