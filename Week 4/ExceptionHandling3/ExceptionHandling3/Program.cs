using System;
using System.Collections;

namespace ExceptionHandling3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stack myStack = new Stack();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            try
            {
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("index out of range");
            }
            catch (InvalidOperationException)
            {

                Console.WriteLine("Invalid operation cannot pop when empty");
            }

        }
    }
}
