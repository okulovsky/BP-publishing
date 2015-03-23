using System;

namespace Slide01
{
    //Допустим, мы хотим хранить список студентов и печатать его элементы
    //Пока эту проблему можно решить так:
    public class Program
    {
        static void PrintStudent(string firstName, string lastName)
        {
            Console.WriteLine("{0,-15}{1}", firstName, lastName);
        }

        static string[] firstNames;
        static string[] lastNames;

        static void MainX()
        {
            firstNames = new string[2];
            lastNames = new string[2];
            firstNames[0] = "John";
            firstNames[1] = "William";
            lastNames[0] = "Jones";
            lastNames[1] = "Williams";
            PrintStudent(firstNames[0], lastNames[0]);
            PrintStudent(firstNames[1], lastNames[1]);
        }
        /* Это плохо:
         * - нет никакой синтаксической гарантии, что firstNames и lastNames одной длины,
         *   что по одному индексу хранятся данные об одном человеке
         * - при добавлении новой информации о студенте (например, int Age) придется переписывать всю программу
         * - при большом количестве новой информации, количество аргументов PrintStudent
         *   будет большим, а вызов этого метода станет неудобным.
         */

    }
}