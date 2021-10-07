using System;
using System.Collections.Generic;

namespace EventHandler3
{
    class Program
    {
        static void Main(string[] args)
        {
            IAddition<int> genClassInt = new GenClass<int>();
            int i = genClassInt.Add(10, 20);
            Console.WriteLine("The output of the integer Operation: " + i);
            IAddition<double> genClassDouble = new Genclass1();
            double j = genClassDouble.Add(10.5, 20.8);
            Console.WriteLine("The output of the integer Operation: " + j);
        }
    }

    public interface IAddition<T>
    {
        T Add(T var1, T var2);
    }

    public class GenClass : IAddition<int>
    {
        int var1;
        int var2;

        public double Add(double v1,double v2)
        {
            var1 = v1;
            var2 = v2;
            return var1 + var1;

        }



       
    }
}
