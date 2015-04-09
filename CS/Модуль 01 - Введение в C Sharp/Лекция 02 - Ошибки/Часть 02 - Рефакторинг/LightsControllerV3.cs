using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphore
{
    static partial class LightsController
    {
        // Код должен быть читаемым.
        // Передача методу 0,1,2 - это нечитаемо. Можно бороться с этим, используя константы. 
        // Однако это все равно плохо: из сигнатуры метода LightOn не следует, что в него можно передать только эти константы!
        static int Red = 0;
        static int Yellow = 1;
        static int Green = 2;

        static void ControlV3()
        {
            Wait(1);
            while (true)
            {
                form.LightOn(Red);
                Wait(1);
                form.LightOn(Yellow);
                Wait(1);
                form.LightOff(Red);
                form.LightOff(Yellow);
                form.LightOn(Green);
                Wait(1);
                for (int i = 0; i < 5; i++)
                {
                    form.LightOff(Green);
                    Wait(0.25);
                    form.LightOn(Green);
                    Wait(0.25);
                }
                form.LightOff(Green);
                form.LightOn(Yellow);
                Wait(1);
                form.LightOff(Yellow);
            }
        }
    }
}