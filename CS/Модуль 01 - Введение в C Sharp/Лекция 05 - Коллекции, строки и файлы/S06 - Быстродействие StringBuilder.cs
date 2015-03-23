using System;
using System.Diagnostics;
using System.Text;

namespace Slide06
{
    public class Program
    {
        //Если нам нужно сконкатенировать большое количество строк
        //то конкатенация "в лоб" потребует очень много памяти в куче, 
        //и будет работать медленно
        static void WrongConcatenation()
        {
            var str = "";

            for (int i = 0; i < 50000; i++)
            {
                str += i.ToString() + ", ";
            }
        }

        //Конкатенация со StringBuilder работает в сотни раз быстрее
        //Однако, в случае 3-4 строк вы не почувствуете разницы, поэтому 
        //в этом случае пользоваться StringBuilder не обязательно
        static void RightConcatenation()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < 50000; i++)
            {
                builder.Append(i);
                builder.Append(", ");
            }           
        }

        static void MainX()
        {
            var watch = new Stopwatch();
            watch.Start();
            WrongConcatenation();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            watch = new Stopwatch();
            watch.Start();
            RightConcatenation();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}