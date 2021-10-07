using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        private static void test(int g, string s, params int[] list)
        {
            int a = 25;
            int b = 10;


            int res = a - b;
            
            foreach (int i in list)
            {
                res += i;
            }

            return res;
        }
    }

    
}
