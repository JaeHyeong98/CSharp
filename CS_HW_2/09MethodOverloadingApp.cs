using System;

namespace ConsoleApp1
{
    class MethodOverloading
    {
        public void SomeThing()
        {
            Console.WriteLine("SomeThing() is called.");
        }
        public void SomeThing(int i)
        {
            Console.WriteLine("Something(int) is called.");
        }
        public void SomeThing(int i, int j)
        {
            Console.WriteLine("SomeThing(int,int) is called.");
        }
        public void SomeThing(double d)
        {
            Console.WriteLine("SomeThing(double) is called.");
        }


    }
    class 09MethodOverloadingApp
    {
        static void Main(string[] args)
        {
            MethodOverloading obj = new MethodOverloading();
            obj.SomeThing();
            obj.SomeThing(526);
            obj.SomeThing(54, 526);
            obj.SomeThing(5.26);
        }
    }
}
