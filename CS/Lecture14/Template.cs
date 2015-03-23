using Slide03;
using System;

namespace Slide00
{
public class Program
{
    static void MainX()
    {
        var queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
    }
}
}