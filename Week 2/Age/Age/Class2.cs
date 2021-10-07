using System;
using System.Collections.Generic;
using System.Text;

namespace Age
{

    class example
    {
        sealed class sealClass
        {
            public int Add(int i, int x)
            {
                return i + x;
            }
        }

        static example()
        {
            Console.WriteLine("Static Constructor");
        }

    }
    
}
