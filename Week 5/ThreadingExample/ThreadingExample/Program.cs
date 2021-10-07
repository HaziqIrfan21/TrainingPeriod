using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadingExample
{

    public class generic<T>
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling sleep task method");
            //asynchronous
            //THREAD MANAGE ID
           // var th_2 = new Thread(new ThreadStart(sleepTask));
            Thread background_Thread = new Thread(new ParameterizedThreadStart(sleepTask));
            background_Thread.IsBackground = true;
            Console.WriteLine("thread_name.IsBackground for thread_name" + background_Thread.IsBackground);
            background_Thread.Start();

           
            //sleepTask();

            Console.WriteLine("Calling do something method");
            //doSomething();
            //synchronous
            // background_Thread.Join();
            //Foreground must wait for background before executing
            Thread foreground_Thread = new Thread(new ThreadStart(doSomething));
            Console.WriteLine("thread_name.IsBackground for thread_name_1" + foreground_Thread.IsBackground);
            foreground_Thread.Start();

            Console.WriteLine("Done with main program");
            Console.ReadLine();
        }

        

        public static void sleepTask(object sleepduration)
        {
            Console.WriteLine("In sleepTask,Taking a nap");
            Thread.Sleep((int)sleepduration * 1000);
            Console.WriteLine("I am done work");
        }
        public static void doSomething()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Perform task quickly");
        }
    }
}
