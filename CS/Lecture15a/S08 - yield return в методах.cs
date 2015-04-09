using System;
using System.Collections.Generic;

namespace Slide08
{
    public class Sequences
    {
        public static IEnumerable<int> Exponential(int multiplier)
        {
            var a = 1;

            while (true)
            {
                yield return a;
                a *= multiplier;
            }
        }
    }

    class Program
    {
        public static void MainX()
        {
            foreach (var e in Sequences.Exponential(3))
            {
                Console.WriteLine(e);
                if (e > 1000) break;
            }
        }
    }
}