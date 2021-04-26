using System;

namespace ConsoleApp
{
    class CLanguage
    {
        virtual public void Print()
        {
            Console.WriteLine("In the Clanguage class ...");
        }
    }
    class Java : CLanguage
    {
        override public void Print()
        {
            Console.WriteLine("In the Java class ...");
        }
    }
    class 09VirtualAndOverrideApp
    {
        static void Main(string[] args)
        {
            CLanguage c = new Java();
            c.Print();
        }
    }
}
