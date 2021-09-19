using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Employee
    {
        //private string name;
        //private int yearOfJoining;
        //private int salary;

        struct employee
        {
            public string name;
            public record records;
        }

        struct record
        {
            public int salary;
            public int YearOfJoining;

        }

        //public string Name
        //{
        //    get => name;
        //    set => name = value;
        //}

        //public int YearOfJoining
        //{
        //    get => yearOfJoining;
        //    set => yearOfJoining = value;
        //}

        //public int Salary
        //{
        //    get => salary;
        //    set => salary = value;
        //}

        static void Main(string[] args)
        {
            int totalEmployees;
            Console.WriteLine("amount of employees");
            totalEmployees = Convert.ToInt32(Console.ReadLine());


            employee[] employees = new employee[totalEmployees];

            for (int i = 0; i < totalEmployees; i++)
            {

                //Name of employees
                Console.WriteLine("Name of employees");
                string name = Console.ReadLine();
                employees[i].name = name;

                //Salary of employees

                Console.WriteLine("Salary of employees");
                int salary = Convert.ToInt32(Console.ReadLine());
                employees[i].records.salary = salary;

                //Year of employees

                Console.WriteLine("Year Joined");
                int Joined = Convert.ToInt32(Console.ReadLine());
                employees[i].records.YearOfJoining = Joined;

                Console.WriteLine("Full employee record " + name +" " + salary + " " +Joined);
            }



        }

    }
}
