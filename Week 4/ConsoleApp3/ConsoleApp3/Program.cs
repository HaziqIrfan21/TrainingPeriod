using System;

namespace ConsoleApp3
{

    class Parent
    {

    }

    class child : Parent
    {
        public string someProperty { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            swap<int>(ref a, ref b);

            float c = 1.5f;
            float d = 5.5f;
            swap<float>(ref c, ref d);

            string s1 = "Something";
            string s2 = "Someone";
            swap<string>(ref s1, ref s2);

            GenericAtClassLevel();

        }

        public static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
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

        public class SampleClass<T>
        {
            T[] arrObj = new T[5];
            int count = 8;

            public void Add(T item)
            {
                if (count + 1<5)
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

        private static void GenericAtFunctionInsideAClass()
        {
            SampleClass<float> floatclass = new SampleClass<float>();
            floatclass.Add(3.14f);
            floatclass.Add(2.14f);
            floatclass.Add(4.14f);
            floatclass.Add(5.14f);
            floatclass.Add(1.14f);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(floatclass[i]);
            }

            SampleClass<int> intclass = new SampleClass<int>();
            intclass.Add(3);
            intclass.Add(2);
            intclass.Add(4);
            intclass.Add(5);
            intclass.Add(1);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intclass[i]);
            }

            SampleClass<bool> boolclass = new SampleClass<bool>();
            boolclass.Add(true);
            boolclass.Add(false);
            boolclass.Add(true);
            boolclass.Add(false);
            boolclass.Add(true);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intclass[i]);
            }
        }

        private static void GenericAtClassLevel()
        {

            //Classname<type> objectname = new class<type>();
            Device<int> intObj = new Device<int>();
            Device<float> floatObj = new Device<float>();
            Device<string> stringObj = new Device<string>();

            intObj.name = 1;
            intObj.catagory = 2;

            floatObj.name = 5.1f;
            floatObj.catagory = 3.4f;

            stringObj.name = "somename";
            stringObj.catagory = "somecatagory";

            Console.WriteLine($"The name is {intObj.name} in {intObj.catagory}");
            Console.WriteLine($"The name is {floatObj.name} in {floatObj.catagory}");
            Console.WriteLine($"The name is {stringObj.name} in {stringObj.catagory}");
        }
    }
}
