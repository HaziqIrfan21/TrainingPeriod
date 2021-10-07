using System;


namespace ConsoleApp4
{
	struct Test
	{
		public struct TestABC
		{
			public string TeachersName;
			public void Print()
			{
				Console.WriteLine(TeachersName);
			}
		}
		public string Name;
		public string Grade;
		public int Marks;
		public void Print()
		{
			Console.WriteLine(Name);
			Console.WriteLine(Grade);
			Console.WriteLine(Marks);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Test test = new Test();
			test.Name = "Nur";
			test.Grade = "A+";
			test.Marks = 95;
			test.Print();
			Test.TestABC testAbc = new Test.TestABC();
			testAbc.TeachersName = "Mithil";
			testAbc.Print();
		}
	}
}
