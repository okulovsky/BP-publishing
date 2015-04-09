using System;

namespace Slide01
{
    public class Program
    {
        public static void Main()
        {
            //Здесь мы объявляем переменную array, точно также, как раньше объявляли переменные других типов.
            //Тип массива чисел - это int[]. Аналогично, есть типы string[], double[], и т.д.
            int[] array;
            int number;

            //Здесь мы инициализируем переменную array значением "new int[3]" - новый массив длины 3. 
            array = new int[3];
            number = 10;

            //Обращение к элементам массива
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            //Массив, как и остальные типы, имеет собственные свойства и методы
            Console.WriteLine(array.Length); //Выведет 3


            //Обратите внимание, что array.ToString() работает не так, как хотелось бы.
            Console.WriteLine(array.ToString()); //Выведет System.Int32[]

            //Этот код вызовет exception - выход за границы массива
            Console.WriteLine(array[100]);

        }
    }
}