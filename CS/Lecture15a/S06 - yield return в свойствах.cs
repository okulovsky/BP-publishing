using System;
using System.Collections.Generic;

namespace Slide06
{
    public class Sequences
    {
        public static IEnumerable<int> Fibonacci
        {
            get
            {
                var a = 1;
                var b = 1;
                yield return 1;
                yield return 1;
                while (true)
                {
                    var c = a + b;
                    a = b;
                    b = c;
                    yield return c;
                }
            }
        }
    }

    class Program
    {
        public static void MainX()
        {
            foreach (var e in Sequences.Fibonacci)
            {
                Console.WriteLine(e);
                if (e > 1000) break;
            }
        }
    }
}