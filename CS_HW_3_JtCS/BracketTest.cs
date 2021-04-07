using System;

namespace JavaToCshap_HW
{
    class BracketTest
    {
		public static void Main(String[] args)
		{
			OptExp opt = new OptExp();
			String exp = "(3*5)-6/2)";

            Console.WriteLine(exp);

			if (opt.testPair(exp))
                Console.WriteLine("괄호 맞음!!");
			else
                Console.WriteLine("괄호 틀림!!");
		}
	}
}
