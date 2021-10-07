using System;
using System.Linq;

namespace BookIssueSystem
{
    class Program : SystemException
    {
        static void Main(string[] args)
        {
            string[] names = { "Tom", "Dick", "Harry" };

            Console.WriteLine("Enter User Name");
            string user = Console.ReadLine();

            try
            {

                if (names.Contains(user))
            {
                Console.WriteLine("Enter Book ID you wish to borrow");
            }
                }
           catch (IndexOutOfRangeException e)
            {

                // The Message property of the object
                // of type IndexOutOfRangeException
                // is used to display the type of exception
                // that has occurred to the user.
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

        }
    }
}
