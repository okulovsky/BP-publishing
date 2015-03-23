using System;

namespace Slide10
{
    class StaticAlgorithm
    {
        static int temporalValue;
        static public int Run(int value)
        {
            var result = 0;
            for (temporalValue = 0; temporalValue <= value; temporalValue++)
                result += temporalValue;
            return result;
        }
    }

    class Algorithm
    {
        int temporalValue;

        public int Run(int value)
        {
            var result = 0;
            for (temporalValue = 0; temporalValue <= value; temporalValue++)
                result += temporalValue;
            return result;
        }
    }

    class Program
    {
        public static void MainX()
        {
            StaticAlgorithm.Run(10);

            var algorithm = new Algorithm();
            algorithm.Run(10);
        }
    }

}