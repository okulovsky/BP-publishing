using System;

namespace Slide03
{
    public class Program
    {
        public static void MainX()
        {
            var array = new[] { 1, 2, 3 };

            //Элементы массива можно пробежать так
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            //Но лучше использовать специально предназначенный для этого оператор foreach
            foreach (var e in array)
                Console.WriteLine(e);

            //Иногда, например в случае присвоения элементов массива, foreach использовать не получается.
            for (int i = 0; i < array.Length; i++)
                array[i] = 2 * i;

            /* Общее правило по циклам такое:
             *  ИСПОЛЬЗУЙТЕ FOREACH, если это возможно
             *  ИСПОЛЬЗУЙТЕ FOR, если есть четко выделяемая переменная цикла, которая изменяется с каждой итерацией
             *  ИСПОЛЬЗУЙТЕ WHILE во всех остальных случаях
             */


        }
    }
}