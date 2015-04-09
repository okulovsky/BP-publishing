using System;
using System.Text;

namespace Slide05
{
    public class Program
    {
        static void MainX()
        {
            //StringBuilder - это класс, представляющий собой изменяемую строку
            var builder = new StringBuilder();

            //Он содержит различные методы вставки, добавления, удаления и т.д.
            builder.Append("Some ");
            builder.Append("string ");
            builder.Append("#15");
            builder.Remove(0, 5);
            builder.Insert(0, "test ");

            //Также можно манипулировать отдельными символами
            builder[0] = 'T';

            //StringBuilder можно превратить в строку
            var str = builder.ToString();
            Console.WriteLine(str);

            //Не нужно полностью заменять строки на StringBuilder,
            //Только в тех случаях, когда действительно выполняется много преобразований
        }
    }
}