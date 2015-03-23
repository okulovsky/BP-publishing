using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphore
{
    static partial class LightsController
    {
        //Код, который будет далее модифицироваться
        static void ControlV1()
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
                form.LightOff(2);
                Wait(0.25);
                form.LightOn(2);
                Wait(0.25);
                form.LightOff(2);
                Wait(0.25);
                form.LightOn(2);
                Wait(0.25);
                form.LightOff(2);
                Wait(0.25);
                form.LightOn(2);
                Wait(0.25);
                form.LightOff(2);
                Wait(0.25);
                form.LightOn(2);
                Wait(0.25);
                form.LightOff(2);
                Wait(0.25);
                form.LightOn(2);
                Wait(0.25);
                form.LightOff(2);
                form.LightOn(1);
                Wait(1);
                form.LightOff(1);
            }
        }
    }
}