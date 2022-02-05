using System;

namespace Task3
{
    internal class MyClass
    {
        public string change;
    }

    internal struct MyStruct
    {
        public string change;
    }

    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Changed";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Changed";
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "Not changed";
            MyStruct myStruct = new MyStruct();
            myStruct.change = "Not changed";
            Console.WriteLine("1: ");
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            ClassTaker(myClass); // will change fields of class instance, passed by reference
            StructTaker(myStruct); // no changes in myStruct instance as values copied by values

            Console.WriteLine("2: ");
            Console.WriteLine($"{myClass.GetType().Name} -> {myClass.change}");
            Console.WriteLine($"{myStruct.GetType().Name} -> {myStruct.change}");

        }
    }
}
