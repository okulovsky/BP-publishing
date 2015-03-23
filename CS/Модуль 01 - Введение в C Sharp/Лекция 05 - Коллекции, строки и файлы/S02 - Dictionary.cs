using System;
using System.Collections.Generic;

namespace Slide02
{
    public class Program
    {
        static void MainX()
        {
            // Массивы и листы позволяют нам установить соответствие между числом 
            // (индексом массива) и чем-то: например, массив string[] по числу дает доступ
            // к строке.
            // Иногда хочется установить, например, соответствие между строкой и числом.

            // Задача: дан массив строк, подсчитать для каждой строки количество вхождений

            var array = new[] { "A", "AB", "B", "A", "B", "B" };

            //Удобно делать это с помощью словаря - сущности, которая ассоциирует между собой
            //значения любых типов
            var dictionary = new Dictionary<string, int>();

            foreach (var e in array)
            {
                if (!dictionary.ContainsKey(e)) dictionary[e] = 0;
                dictionary[e]++;
            }

            foreach (var e in dictionary)
            {
                Console.WriteLine(e.Key + "\t" + e.Value);
            }

        }
    }
}