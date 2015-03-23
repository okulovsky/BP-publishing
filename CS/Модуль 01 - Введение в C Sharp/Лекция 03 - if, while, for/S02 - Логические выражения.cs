using System;

namespace Slide02
{
    public class Program
    {
        public static void Main()
        {
            // Операция "И", или конъюнкция
            Console.WriteLine((5 < 4) && (3 < 4));

            // Операция "ИЛИ", или дизъюнкция
            Console.WriteLine((5 < 4) || (3 < 4));

            // Операция "НЕ", или отрицание
            Console.WriteLine(!(5 < 4));
        }
    }
}