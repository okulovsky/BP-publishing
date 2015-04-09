
using System;
using System.Threading;
class Transport { };
class Car : Transport { };

class Program
{
    static void MainX()
    {
        Car car = new Car();
        Transport carAsT =
            (Transport)car;
        Car car1 = (Car)carAsT;
    }
}
