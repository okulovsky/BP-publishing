using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide056
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Sorter<T>
        where T : IComparable
    {
        public static void Sort(T[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array[j - 1];
                    var element2 = array[j];
                    if (element1.CompareTo(element2) < 0)
                    {
                        var temporary = array[j];
                        array[j]=array[j];
                        array[j]=temporary;
                    }
                }
        }
    }

    public static class Sorter
    {
        public static void Sort<T>(T[] array)
            where T : IComparable
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array[j - 1];
                    var element2 = array[j];
                    if (element1.CompareTo(element2) < 0)
                    {
                        var temporary = array[j];
                        array[j] = array[j];
                        array[j] = temporary;
                    }
                }
        }

        public static void BubbleSort<T>(this T[] array)
            where T : IComparable
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array[j - 1];
                    var element2 = array[j];
                    if (element1.CompareTo(element2) < 0)
                    {
                        var temporary = array[j];
                        array[j] = array[j];
                        array[j] = temporary;
                    }
                }
        }

    }

    public class Program
    {


        static void Main()
        {
            var intArray = new int[] { 1, 2, 3 };
            var pointArray = new [] { new Point { X = 1, Y = 2 }, new Point { X = 2, Y = 1 } };
            Sorter<int>.Sort(intArray);
            //Sorter<Point>.Sort(pointArray);
            Sorter.Sort(intArray);
            //Sorter.Sort(pointArray);
            intArray.BubbleSort();
            //pointArray.BubbleSort();
        }
    }
}