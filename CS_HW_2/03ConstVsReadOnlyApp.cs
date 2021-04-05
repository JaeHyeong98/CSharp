using System;

namespace ConsoleApp1
{
   public class Color
    {
        public const int FULL = 0xFF;   //constant member
        public const int EMPTY = 0x00;  //constant member
        private byte red, green, blue;
        //readonly Fileds
        public static readonly Color Red = new Color(FULL, EMPTY, EMPTY);
        public static readonly Color Green = new Color(EMPTY, FULL, EMPTY);
        public static readonly Color Blue = new Color(EMPTY, EMPTY, FULL);
        public Color(byte r, byte g, byte b)
        {   //constructor
            red = r;
            green = g;
            blue = b;
        }
        public static void PrintColor(Color C)
        { //method
            Console.WriteLine("red value={0}, green value={1}, blue value={2}", C.red, C.green, C.blue);
        }
    }

    
    class 03ConstVsReadOnlyApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FULL = "+ Color.FULL);
            Color.PrintColor(Color.Red);
        }
    }
}
