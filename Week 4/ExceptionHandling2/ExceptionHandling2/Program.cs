using System;
using System.IO;
using System.Text;


namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            //program.CreateDirectory();

            program.CreateFile();

        }

        public void CreateDirectory()
        {
            Console.WriteLine("Enter name of the new directory");

            string DirName = Console.ReadLine();

            if (DirName != string.Empty)
            {
                Directory.CreateDirectory(DirName);

                if (Directory.Exists(DirName))
                {
                    Console.WriteLine("The directory was created");
                    Console.ReadKey();
                }
            }
        }

        public void CreateFile()
        {
            string file_path = @"file.txt";

            try
            {
                using(FileStream fs = File.Create(file_path))
                {
                    byte[] textString = new UTF8Encoding(true).GetBytes("Test string");
                    fs.Write(textString, 0, textString.Length);
                }

                using (StreamReader sr = File.OpenText(file_path))
                {
                    string s = "";

                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            
            catch (ArgumentException ex)
            {

                Console.WriteLine("path is empty");
            }
            catch (UnauthorizedAccessException ex)
            {

                Console.WriteLine("You do not have the required position");
            }
            catch (DirectoryNotFoundException ex)
            {

                Console.WriteLine("The given path is invalid");
            }
        }
    }
}
