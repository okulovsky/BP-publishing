
using System;

namespace Slide05
{
    public class Program
    {
        static void MainЧ()
        {
            var myIntQueue = new Slide03.Queue();
            myIntQueue.Enqueue(10);
            myIntQueue.Enqueue(20);
            myIntQueue.Enqueue(30);

            //Но что, если кто-то напишет так:
            myIntQueue.Enqueue("Surprise!");

            int sum = 0;
            while (!myIntQueue.IsEmpty)
            {
                int value = (int)myIntQueue.Dequeue();
                sum += value;
            }

        }
    }
}