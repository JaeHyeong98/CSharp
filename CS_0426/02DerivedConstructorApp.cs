using System;

namespace ConsoleApp
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass Constructor ...");
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("DerivedClass Constructor ...");
        }
    }
    class 02DerivedConstructorApp
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            Console.WriteLine("In the main ...");
        }
    }


}