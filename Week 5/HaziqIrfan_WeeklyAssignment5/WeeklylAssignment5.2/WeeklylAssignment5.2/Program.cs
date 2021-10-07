using System;
using System.Linq;
using System.Collections.Generic;
namespace WeeklylAssignment5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert First int");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert Second int");
            int b = int.Parse(Console.ReadLine());
            Overloading overloading = new Overloading();

            overloading.Add(a, b);

            Console.WriteLine("Insert First string");
            string c = Console.ReadLine();
            Console.WriteLine("Insert Second string");
            string d = Console.ReadLine();

            overloading.Add(c, d);

            Console.WriteLine("Insert First string");
            List<int> firstString = new List<int>() {int.Parse(Console.ReadLine())};
            Console.WriteLine("Insert Second string");
            List<int> secondString = new List<int>() { int.Parse(Console.ReadLine())};

            
            //Console.WriteLine(overloading.Add(firstString,secondString));



        }

        public class Overloading

        {
            public int Add (int a, int b)
            {
                //   Console.WriteLine( a+ b);
                var result = a + b;
                return result;
            }

            public string Add(string a, string b)
            {
                string result = a + " " + b;
                //Console.WriteLine(result);
                return result;
            }
           
            public List<string> Add(List<string>a,List<string>b)
            {
                // Console.WriteLine(a.Concat(b).ToList());
                var result = a.Concat(b).ToList();
                return result;
            }
        }



        
    }
   
}
