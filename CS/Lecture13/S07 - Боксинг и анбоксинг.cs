using System;

namespace Slide07
{
    struct MyStruct
    {
        public int field;
    }

    public class Program
    {
        public static void MainX()
        {
            MyStruct original;
            original.field = 10;

            object boxed = (object)original;
            MyStruct unboxed = (MyStruct)boxed;

            unboxed.field = 20;

            Console.WriteLine(original.field);
            Console.WriteLine(unboxed.field);
        }
    }
}