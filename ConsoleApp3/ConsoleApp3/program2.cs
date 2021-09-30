using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    public interface IMyGenericInterface<T>
    {

        void Dosomething(T a, T b);

        T DoSomethingElse(T a, T b);


    }

    public class MyGenericClass : IMyGenericInterface<int>

    {
        public void Dosomething(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int DoSomethingElse(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

    public class MyGenericClass1<T> : IMyGenericInterface<T>

    {
        public void Dosomething(T a, T b)
        {
            throw new NotImplementedException();
        }

        public T DoSomethingElse(T a, T b)
        {
            throw new NotImplementedException();
        }
    }
    class program2
    {
        

        public void creategenerictypes()
        {
            MyGenericClass mygenericclass = new MyGenericClass();
            mygenericclass.Dosomething(1, 1);


            MyGenericClass1<int> mygenericclass1 = new MyGenericClass1<int>();
            mygenericclass1.Dosomething(1, 1);

            MyGenericClass1<string> mygenericclass2 = new MyGenericClass1<string>();
            mygenericclass2.Dosomething("hello","goodbye");

        }
        
    }
}
