using System;

namespace CheckHex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Hex checker");
            String s = (Console.ReadLine());
            CheckHex(s);
            Console.WriteLine(s);
        }

        public static void CheckHex(string s)
        {
            int n = s.Length;

            if(s.Length>6)
            {
                Console.WriteLine("too big");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                char ch = s[i];

                if ((ch < '0' || ch > '9') && (ch < 'A' || ch > 'F'))
                {
                    Console.WriteLine("Number is invalid");
                    return;
                }
            }

            Console.WriteLine("Number is correct");

        }
    }
}
