using System;

namespace ExceptionHandling4
{
    class Program
    {

        //Create an array with 10 integers, Write an indexer to access its values and set values. Handle the exception if an unknown index is accessed and set.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program program = new Program();

            program[0] = "Test";

            try
            {
                program[11] = "Exception test";
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Index accessed that is out of range");
            }
        }



        private string[] Value = new string[10];

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


    }
}

