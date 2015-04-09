using System;

namespace Slide06
{
    class Point
    {
        public int X;
        public int Y;
        public void Print()
        {
            Console.WriteLine("{0} {1}", X, Y);
        }
        public static void PrintPoint(Point point)
        {
            Console.WriteLine("{0} {1}", point.X, point.Y);
        }
    }

    class Program
    {
        public static void MainX()
        {
            Point point = new Point { X = 1, Y = 2 };
            point.Print();
            Point.PrintPoint(point);
        }
    }

}