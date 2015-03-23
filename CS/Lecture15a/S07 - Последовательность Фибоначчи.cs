using System;
using System.Collections.Generic;

namespace Slide07
{
    public class Sequences
    {
        public  static ExponentialSequence Exponential(int multiplier) { return new ExponentialSequence(multiplier); }
    }

    public class ExponentialSequence : IEnumerable<int>
    {
        int multiplier;

        public ExponentialSequence(int multiplier)
        {
            this.multiplier = multiplier;
        }

        public IEnumerator<int> GetEnumerator()
        {
            var a = 1;
            while (true)
            {
                yield return a;
                a *= multiplier;
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
            foreach (var e in Sequences.Exponential(2))
            {
                Console.WriteLine(e);
                if (e > 1000) break;
            }
        }
    }
}