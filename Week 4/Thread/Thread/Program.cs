using System;
using System.Threading;

namespace Threading2
{
    class Program
    {
        static void Main(string[] args)
        {

            InitThread();


        }
        public static void InitThread()
        {
            Thread t = new Thread((x) => { Display(); });
           // ThreadStart start = new ThreadStart(Display);
            Thread t1 = new Thread((x) => { Display2(); });



            t.Start();
            t1.Start();

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                if (i == 3)
                    t.Join();
                Console.WriteLine("I am in main thread");
            }
        }
        public static void Display()
        {
            Console.WriteLine("Display");
        }
        public static void Display2()
        {
            Console.WriteLine("Other Display");
        }
    }


}
