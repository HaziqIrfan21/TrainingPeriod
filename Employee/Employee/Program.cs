using System;

namespace Employee
{
    class Program
    {
        public struct EmployeeDetails
        {
            public string Name;
            public int Age;
            public int ID;
            public int Salary;
        }

        public struct TimezoneDifference
        {
            public DateTime singaporeTime;
            public DateTime indiaTime;
            public TimeSpan singaporeOffset;
            public TimeSpan indiaOffset;

            //public struct SingaporeTime
            //{
            //    public DateTime singaporeTime;
            //}

            //public struct IndiaTime
            //{
            //    DateTime indiaTime ;
            //}


            static void Main(string[] args)
            {
                //Console.WriteLine("Hello World!");

                //Create Employees
                EmployeeDetails Tom;
                EmployeeDetails Richard;
                EmployeeDetails Harry;

                Tom.Name = "Tom";
                Tom.Age = 20;
                Tom.ID = 1;
                Tom.Salary = 2000;

                Console.WriteLine("Employee Details");
                Console.WriteLine("");
                Console.WriteLine(Tom.Name);
                Console.WriteLine(Tom.Age);
                Console.WriteLine(Tom.ID);
                Console.WriteLine(Tom.Salary);

                Console.WriteLine("");

                Richard.Name = "Richard";
                Richard.Age = 21;
                Richard.ID = 2;
                Richard.Salary = 2100;

                Console.WriteLine(Richard.Name);
                Console.WriteLine(Richard.Age);
                Console.WriteLine(Richard.ID);
                Console.WriteLine(Richard.Salary);

                Console.WriteLine("");

                Harry.Name = "Harry";
                Harry.Age = 22;
                Harry.ID = 3;
                Harry.Salary = 2200;

                Console.WriteLine(Harry.Name);
                Console.WriteLine(Harry.Age);
                Console.WriteLine(Harry.ID);
                Console.WriteLine(Harry.Salary);

                TimezoneDifference singapore;
                TimezoneDifference india;

                // Get time in local time zone 
                singapore.singaporeTime = DateTime.Now;
                Console.WriteLine("Time in {0} zone: {1}", TimeZoneInfo.Local.IsDaylightSavingTime(singapore.singaporeTime) ? TimeZoneInfo.Local.DaylightName : TimeZoneInfo.Local.StandardName, singapore.singaporeTime);
                

                // Get India Standard Time zone
                TimeZoneInfo indiaStandardTime = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
                india.indiaTime = TimeZoneInfo.ConvertTime(singapore.singaporeTime, TimeZoneInfo.Local, indiaStandardTime);
                Console.WriteLine("Time in {0} zone: {1}", indiaStandardTime.IsDaylightSavingTime(india.indiaTime) ? indiaStandardTime.DaylightName : indiaStandardTime.StandardName, india.indiaTime);


                //var singaporeTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
                //var googleplex = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

               // //var now = DateTimeOffset.UtcNow;
               //singapore.singaporeOffset = singapore.singaporeTime.GetUtcOffset();
               // TimeSpan googleplexOffset = googleplex.GetUtcOffset(now);
               // TimeSpan difference = londonOffset - googleplexOffset;
               // Console.WriteLine(difference);



            }
        }
    }
}
