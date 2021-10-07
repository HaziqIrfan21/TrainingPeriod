using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace TaskExample
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Calling task_run_example method");


            //Task_Run_Example().Wait();
            //Console.WriteLine("BACK IN MAIN METHOD");
            //Console.ReadLine();

        }

        private static void Exception_Handling_in_multipleTask()
        {
            var task = new List<Task<int>>();
            Func<object, int> func = (obj) =>
             {
                 int i = (int)obj;

                 if (i >= 2 && i <= 5)
                 {
                     throw new InvalidOperationException();
                 }
                 Console.WriteLine($"Task Id : {Task.CurrentId}");
                 Console.WriteLine($"Thread id for this task :  { Thread.CurrentThread.ManagedThreadId})");
                 Console.WriteLine($"Task executed with value : {i}");

                 return 100 * i;


             };

            for (int i = 0; i < 10; i++)
            {
                task.Add(Task<int>.Factory.StartNew(func, i));
            }

            try
            {
                Task.WaitAll(task.ToArray());
                Console.Write("In try block completed runnin all task");
            }
            catch(AggregateException ex)
            {
                Console.WriteLine("Exception raised as expected");
                for (int j = 0; j < ex.InnerExceptions.Count; j++)
                {
                    Console.WriteLine("Inner exception caught"+ ex.InnerExceptions[j]);
                }
            }


        }

        private static void Task_WaitAll_Example()
        {
            var tasks = new List<Task>();

            Action<object> action = DoSomething;
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task_Run_Example());
            }
            Task.WaitAll();
        }
        public static async Task Task_Run_Example()
        {
            Console.WriteLine("In Task_Run_Example method");

            await Task.Run(()=>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine($"In task.run for iteration {i}");
                    Thread.Sleep(1000);
                }
            });

            Console.WriteLine("going  out of task_run_example method");
        }

        private static void Task_Declaration_Examples()
        {
            Action<object> action = DoSomething;
            Action<object> action_1 = DoSomething_1;

            //First way to declare a task
            Task t1 = new Task(action, "apple");
            t1.Start();

            Task t2 = new Task(action_1, "ball");
            t2.Start();

            //Second way to declare a task
            Task t3 = Task.Factory.StartNew(action, "cat");

            //third way to declare a task
            Task t4 = Task.Run(() =>
            {
                Console.WriteLine($"Task Id: {Task.CurrentId}");
                Console.WriteLine($"Task Id for this task :  {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"TaskBackground value :  {Thread.CurrentThread.IsBackground}");
                // Console.WriteLine($"task executed with value:  {somevalue}");
            });


            Task t5 = new Task(action_1, "eagle");
            t5.RunSynchronously();

            t1.Wait();
            t2.Wait();
            t3.Wait();
            t4.Wait();
            Console.ReadLine();
        }

        public static void DoSomething(object somevalue)
        {
            Thread.Sleep(10000);
            Console.WriteLine($"Task Id: {Task.CurrentId}");
            Console.WriteLine($"Task Id for this task :  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"task executed with value {somevalue}");
        }

        public static void DoSomething_1(object somevalue)
        {
            Console.WriteLine($"Task Id: {Task.CurrentId}");
            Console.WriteLine($"Task Id for this task :  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"task executed with value {somevalue}");
        }
    }
}
