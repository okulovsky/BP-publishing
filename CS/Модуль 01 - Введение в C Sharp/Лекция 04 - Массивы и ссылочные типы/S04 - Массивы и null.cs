using System;

namespace Slide04
{
    public class Program
    {

        static int[] globalArray;

        public static void MainX()
        {
            //Массив, как и строка, может быть равен null
            int[] localArray = null;

            //И, соответственно, неинициализированные глобальные переменные типа массивов
            //также равны null
            if (globalArray == null)
                Console.WriteLine("GlobalArray is null");

            //Этот код вызовет NullReferenceException
            Console.WriteLine(globalArray[0]);

            var intArray=new int[10];
            //Этот код выведет 0, поскольку массив чисел инициализирован нулями
            Console.WriteLine(intArray[0].ToString());

            var stringArray = new string[10];
            //Этот код вызовет exception, поскольку массив строк инициализирован значениями null
            Console.WriteLine(stringArray[0].ToString());

            //Почему так? Есть некая фундаментальная разница между массивами и строками с одной стороны
            //и числами - с другой. 
        }
    }
}