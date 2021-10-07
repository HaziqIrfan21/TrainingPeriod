using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace LibraryGeneric
{
    class Program
    {
        //write a program to issue a book from library, to enter the library you need to be a student of the class
        // (need to verify using some roll no etc.) but you can only issue one book at a time.
        //give the details of student after the book is issued. * Use exception handling to show the error message use generic class


        static void Main(string[] args)
        {
            StudentClass<int> studentClass = new StudentClass<int>();

            StudentIDFunction();
            //GenericAtClassLevel();

            //Call salary function
            //InitThread();

            //for (int i = 0; i < studentClass[i]; i++)
            //{
            //    if (studentClass[i] == studentID)
            //    {
            //        Console.WriteLine("Give book");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Invalid ID");
            //    }
            //}

            //Shape Functions
            //TriangleInitThread();
            //AlphabetInitThread();

            bool isActive = true;

            

            //while (true)
            //{
            //    Console.WriteLine("Choose Option");
            //    Console.WriteLine("Press 1 for Add");
            //    Console.WriteLine("Press 2 for delete");
            //    int input = int.Parse(Console.ReadLine());

            //    switch (input)
            //    {
            //        case 1:
            //            Spawner.AddNames();
            //            break;
            //        case 2:
            //            Spawner.DeleteNames();
            //            break;
            //        default:
            //            break;
            //    }
            //}
            

          

           

        }

        private static void StudentIDFunction()
        {
            StudentClass<int> intclass = new StudentClass<int>();
            int temp;
            //intclass.Add(1);
            intclass.Add(1);
            intclass.Add(2);
            intclass.Add(3);
            intclass.Add(4);
            intclass.Add(5);

            Console.WriteLine("Insert Student ID");
            int studentID = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine(intclass[i]);
                temp = intclass[i];

                if (temp == studentID)
                {
                    Console.WriteLine("Give book");
                    Console.WriteLine("Your student ID : " + studentID);
                }
                else if(temp!= studentID)
                    Console.WriteLine("Invalid ID");
            }
           

        }

        public class StudentClass<T>
        {
            T[] arrObj = new T[5];
            int count = 8;

            public void Add(T item)
            {
                if (count + 1 < 5)
                {
                    arrObj[count] = item;
                }
                count++;
            }

            public T this[int index]
            {
                get { return arrObj[index]; }
                set { arrObj[index] = value; }
            }

        }

        public class Device<T> // T: child
        {
            public T name { get; set; }

            public T catagory { get; set; }

            //public void getProperty()
            //{
            //    catagory.someProperty = "something";
            //}

        }

        //Suppose you are working in an MNC.
        //after your joining there will be a probation period of 6 months,
        //in this period you are drawing only 80% of your monthly salary.
        //after that you will get the full salary.
        //Every month from your salary you have
        //1. 12% tax
        //2. 8% to provident fund after paying the tax
        //3. 5% to health insurance after paying PF              
        //4. 7% to Mutual Funds after paying Health insurance.
        //* Now calculate the total amount of money you will get after all these investments in a year.
        //use exception handling to show the error msg. and create  generic class to store the data
        
        public class BasicEmployee
        {
            public string Name { get; set; }
            public double Salary { get; set; }
        }

        public class Manager : BasicEmployee
        {
            public double companyshares { get; set; }
        }

        public class HROps : BasicEmployee
        {
            public double Incentive { get; set; }
        }

        public class EmployeeManager<T> where T: BasicEmployee
        {
            public int CalculateTax(T obj)
            {
                return 0;
            }

            public int CalculatePf(T obj)
            {
                return 0;
            }
        }
        public class Worker<T>
        {
            public T name { get; set; }

            public T Salary { get; set; }

            public T ProSalary { get; set; }
        }
        private static void GenericAtClassLevel()
        {
            Worker<double> workerDouble = new Worker<double>();
            Worker<string> workerString = new Worker<string>();


            workerString.name = "Thomas";
            workerDouble.Salary = 3000;


            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary = 3000 * 0.8;
            double temp = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");


            workerDouble.Salary -= temp * 0.12;
            temp = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.08;
            temp = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.05;
            temp = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.07;
            temp = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary = temp * 6;
            temp = workerDouble.Salary;
            double ProSalary = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");
            //--------------------------------------------------//


            workerDouble.Salary = 3000;
            temp = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.12;
            temp = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.08;
            temp = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.05;
            temp = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.07;
            temp = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary = temp * 6;
            temp = workerDouble.Salary;
            double PostSalary = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            double FinalSalary = PostSalary + ProSalary;
            workerDouble.Salary = FinalSalary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

        }

        public static void InitThread()
        {
            Thread t = new Thread((x) => { Display(); });
            // ThreadStart start = new ThreadStart(Display);
            Thread t1 = new Thread((x) => { Display2(); });

            Thread t2 = new Thread((x) => { Display3(); });


            t.Start();
            t1.Start();
            t2.Start();
            //for (int i = 0; i < 3; i++)
            //{
            //    Thread.Sleep(5000);
            //    if (i == 3)
            //        t2.Join();
            //    //Console.WriteLine("I am in main thread");
            //}
            Console.ReadLine();
        }



        public static double Display()
        {
            Worker<double> workerDouble = new Worker<double>();
            Worker<string> workerString = new Worker<string>();
            Worker<double> workerProSalary = new Worker<double>();

            workerString.name = "Thomas";
            workerDouble.Salary = 3000;
            workerProSalary.ProSalary = 0;

            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary = 3000 * 0.8;
            double temp = workerDouble.Salary;
            // Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");


            workerDouble.Salary -= temp * 0.12;
            temp = workerDouble.Salary;
            // Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.08;
            temp = workerDouble.Salary;
            // Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.05;
            temp = workerDouble.Salary;
            // Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.07;
            temp = workerDouble.Salary;
            // Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary = temp * 6;
            temp = workerDouble.Salary;
            double proSalary = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with probation salary of {workerDouble.Salary}");

            return proSalary;
        }

        public static double Display2()
        {
            Worker<double> workerDouble = new Worker<double>();
            Worker<string> workerString = new Worker<string>();

            workerString.name = "Thomas";
            workerDouble.Salary = 3000;

            workerDouble.Salary = 3000;
            double temp = workerDouble.Salary;
            // Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.12;
            temp = workerDouble.Salary;
            // Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.08;
            temp = workerDouble.Salary;
            // Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.05;
            temp = workerDouble.Salary;
            // Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary -= temp * 0.07;
            temp = workerDouble.Salary;
            // Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

            workerDouble.Salary = temp * 6;
            temp = workerDouble.Salary;
            double PostSalary = workerDouble.Salary;
            Console.WriteLine($"The name is {workerString.name} with Post-Probation salary of {workerDouble.Salary}");
            return PostSalary;
        }

        public static void Display3()
        {
            Worker<double> workerDouble = new Worker<double>();
            Worker<string> workerString = new Worker<string>();

            double FinalSalary = Display() + Display2();
            workerDouble.Salary = FinalSalary;
            Console.WriteLine($"The name is {workerString.name} with final salary of {workerDouble.Salary}");
        }

        public static void TriangleInitThread()
        {
            Thread t = new Thread((x) => { Display4(); });
            Thread t1 = new Thread((x) => { Display5(); });
            Thread t2 = new Thread((x) => { Display6(); });
            Thread t3 = new Thread((x) => { Display7(); });
            Thread t4 = new Thread((x) => { Display8(); });
            Thread t5 = new Thread((x) => { Display9(); });
            Thread t6 = new Thread((x) => { Display10(); });
            Thread t7 = new Thread((x) => { Display11(); });
            Thread t8 = new Thread((x) => { Display12(); });


            t.Start();
            Thread.Sleep(1000);
            t1.Start();
            Thread.Sleep(1000);
            t2.Start();
            Thread.Sleep(1000);
            t3.Start();
            Thread.Sleep(1000);
            t4.Start();
            Thread.Sleep(1000);
            t5.Start();
            Thread.Sleep(1000);
            t6.Start();
            Thread.Sleep(1000);
            t7.Start();
            Thread.Sleep(1000);
            t8.Start();
        }

        public static void Display4()
        {
            Console.WriteLine("1");

        }
        public static void Display5()
        {
            Console.WriteLine("1 1");
        }
        public static void Display6()
        {
            Console.WriteLine("1 1 2");
        }
        public static void Display7()
        {
            Console.WriteLine("1 1 2 3");
        }
        public static void Display8()
        {
            Console.WriteLine("1 1 2 3 5");
        }
        public static void Display9()
        {
            Console.WriteLine("1 1 2 3 5 8");
        }
        public static void Display10()
        {
            Console.WriteLine("1 1 2 3 5 8 13");
        }
        public static void Display11()
        {
            Console.WriteLine("1 1 2 3 5 8 13 21");
        }
        public static void Display12()
        {
            Console.WriteLine("1 1 2 3 5 8 13 21 34");
        }
        public static void AlphabetInitThread()
        {
            Thread t = new Thread((x) => { Display13(); });
            Thread t1 = new Thread((x) => { Display14(); });
            Thread t2 = new Thread((x) => { Display15(); });
            Thread t3 = new Thread((x) => { Display16(); });
            Thread t4 = new Thread((x) => { Display17(); });



            t.Start();
            Thread.Sleep(1000);
            t1.Start();
            Thread.Sleep(1000);
            t2.Start();
            Thread.Sleep(1000);
            t3.Start();
            Thread.Sleep(1000);
            t4.Start();

        }
        public static void Display13()
        {
            Console.WriteLine("    A");
        }
        public static void Display14()
        {
            Console.WriteLine("   ABA");
        }
        public static void Display15()
        {
            Console.WriteLine("  ABCBA");
        }
        public static void Display16()
        {
            Console.WriteLine(" ABCDCBA");
        }
        public static void Display17()
        {
            Console.WriteLine("ABCDEBCBA");
        }
        //Write a program which operate on a List and Does addition and Removal.
        //It can be any List with any particular type.
        //You have to spawn threads depending on user inputs which can add and remove from the original List.


        public class Spawner
        {
            public List<string> names = new List<string>();
               

            public static void AddNames()
            {
                Spawner spawn = new Spawner();


                spawn.names.Add("Thomas");
                spawn.names.Add("Richard");
                spawn.names.Add("Henry");
                Console.WriteLine("Type name you wish to Add");
                string newName = Console.ReadLine();
                spawn.names.Add(newName);

                foreach (string element in spawn.names)
                {
                    Console.WriteLine(element);
                }

            }

            public static void DeleteNames()
            {
                Spawner spawn = new Spawner();

                Console.Write("Type name you wish to remove");
                string removeName = Console.ReadLine();
                spawn.names.Remove(removeName);

                foreach (string element in spawn.names)
                {
                    Console.WriteLine(element);
                }

            }


        }


    }





}
