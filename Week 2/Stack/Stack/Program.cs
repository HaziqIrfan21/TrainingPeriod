using System;
using System.Collections;

namespace StackQuestion
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create new stack
            Stack myStack = new Stack();

            //PUSH new elements into the stack
            myStack.Push("book 1");
          
            //Display element count
            Console.Write(" Amount of books are: ");

            Console.WriteLine(myStack.Count);

            //POP out books
            Console.Write(" Pop Out ");
            Console.Write(myStack.Pop());

            //PEEK at next book
            Console.WriteLine(" Peek at next book to pop {0} ", myStack.Peek());

            //Display new element count after POP
            Console.Write(" amount of book ");
            Console.WriteLine(myStack.Count);

     
            //PEEK at next book
            Console.WriteLine(" Peek at next book to pop {0}", myStack.Peek());

            //Display new element count after POP
            Console.Write(" amount of book ");
            Console.WriteLine(myStack.Count);

            //CLEAR stack
            Console.Write(" Clearing the stack ");
            myStack.Clear();

            //Display new element count after CLEAR
            Console.Write(" amount of book ");
            Console.WriteLine(myStack.Count);


        }
    }
}
