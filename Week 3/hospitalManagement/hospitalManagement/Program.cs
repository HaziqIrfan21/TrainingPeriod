using System;
using System.Collections.Generic;
namespace hospitalManagement
{
    class Program
    {

        enum Condition
        {
            emergency,
            opd,
            clinical_Service
        }

        public static new List<string> patients = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Add patient");
            patients.Add(Console.ReadLine());


            //Add the enum to the patient
            Condition condition = Condition.emergency;
            Console.WriteLine(condition);

        }
    }
}
