using System;

namespace Question3._1
{
    class Program
    {
        static int lottery_No;
        static void Main(string[] args)
        {
            //Console.WriteLine("Press 1 to enter the Lottery");
            //Console.ReadLine();

            
            LotteryManager lotteryManager = new LotteryManager();

            // Instantiate random number generator
            Random rand = new Random();

            //Generate Numbers
            Console.WriteLine("Printing 3 random numbers");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("{0} -> {1}", i, rand.Next());
                lottery_No = Convert.ToInt32(Console.ReadLine());
                lotteryManager[i] = lottery_No.ToString();
                //Console.WriteLine(lottery_No);
            }
            Console.WriteLine(lottery_No);





            //for (int i = 0; i < 10; i++)
            //{
            //    lottery_No = lotteryManager.GetRandNumber(); ;
            //}



            ////Assign number to customer
           
            lotteryManager[1] = lottery_No.ToString();
            lotteryManager[2] = lottery_No.ToString();

            Console.WriteLine("Lottery number = {0}", lotteryManager[0]);
            Console.WriteLine("Lottery number = {0}", lotteryManager[1]);
            Console.WriteLine("Lottery number = {0}", lotteryManager[2]);


        }
    }
}
