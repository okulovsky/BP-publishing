using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphore
{


    static partial class LightsController
    {
        //Можно предлагать дополнительные методы для рефакторинга, и делать программу еще короче и понятнее, 
        //убирая из нее неявные повторения
        //Тут, опять же, важно знать, когда остановиться
        static void SwitchTo(Lights color)
        {
            LightOff(Lights.Red);
            LightOff(Lights.Yellow);
            LightOff(Lights.Green);
            LightOn(color);
        }

        static void ControlV5()
        {
            Wait(1);
            while (true)
            {
                SwitchTo(Lights.Red); 
                Wait(1);
                LightOn(Lights.Yellow);
                Wait(1);
                SwitchTo(Lights.Green);
                Wait(1);
                for (int i = 0; i < 5; i++)
                {
                    LightOff(Lights.Green);
                    Wait(0.25);
                    LightOn(Lights.Green);
                    Wait(0.25);
                }
                SwitchTo(Lights.Yellow);
                Wait(1);
            }
        }
    }
}