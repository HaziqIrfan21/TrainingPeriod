using System;

namespace ExampleQn
{
    class Program 
    {
       

        static void Main(string[] args)
        {

            Calculator calcDele = new Calculator();



          
            while (true)
            {


                Console.Write("Enter interest Input");
                int interest = int.Parse(Console.ReadLine());
                calcDele.Interest(interest);

                Console.Write("Enter principle Input");
                int principle = int.Parse(Console.ReadLine());
                calcDele.Principle(principle);

                Console.Write("Enter timerRange Input");
                int timerRange = int.Parse(Console.ReadLine());
                calcDele.TimerRange(timerRange);

                calcDele.calc_SimpleInterest(interest, principle, timerRange);






                //ExcepetionHandler(a, b);



            }

            static void ExcepetionHandler(int a, int b)
            {
                while (true)
                {
                    try
                    {

                        Console.WriteLine(a * b);
                        Console.WriteLine(a / b);
                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine("Wrong Input format");
                    }
                    catch (DivideByZeroException ex)
                    {

                        Console.WriteLine("Cannot divide by 0");
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("some other exception occured");
                    }
                    finally
                    {

                        Console.WriteLine("Finally, closing program");
                        Console.ReadLine();
                    }
                }
            }
        }

       

            
    }
}
