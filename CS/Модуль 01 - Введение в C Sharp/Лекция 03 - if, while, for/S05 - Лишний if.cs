using System;

namespace Slide05
{

    public class Program
    {
        //Часто встречающиеся стилевые ошибки

        //Допустим, вы решили написать метод, возвращающий отрицание переменной
        static bool Negate(bool argument)
        {
            return !argument;
            // так правильно

            /*
             * if (argument) return false;
             * else return true;
             * - а так - нет.
             */
        }

        //Или метод, сравнивающий два значения
        static bool Compare(int arg1, int arg2)
        {
            return arg1 < arg2;
            //так правильно

            /*
             * if (arg1<arg2) return true;
             * else return false;
             * - а так - нет
             */


        }
        
    }
}