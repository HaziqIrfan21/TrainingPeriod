using System;
using System.Text.RegularExpressions;
namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            //Console.WriteLine("Hello World!");

            while (loop)
            {
                Console.WriteLine("Enter password");

                var input = Console.ReadLine();
                Console.WriteLine(PasswordChecker(input));
            }
           
            //var hasNumber = new Regex(@"[0-9]+");
            //var hasUpperChar = new Regex(@"[A-Z]+");
            //var hasMinimum8CharsMax24Chars = new Regex(@".{6,24}");


        }

        public static bool PasswordChecker(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var NoRepeats = new Regex(@"[A-Za-z0-9]\{0,2} +");
            var hasMinimum8CharsMax24Chars = new Regex(@".{6,24}");
          
            //var hasNoDuplicate = new Regex(@"[A-Za-z0-9]");

            var isCorrect = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasLowerChar.IsMatch(password) && NoRepeats.IsMatch(password) && hasMinimum8CharsMax24Chars.IsMatch(password);
            if (isCorrect == true)
            {
                return true;
            }
            else
                return false;
            
        }
    }
}
