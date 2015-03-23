using System;

namespace Slide04
{
    struct PointStruct
    {
        public int X;
        public int Y;
    }

    class PointClass
    {
        public int X;
        public int Y;
    }

    public class Program
    {
        static void ProcessStruct(PointStruct point)
        {
            point.X = 10;
        }
        static void ProcessClass(PointClass point)
        {
            point.X = 10;
        }
        public static void MainX()
        {
            var pointStruct = new PointStruct();
            ProcessStruct(pointStruct);
            Console.WriteLine(pointStruct.X);

            var pointClass = new PointClass();
            ProcessClass(pointClass);
            Console.WriteLine(pointClass.X);
        }
    }
}