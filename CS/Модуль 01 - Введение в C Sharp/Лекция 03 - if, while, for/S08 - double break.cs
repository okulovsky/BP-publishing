using System;

namespace Slide08
{
    public class Program
    {
        public static void MainX()
        {
            //Для выхода из вложенного цикла приходится использовать
            //конструкцию "double break"

            var sum = 0;
            while (true)
            {
                bool stop=false;
                while (true)
                {
                    sum += int.Parse(Console.ReadLine());
                    if (sum > 100)
                    {
                        stop = true;
                        break; //этот break выходит только из внутреннего цикла
                    }
                }
                if (stop)
                {
                    break; //этот break выходит из внешнего цикла по флагу stop
                }
            }
        }
    }
}