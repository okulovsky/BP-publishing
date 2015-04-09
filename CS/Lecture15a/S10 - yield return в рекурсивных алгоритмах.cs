using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide10
{

    public class Program
    {
        static int[] weights = new int[] { 2, 3, 5 };

        static void Evaluate(bool[] subset)
        {
            var delta = 0;
            for (int i = 0; i < subset.Length; i++)
                if (subset[i]) delta += weights[i];
                else delta -= weights[i];
            foreach (var e in subset)
                Console.Write(e ? 1 : 0);
            Console.Write(" ");
            if (delta == 0)
                Console.Write("OK");
            Console.WriteLine();
        }

        static IEnumerable<bool[]> MakeSubsets(bool[] subset, int position)
        {
            if (position == subset.Length)
            {
                yield return subset; //будет возвращать всегда один и тот же массив, заполненный разными числами
                //yield return subset.ToArray(); //будет возвращать разные массивы
                yield break;
            }
            subset[position] = false;
            foreach (var e in MakeSubsets(subset, position + 1))
                yield return e;
            subset[position] = true;
            foreach (var e in MakeSubsets(subset, position + 1))
                yield return e;
        }

        static void Main()
        {
            foreach (var subset in MakeSubsets(new bool[weights.Length], 0))
            {
                foreach (var e in subset)
                    Console.Write(e ? 1 : 0);
                Console.WriteLine();
            }

            foreach (var subset in MakeSubsets(new bool[weights.Length], 0))
            {
                Evaluate(subset);
            }


        }
    }
}