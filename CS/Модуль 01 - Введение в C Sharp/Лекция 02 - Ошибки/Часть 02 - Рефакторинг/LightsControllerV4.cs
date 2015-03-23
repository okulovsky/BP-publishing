using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphore
{
    // enum - это тип данных, который предназначен специально для подобных случаев
    // Его значениями могут быть только константы из списка
    enum Lights
    {
        Red=0,
        Yellow=1,
        Green=2
    }

    static partial class LightsController
    {
        // Надо знать, когда прекращать рефакторинг. Я мог бы залезть в класс LightsForm и поправить методы там.
        // Но это - "чужой класс", и не надо лезть в него с рефакторингом. Я напишу методы-декораторы.
        static void LightOn(Lights color)
        {
            form.LightOn((int)color);
        }

        static void LightOff(Lights color)
        {
            form.LightOff((int)color);
        }

        static void ControlV4()
        {
            Wait(1);
            while (true)
            {
                LightOn(Lights.Red); // Теперь из Intellisence видно, что в LightOn нужно передать цвет, причем только один из трех
                Wait(1);
                LightOn(Lights.Yellow);
                Wait(1);
                LightOff(Lights.Red);
                LightOff(Lights.Yellow);
                LightOn(Lights.Green);
                Wait(1);
                for (int i = 0; i < 5; i++)
                {
                    LightOff(Lights.Green);
                    Wait(0.25);
                    LightOn(Lights.Green);
                    Wait(0.25);
                }
                LightOff(Lights.Green);
                LightOn(Lights.Yellow);
                Wait(1);
                LightOff(Lights.Yellow);
            }
        }
    }
}