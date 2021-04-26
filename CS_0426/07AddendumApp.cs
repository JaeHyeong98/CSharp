using System;

namespace ConsoleApp
{
    class BaseClass
    {
        public void MethodA()
        {
            Console.WriteLine("do BaseClass Task.");
        }
    }
    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {
            base.MethodA();
            Console.WriteLine("do DerivedClass Task.");
        }
    }
    class 07AddendumApp
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.MethodA();
        }
    }
}
