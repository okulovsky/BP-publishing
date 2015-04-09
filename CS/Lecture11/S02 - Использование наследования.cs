using System;

namespace Slide02
{
    public class Program
    {
        static void SwapFirstElements(Array array)
        {
            object temporary = array.GetValue(0);
            array.SetValue(array.GetValue(1), 0);
            array.SetValue(temporary, 1);
        }

        static void MainX()
        {
            var strings = new string[] { "A", "B", "C" };
            SwapFirstElements(strings);
            foreach (var s in strings) Console.Write("{0} ", s);
            Console.WriteLine();
            
            var ints = new int[] { 1, 2, 3 };
            SwapFirstElements(ints);
            foreach (var e in ints) Console.Write("{0} ", e);
            Console.WriteLine();

        }
    }
}