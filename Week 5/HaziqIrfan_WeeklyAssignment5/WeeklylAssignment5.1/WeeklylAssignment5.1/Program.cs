using System;
using System.Threading;
namespace WeeklylAssignment5._1
{
    class Program
    {

        private static bool _isThreadRunning = true;
        static void Main(string[] args)
        {
            bool isRunning = true;
            int option;
            int threadCount = 0;

            while (isRunning)
            {
                Console.WriteLine("Choose your option: ");
                Console.WriteLine("1: Create a thread");
                Console.WriteLine("2: Destroy a thread by ID ");
                Console.WriteLine("3: Check how many threads are running ");
                Console.WriteLine("4: Make a thread run synchronously by ID ");
                Console.WriteLine("5: Make a thread sleep ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        Thread thread = new Thread((x) => { ThreadInit(); });
                        thread.Start();
                        Console.WriteLine("Thread has started");


                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Input timer for thread sleep ");
                        int i = int.Parse(Console.ReadLine());
                        Thread.Sleep(i);
                        break;
                    default:
                        break;
                }



            }



        }

        public static void ThreadInit()
        {
            while (_isThreadRunning)
            {
                Console.WriteLine("Thread is running");
                Thread.Sleep(1000);
            }
        }

        public static void ThreadStop()
        {
            _isThreadRunning = false;
        }

       
    }
}



