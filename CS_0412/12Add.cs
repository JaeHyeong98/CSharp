using System;

namespace ConsoleApp
{
    class 12Add
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1~100까지의 합: {0,8}", Add(1, 100));
            Console.WriteLine("101~200까지의 합: {0,8}", Add(101, 200));
        }
        private static int Add(int v1, int v2)
        {
            int sum = 0;
            for (int i = v1; i <= v2; i++)
                sum += i;
            return sum;
        }
    }

}
