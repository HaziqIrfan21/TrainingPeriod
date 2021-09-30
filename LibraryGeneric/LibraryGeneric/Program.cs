using System;

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
            GenericAtClassLevel();

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


        }

        private static void StudentIDFunction()
        {
            StudentClass<int> intclass = new StudentClass<int>();
            intclass[0] = 1;
            intclass[1] = 2;
            intclass[2] = 3;
            intclass[3] = 4;
            intclass[4] = 5;

            Console.WriteLine("Insert Student ID");
            int studentID = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine(intclass[i]);
                int temp = intclass[i];

                if (temp == studentID)
                {
                    Console.WriteLine("Give book");
                    Console.WriteLine("Your student ID : " + studentID);
                }


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

        public class Worker<T>
        {
            public T name { get; set; }

            public T Salary { get; set; }
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
            double proSalary = workerDouble.Salary;
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

            double FinalSalary = PostSalary + proSalary;
            workerDouble.Salary = FinalSalary;
            Console.WriteLine($"The name is {workerString.name} with salary of {workerDouble.Salary}");

        }

    }

    



}
