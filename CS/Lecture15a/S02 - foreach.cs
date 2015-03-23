using System;
using System.Collections.Generic;

namespace Queues
{
    class Program1
    {
        public static void MainX()
        {
            var queue = new Queue1<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            //Сейчас это выкинет Exception, потому что метод закрыт стабом
            foreach (var e in queue)
                Console.WriteLine(e);
        }
    }
}