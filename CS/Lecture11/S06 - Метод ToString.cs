using System;

namespace S06
{
    class Point
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return string.Format("{0},{1}",X,Y);
        }
    }

    public class Program
    {
        static void MainX()
        {
            var point = new Point { X = 1, Y = 3 };
            Console.WriteLine(point);
        }
    }
}