using System;

namespace Slide01
{
    struct Point
    {
        public int X;
        public int Y;
        public void Test() { }
    }

  
public class Program
{
    static Point staticPoint;

    Point dynamicPoint;
   
    static void MainX()
    {
        Point localPoint;
        localPoint.X = 10;
        localPoint.Y = 10;

        var array = new Point[10];
        array[0].X = 10;

        staticPoint.X = 10;

        var instance = new Program();
        instance.dynamicPoint.X = 10;

            
    }
}
}