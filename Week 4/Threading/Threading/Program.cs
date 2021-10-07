using System;
using System.Threading;
using System.Linq;

namespace Threading
{
    class Program
    {

        public int abc = 12;
        object _lock = new object();

        private string _threadData;

        private string ThreadData
        {

            get
            {
                return _threadData;
            }


            set
            {
                lock (_lock)
                _threadData = value; //Critical section
            }
        }
        static void Main(string[] args)
        {
            CallDisplayAsynchchronously();
        }

        public static void CallDisplayAsynchchronously()
        {

            Console.WriteLine("In CallDisplayAsynchchronously");
            Thread t = new Thread((x) => { Display(); });
            ThreadStart start = new ThreadStart(Display);
            Thread tp = new Thread(new ParameterizedThreadStart(DisplayParameter));
            tp.Priority = ThreadPriority.Highest;

            Thread t1 = new Thread(start);
            Console.WriteLine("Before starting thread");

            ParameterizedThreadStart param = new ParameterizedThreadStart(DisplayParameter);
            Thread pts = new Thread(param);

            Thread temp1 = new Thread(new ParameterizedThreadStart(DisplayParameter));



            t.Start();
            t1.Start();
            Console.WriteLine("Started thread");
            t = new Thread((x) => { Display2(); });
            t.Start();

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                if (i == 10)
                    t.Join();
                Console.WriteLine("I am in main thread");
            }


        }

        public static void DisplayParameter(object str)
        {
            Console.WriteLine("I am in display");
        }


        public static void Display()
        {
            Console.WriteLine("I am in display");
        }
        public static void Display1()
        {
            Console.WriteLine("I am in display1");
        }
        public static void Display2()
        {
            Console.WriteLine("I am in display2");
        }
    }
}
