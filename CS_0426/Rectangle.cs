using System;

namespace ConsoleApp
{
    public class Rectangle
    {
        public int height;
        public int width;
        override public string ToString()
        {
            return string.Format("Width: {0}, Height: {1}", width, height);
        }
    }
}

