using System;

namespace Slide02
{
    public class Program
    {
        static void Make(int n)
        {
            for (int i = n-1; i >=0; i--)
            {
                Console.Write(i.ToString() + " ");
                Make(i);
            }
        }

        public static void Main()
        {
            Console.Write("Make(1): ");
            Make(1);
            Console.WriteLine();

            Console.Write("Make(2): ");
            Make(2);
            Console.WriteLine();

            Console.Write("Make(3): ");
            Make(6);
            Console.WriteLine();
        }
    }
}