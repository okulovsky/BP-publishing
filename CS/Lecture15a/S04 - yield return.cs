using System;
using System.Collections.Generic;

namespace Queues
{
    public class Queue3<T> : Queue1<T>
    {
        //А это - то же самое, записанное с помощью yield return
        public override IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }

    class Program3
    {
        public static void MainX()
        {
            var queue = new Queue3<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            foreach (var e in queue)
                Console.WriteLine(e);
        }
    }
}