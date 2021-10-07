using System;
using System.Timers;

namespace DelegateEventTimer
{
    class Program 
    {
        private static Timer timer;
        static int counter;

        public delegate void MyDelegate();

        public event MyDelegate MyEvent;

        public void RaiseEvent()
        {
            MyEvent();
            Console.WriteLine("Event Raised");

            
        }

        

        static void Main(string[] args)
        {

            Program program = new Program();

            timer = new System.Timers.Timer();
            timer.Interval = 1000;

            timer.Elapsed += OnTimedEvent;        
            timer.AutoReset = true;
            timer.Enabled = true;
            Console.ReadLine();
           
               


        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Program program = new Program();

            Console.WriteLine("Raised: {0}", e.SignalTime);
            counter++;
            Console.WriteLine("The counter is : " + counter);
        }

    }
}
