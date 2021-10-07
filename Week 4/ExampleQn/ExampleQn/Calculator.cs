using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleQn
{
    public delegate void interestDelegate(int principle, int interest, int timerange);
    class Calculator
    {
        int principle { get; set; }
        int timerRange { get; set; }
        int interest { get; set; }

        int simpleInterest { get; set; }



        public void Principle(int principle)
        {
            this.principle = principle;
        }

        public  void Interest(int interest)
        {
            this.interest = interest;
        }

        public void TimerRange(int timerRange)
        {
            this.timerRange = timerRange;
        }
        public void calc_SimpleInterest(int principle, int interest, int timerange)
        {
            Console.WriteLine((principle * interest * timerange) / 100);
        }
    }
}
