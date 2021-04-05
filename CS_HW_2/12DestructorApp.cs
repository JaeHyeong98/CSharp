using System;

namespace ConsoleApp1
{
    class Destructor
    {
        public Destructor()
        { // 생성자
            Console.WriteLine("In the constructor ...");
        }
        ~Destructor()
        { // 소멸자
            Console.WriteLine("In the destructor ...");
        }
    }

    class 12DestructorApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            Destructor d = new Destructor();
            Console.WriteLine("End of Main");

        }
    }
}
