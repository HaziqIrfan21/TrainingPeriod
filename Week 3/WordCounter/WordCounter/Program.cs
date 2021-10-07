using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string of words");
            string s = Console.ReadLine();
            Console.WriteLine("No of words: " + CountWords(s));
            Console.WriteLine("Input word search");
            string wordSearch = Console.ReadLine();
        }

        public static int CountWords(string str)
        {
            string[] words = str.Split(" ");
            return words.Length;
            
        }

        public static bool WordSearch(string sentence,string search)
        {
            string[] words = sentence.Split(" ");

            //temp holder for each word
            for (int i = 0; i < length; i++)
            {

            }

        }
    }
}
