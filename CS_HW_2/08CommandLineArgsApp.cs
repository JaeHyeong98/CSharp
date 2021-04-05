using System;

namespace ConsoleApp1
{
    class 08CommandLineArgsApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
                Console.WriteLine("Argument[{0}] = {1}", i, args[i]);
        }
    }
}
