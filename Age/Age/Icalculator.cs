using System;
using System.Collections.Generic;
using System.Text;

namespace Age
{
    interface Icalculator
    {
        void Add(int a, int b);
        void Subtract(int a, int b);
        void Times(int a, int b);
        void Divide(int a, int b);
    }
}
