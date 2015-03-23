using System;
namespace Slide05
{
    public class MyClass
    {
        public int classField;
    }

    public struct MyStruct
    {
        public MyClass myObject;
    }

    public class Program
    {
        public static void ProcessStruct(MyStruct str)
        {
            str.myObject.classField = 10;
        }

        public static void MainX()
        {
            var str = new MyStruct();
            str.myObject = new MyClass();
            ProcessStruct(str);
            Console.WriteLine(str.myObject.classField);
        }
    }
}