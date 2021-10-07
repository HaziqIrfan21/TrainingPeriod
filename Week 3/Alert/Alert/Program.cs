using System;

namespace Alert
{
    class Program
    {
        public delegate void MyDelegate();

        public class XX
        {
            public event MyDelegate MyEvent;

            public void RaiseEvent()
            {
                MyEvent();
                Console.WriteLine("Event Raised");
            }

            public void Alert()
            {
                Console.WriteLine("Insert alert message here");
            }



        }
        static void Main(string[] args)
        {
            XX obj = new XX();
            obj.MyEvent += new MyDelegate(obj.Alert);
            obj.RaiseEvent();
            Console.ReadLine();
        }
    }
}
