using MyList;
using System;

namespace Slide05
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Point)) return false;
            var point = obj as Point;
            return X == point.X && Y == point.Y;
        }
    }

    class Program
    {
        public static void MainX()
        {
            var point = new Point { X = 1, Y = 1 };

            var list = new MyList<Point>();
            //var list = new List<Point>();

            list.Add(point);
            Console.WriteLine(list.Contains(point));
            Console.WriteLine(list.Contains(new Point { X = 1, Y = 1 }));
        }
    }
}