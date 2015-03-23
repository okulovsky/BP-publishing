using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide10
{
    class Program
    {
        /* Комментарий с тремя слэшами превращается в документацию
         */

        /// <summary>
        /// Вычисляет округление частного аргументов
        /// </summary>
        /// <param name="dividend">Делимое</param>
        /// <param name="divisor">Делитель</param>
        /// <returns>Округленное частное</returns>
        static int DivideAndRound(double dividend, double divisor)
        {
            return (int)Math.Round(dividend / divisor);
        }

        static void MainX()
        {
            // Вы можете изучать методы и классы самостоятельно, используя документацию и Intellisence
            // Чтобы посмотреть документацию, нажмите Ctrl-K,P
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(DivideAndRound(0.1, 0.01));
        }
    }
}
