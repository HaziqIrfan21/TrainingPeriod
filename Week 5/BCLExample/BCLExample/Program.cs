using System;
using System.Linq;

namespace BCLExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //var str1 = "this_Is_a_SAMple_SeSSION.";
            //Console.WriteLine("The string is correct format");
            //Console.WriteLine(char.ToUpper(str1[0]) + str1.Substring(1).ToLower());

            //string input = "I love to code in c#";

            //string[] arr = input.Split(' ');

            //foreach (string word in arr.Reverse())
            //{
            //    Console.Write($"{word.Substring(0, 1).ToUpper()}{word.Substring(1)}");
            //}

            //Console.ReadLine();

            //var str2 = " ";

            //if (string.IsNullOrEmpty(str2))
            //{
            //    Console.WriteLine("is null or empty");
            //}

            //if (string.IsNullOrWhiteSpace(str2))
            //{
            //    Console.WriteLine("is null or whitespace");
            //}

            //string str4 = "this is";
            //string str5 = "sample program";
            //Console.WriteLine(string.Concat(str4, str5));

            //string str6 = "//**** This is a sample string ***//";
            //char[] chartoremove = { '*', '/', ' ' };
            //var trimmedstring = str6.Trim(chartoremove);

            //DateTime dateTime = DateTime.Now;

            //Console.WriteLine(dateTime.Date);
            //Console.WriteLine(dateTime.Month);
            //Console.WriteLine(dateTime.Year);

            //Console.WriteLine(dateTime.ToShortDateString());
            //Console.WriteLine(dateTime.ToShortTimeString());

            //Console.WriteLine(dateTime.ToLongDateString());
            //Console.WriteLine(dateTime.ToLongTimeString());

            //Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));

            //Console.WriteLine(dateTime.ToString("dd-MMM-yyyy"));

            //Console.WriteLine(dateTime.ToString("dd-MMMM-yyyy"));

            //string str = "07/09/2021 23:05";

            //DateTime.TryParse(str, out DateTime datetimeObj);
            //Console.WriteLine(datetimeObj);

            //var datetimeObj1 = DateTime.Now.ToShortDateString() ;
            //var datetimeObj2 = DateTime.Now;
            //var daysInMonth = DateTime.IsLeapYear(2024);
            //Console.WriteLine(daysInMonth);

            //Console.WriteLine(DateTime.MaxValue);
            //Console.WriteLine(DateTime.MinValue);

            //Console.WriteLine(datetimeObj2);

            //if(datetimeObj1.Equals(datetimeObj2))
            //{
            //    Console.WriteLine("Both equal");
            //}
            //else
            //{
            //    Console.WriteLine("Both not  equal");
            //}

            //User take input of datetime, pars into datetime obj,
            //if successful print valid datetime, if not print invalid date time and exit
            //if valid show difference between user datetime and datetime.now

            Console.WriteLine("Input datetime obj");
            string str1 = Console.ReadLine();

           bool correct =  DateTime.TryParse(str1, out DateTime userDateTime);
            DateTime datetime2 = DateTime.Now;

            if(correct)
            {
                Console.WriteLine("Is valid");
                if(datetime2 > userDateTime)
                {
                    Console.WriteLine(datetime2 - userDateTime);
                }
                else
                {
                    Console.WriteLine(userDateTime - datetime2);
                }
            }    
            else
            {
                Console.WriteLine("Is invalid");
                return;
            }
        }
    }
}
