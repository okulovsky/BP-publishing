
namespace S017
{
    class Transport
    {
        public double Velocity;
        public double KilometerPrice;
        public int Capacity;
    }

    class CombustionEngineTransport : Transport
    {
        public double EngineVolume;
        public double EnginePower;
    }

    enum ControlType
    {
        Forward,
        Backward
    }

    class Car : CombustionEngineTransport
    {
        public ControlType Control;
    }

    public class Program
    {
        public static void MainX()
        {
            Car car = new Car();
            Transport carAsTransport = (Transport)car;
            Car car1 = (Car)carAsTransport;

            var cet = (CombustionEngineTransport)(new Car());
            if (cet is Car)
            {
                var cetAsCar = (Car)cet;
            }
        }
    }

}
