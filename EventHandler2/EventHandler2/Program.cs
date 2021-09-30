using System;

namespace EventHandler2
{
    class Program
    {
      
        private string[] Value = new string[3];

        public string this[int index]
        {
            get
            {
                return Value[index];
            }

            set
            {
                Value[index] = value;
            }
        }
        //public static bool strCheck(string myString)
        //{
        //    if(myString.Contains ==)
        //}

        public delegate bool my_Delegate(string myString);

        //Create a class which has an array with some values.
        //Constitute a function which can eveluate whether a user provided parameter is present in the array using Predicate delegate.
        static void Main(string[] args)
        {
            Program program = new Program();

            string[] name = { "Tom", "Richard", "Michael" };

            Console.WriteLine("Input Name");
            var UserName = Console.ReadLine();

            var result = Array.Find(name,element => element == UserName);

            if (result != null)
            {
                Console.WriteLine("Username found");
            }
            else
            {
                Console.WriteLine("Username not found");
            }


            //Predicate<string> predicate1 = (a) =>
            //{
            //    if (a.[] == program.Value))
            //    {
            //        return true;
            //    }
            //    return false;
            //};

            //Console.WriteLine(predicate1("Test4"));

        }

    

    }
}
