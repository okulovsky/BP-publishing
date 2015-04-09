using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphore
{


    static partial class LightsController
    {
        //И, наконец, плохо, когда в программе есть числовые значения. Лучше заменять их на константы.
        const int BlinkingCount = 5;
        const double LightTime = 1;
        const double BlinkingTime = 0.25;

        static void ControlV6()
        {
            Wait(LightTime);
            while (true)
            {
                SwitchTo(Lights.Red);
                Wait(LightTime);
                LightOn(Lights.Yellow);
                Wait(LightTime);
                SwitchTo(Lights.Green);
                Wait(LightTime);
                
                //Обратите внимание, что нуля в данном случае это не касается
                for (int i = 0; i < BlinkingCount; i++)
                {
                    LightOff(Lights.Green);
                    Wait(BlinkingTime);
                    LightOn(Lights.Green);
                    Wait(BlinkingTime);
                }
                SwitchTo(Lights.Yellow);
                Wait(LightTime);
            }
        }
    }
}