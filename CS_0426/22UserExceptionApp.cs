using System;

namespace ConsoleApp
{
    class UserErrException : ApplicationException
    {
        public UserErrException(string s) : base(s) { }
    }
    class 22UserExceptionApp
    {
        public static void Main()
        {
            try
            {
                throw new UserErrException("throw a exception with a message");
            }
            catch (UserErrException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}

