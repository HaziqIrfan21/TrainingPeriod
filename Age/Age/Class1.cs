using System;
using System.Collections.Generic;
using System.Text;

namespace Age
{
    class Age
    {
        public int age;
        public int ID;
        public string Name;

        public Age(int i, int x ,string s )
        {
            age = i;
            ID = x;
            Name = s;
        }

        public Age (int i)
        {
            age = i;
        }
        public void print()
        {
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("ID: " + ID );
            //Console.WriteLine("Name: " + Name);
            Console.WriteLine( age);
            Console.WriteLine( ID);
            Console.WriteLine(Name);
        }
    }
}
