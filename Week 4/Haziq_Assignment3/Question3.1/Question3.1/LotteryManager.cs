using System;
using System.Collections.Generic;
using System.Text;

namespace Question3._1
{
    class LotteryManager
    {
        int number;

        private string[] Customers = new string[5];

        public string this[int index]
        {
            get
            {
                return Customers[index];
            }

            set
            {
                Customers[index] = value;
            }
        }
        public void SelectWinner()
        {
           
        }

        //public int GetRandNumber()
        //{
        //    Random rand = new Random();

        //    Console.WriteLine("Generate Lottery number");
        //    for (int i = 0; i < 1; i++)
        //    {
        //        Console.WriteLine("Your number is : " + "{1}", i, rand.Next());
        //        number = Convert.ToInt32(Console.ReadLine());

        //    }
        //    return number;
        //}


    }
}



