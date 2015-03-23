using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphore
{
    static partial class LightsController
    {
        // Основной принцип программирование: Don't Repeat Yourself. Не повторять один и тот же код дважды. 
        // Если при создании программы вы нажимали Ctrl-C + Ctrl-V - в ней что-то не так.
        // Кроме того, старайтесь, чтобы каждый метод был размером не больше экрана.
        static void ControlV2()
        {
            Wait(1);
            while (true)
            {
                form.LightOn(0);
                Wait(1);
                form.LightOn(1);
                Wait(1);
                form.LightOff(0);
                form.LightOff(1);
                form.LightOn(2);
                Wait(1);
                //Здесь мы заменили повторяющиеся строчки циклом
                for (int i = 0; i < 5; i++)
                {
                    form.LightOff(2);
                    Wait(0.25);
                    form.LightOn(2);
                    Wait(0.25);
                }
                form.LightOff(2);
                form.LightOn(1);
                Wait(1);
                form.LightOff(1);
            }
        }
    }
}