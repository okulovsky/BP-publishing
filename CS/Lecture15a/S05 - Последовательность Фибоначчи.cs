using System;
using System.Collections.Generic;

namespace Slide05
{
    public class Sequences
    {
        public  static FibonacciSequence Fibonacci { get { return new FibonacciSequence(); } }
    }

    public class FibonacciSequence : IEnumerable<int>
    {

        public IEnumerator<int> GetEnumerator()
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

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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