using System;

namespace Slide01
{
    public class Program
    {

        public static void MainX()
        {
            //Сравнение, как и операции сложения или деления, тоже имеет возвращаемое значение
            Console.WriteLine(5 < 4);

            // И его можно сохранить в переменную логического типа
            // Это тип, абсолютно равноправный с int, double и другими 
            bool comparisonResult = 6 > 7;
            Console.WriteLine(comparisonResult);

            //Константы истины и лжи
            bool trueValue=true;
            bool falseValue=false;



            //Все операции сравнения
            Console.WriteLine(5 == 6);
            Console.WriteLine(5 != 6);
            Console.WriteLine(5 < 5);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 > 5);
            Console.WriteLine(5 >= 5);


        }

    }
}