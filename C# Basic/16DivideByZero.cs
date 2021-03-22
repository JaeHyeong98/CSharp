using System;

namespace Basic
{
    class 16DivideByZero
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;
            try
            {
                Console.WriteLine(x / y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
