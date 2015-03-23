using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide055
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

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
            Sort(new Point[] { new Point { X = 1, Y = 2 }, new Point { X = 2, Y = 1 } });
        }
    }
}