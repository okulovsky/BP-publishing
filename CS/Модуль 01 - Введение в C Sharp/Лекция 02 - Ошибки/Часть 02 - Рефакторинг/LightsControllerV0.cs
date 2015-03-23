using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semaphore
{
    /* partial - это ключевое слово, которое позволяет определять методы и данные класса LightsController 
     * в разных кодовых файлах. При компиляции все, что определено в этих файлах, собирается в один класс.
     * Это удобно, когда класс очень большой.
     * Мы же используем это для удобства, чтобы в каждом файле показывать отдельное небольшое изменение.
     */
    static partial class LightsController
    {
        // Очень неудачное название переменной! Почему T? В секундах или милисекундах? И т.д.
        // Переменные должны иметь осмысленные, понятные названия.
        // Для переименования, можно нажать правой кнопкой на имя переменной, и затем Refactor->Rename
        // Кроме того, принято имена классов и методов именовать с большой буквы, а глобальные и локальные переменные - с маленькой

        // Было: 
        // static void wait(double T) 
        // { 
        //     Thread.Sleep((int)(t * 1000)); 
        // }

        //Стало:
        static void Wait(double timeInSeconds)
        {
            Thread.Sleep((int)(timeInSeconds * 1000));
        }
    }
}