using System;

namespace Age
{
    class Program : Icalculator
    {
        //char Operator;
        //float num1, num2;
        static char Operator;
        static int num1, num2;
        static bool loop = true;
        static int plus = 0;
        static int minus = 0;
        static int times = 0;
        static int divide = 0;
        static int sum = 0;

        //public static void Add()
        //{
        //    Console.WriteLine(num1 + num2);
        //    plus++;
        //}

        //public static void Minus()
        //{
        //    Console.WriteLine(num1 - num2);
        //    minus++;
        //}

        //public static void Times()
        //{
        //    Console.WriteLine(num1 * num2);
        //    times++;
        //}

        //public static void Divide()
        //{
        //    Console.WriteLine(num1 / num2);
        //    divide++;
        //}

        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        public delegate void mulnum(int a, int b);
        public delegate void divnum(int a, int b);

        public delegate void CalculatorDelegate(int a, int b);

        //Event
        public event CalculatorDelegate MyEvent;
        public void RaiseEvent(int a, int b)
        {
            Console.Write("Process to call addnum started");
            MyEvent(a, b);
        }

       



        public void delegateAdd(int a , int b)
        {
            Console.WriteLine(a + b);
            plus++;
        }

        public void delegateSubtract(int a, int b)
        {
            Console.WriteLine(a - b);
            minus++;
        }

        public void delegateMultiply(int a, int b)
        {
            Console.WriteLine(a * b);
            times++;
        }

        public void delegateDivide(int a, int b)
        {
            Console.WriteLine(a / b);
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
            Program calculator = new Program();
            Program obj = new Program();

            Program obj2 = new Program();
            obj2.MyEvent += new CalculatorDelegate(obj.delegateAdd);
            obj2.MyEvent += new CalculatorDelegate(obj.delegateSubtract);
            obj2.MyEvent += new CalculatorDelegate(obj.delegateMultiply);
            obj2.MyEvent += new CalculatorDelegate(obj.delegateDivide);




            addnum del_AddNumObj = new addnum(obj.delegateAdd);
            subnum del_SubNumObj = new subnum(obj.delegateSubtract);
            mulnum del_MulnumObj = new mulnum(obj.delegateMultiply);
            divnum del_DivnumObj = new divnum(obj.delegateDivide);

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

                obj2.RaiseEvent(num1, num2);
                switch (Operator)
                {
                    case '+':
                        //Console.WriteLine(num1 + num2);
                        //plus++;
                        // Add();
                        //calculator.Add(num1, num2);
                        //del_AddNumObj.Invoke(num1, num2);
                        obj2.RaiseEvent(num1,num2);

                        break;

                    case '-':
                        //Console.WriteLine(num1 - num2);
                        //minus++;
                        //Minus();
                        //calculator.Subtract(num1, num2);
                        //del_SubNumObj.Invoke(num1, num2);
                        obj2.RaiseEvent(num1, num2);
                        break;

                    case '*':
                        //Console.WriteLine(num1 * num2);
                        //times++;
                        //Times();
                        //calculator.Times(num1, num2);
                        //del_MulnumObj.Invoke(num1, num2);
                        obj2.RaiseEvent(num1, num2);
                        break;

                    case '/':
                        //Console.WriteLine(num1 / num2);
                        //divide++;
                        //Divide();
                        //calculator.Divide(num1, num2);
                        //del_DivnumObj.Invoke(num1, num2);
                        obj2.RaiseEvent(num1, num2);
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

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
            plus++;
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
            minus++;
        }

        public void Times(int a, int b)
        {
            Console.WriteLine(a * b);
            times++;
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
            divide++;
        }
    }
}
