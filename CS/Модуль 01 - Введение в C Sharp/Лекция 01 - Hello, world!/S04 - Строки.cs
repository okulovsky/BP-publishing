using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide04
{
    class Program
    {
        public static void MainX()
        {
            //Строки - это последовательности символов
            string myString = "Hello, world!";
        
            //У строк есть свои собственные методы и "переменные" (правильно называть это свойствами), 
            //которые позволяют узнать информацию о строке 
            Console.WriteLine(myString.Length);

            myString = myString.Substring(0, 5);
            Console.WriteLine(myString);

            //Тип string может иметь особое значение - null.
            //Это не пустая строка, а отсутствие всякой строки.
            myString = null;

            //Интересно, что тип int такого значения иметь не может.
            //int a=null;
        }
    }
}
