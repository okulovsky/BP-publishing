using System;
using System.Collections.Generic;
using System.Linq;

namespace Slide07
{
    public class Student
    {
        public string LastName { get; set; }
        public string Group { get; set; }
    }

    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> enumerable, Func<T,bool> predicate)
        {
            foreach (var e in enumerable)
                if (predicate(e))
                    yield return e;
        }

        public static IEnumerable<TOut> Select<TIn, TOut>(this IEnumerable<TIn> enumerable, Func<TIn, TOut> selector)
        {
            foreach (var e in enumerable)
                yield return selector(e);
        }

        public static List<T> ToList<T>(this IEnumerable<T> enumerable)
        {
            var list = new List<T>();
            foreach (var e in enumerable)
                list.Add(e);
            return list;
        }

        public static void Print<T>(this IEnumerable<T> enumerable)
        {
            foreach (var e in enumerable)
                Console.WriteLine(e);
        }
    }


    public class Program
    {
        public static void MainX()
        {
            var students = new List<Student>
            {
                new Student { LastName="Jones", Group="FT-1" },
                new Student { LastName="Adams", Group="FT-1" },
                new Student { LastName="Williams", Group="KN-1"},
                new Student { LastName="Brown", Group="KN-1"}
            };

            //или
            var result = students.Where(z => z.Group == "KN-1").Select(z => z.LastName).ToList();
            students.Where(z => z.Group == "FT-1").Select(z => z.LastName).Print();

            //видеофрагменты:
            // - пишем методы
            // - проходим отладчиком, демонстрируя принцип "изнутри наружу"
            // - демонстрируем ленивость
            // - и дальше миникурс по LINQ
              
        }
    }
}