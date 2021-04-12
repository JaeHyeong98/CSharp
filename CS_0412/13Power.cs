using System;

namespace ConsoleApp
{
    class 13Power
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
                Console.WriteLine("2 ^ {0,2} = {1, 7}", i, Power(2, i));
        }
        private static int Power(int n, int m)
        {
            int p = 1;
            for (int t = 1; t <= m; t++)
                p *= n;
            return p;
        }
    }

}
