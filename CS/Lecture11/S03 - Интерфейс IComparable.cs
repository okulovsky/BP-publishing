using System;

namespace S03
{


    public class Program
    {
        public static void Sort(Array array)
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    object element1 = array.GetValue(j - 1);
                    object element2 = array.GetValue(j);
                    IComparable comparableElement1 = element1 as IComparable;
                    if (comparableElement1.CompareTo(element2) < 0)
                    {
                        object temporary = array.GetValue(j);
                        array.SetValue(array.GetValue(j - 1), j);
                        array.SetValue(temporary, j - 1);
                    }
                }
        }

        static void MainX()
        {
            Sort(new int[] { 1, 2, 3 });
            Sort(new string[] { "A", "B", "C" });
            Sort(new[]
            {
                new Point { X=1, Y=1},
                new Point { X=2, Y=2}
            });
        }
    }

    public class Point : IComparable
    {
        public double X;
        public double Y;

        public int CompareTo(object obj)
        {
            var point = obj as Point;
            var thisDistance = Math.Sqrt(X * X + Y * Y);
            var thatDistance = Math.Sqrt(point.X * point.X + point.Y * point.Y);
            return thisDistance.CompareTo(thatDistance);
            //или
            //if (thisDistance < thatDistance) return -1;
            //else if (thisDistance == thatDistance) return 0;
            //else return 1;
        }
    }



}