using System;

namespace Age
{
    class Program
    {
        //char Operator;
        //float num1, num2;
        static char Operator;
        static float num1, num2;
        static bool loop = true;
        static int plus = 0;
        static int minus = 0;
        static int times = 0;
        static int divide = 0;
        static int sum = 0;

        public static void Add()
        {
            Console.WriteLine(num1 + num2);
            plus++;
        }

        public static void Minus()
        {
            Console.WriteLine(num1 - num2);
            minus++;
        }

        public static void Times()
        {
            Console.WriteLine(num1 * num2);
            times++;
        }

        public static void Divide()
        {
            Console.WriteLine(num1 / num2);
            divide++;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Details of Tom");
            Age tom = new Age(10,1998,"Tom");
            tom.print();

            Console.WriteLine("Age of Richard");
            Age richard = new Age(12);
            richard.print();
            Console.WriteLine("");
            Console.WriteLine("");

            //char Operator;
            //float num1, num2;
            //bool loop = true;
            //int plus = 0;
            //int minus = 0;
            //int times = 0;
            //int divide = 0;

            Console.WriteLine("Calculator");
            while (loop)
            {
                Console.WriteLine("Input first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input operator");
                Operator = char.Parse(Console.ReadLine());
                Console.WriteLine("Input second number");
                num2 = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Amount of Plus: " + plus);
                //Console.WriteLine("Amount of Minus: " + minus );
                //Console.WriteLine("Amount of Times: " + times);
                //Console.WriteLine("Amount of Divide: " + divide);


                switch (Operator)
                {
                    case '+':
                        //Console.WriteLine(num1 + num2);
                        //plus++;
                        Add();
                        break;

                    case '-':
                        //Console.WriteLine(num1 - num2);
                        //minus++;
                        Minus();
                        break;

                    case '*':
                        //Console.WriteLine(num1 * num2);
                        //times++;
                        Times();
                        break;

                    case '/':
                        //Console.WriteLine(num1 / num2);
                        //divide++;
                        Divide();
                        break;

                    case '~':
                        loop = false;
                        break;

                    default:

                        break;

                }
                Console.WriteLine("Amount of Plus: " + plus);
                Console.WriteLine("Amount of Minus: " + minus);
                Console.WriteLine("Amount of Times: " + times);
                Console.WriteLine("Amount of Divide: " + divide);
                sum = plus + minus + times + divide;
                Console.WriteLine("Total Amount: " + sum);

            }

         



        }
    }
}
