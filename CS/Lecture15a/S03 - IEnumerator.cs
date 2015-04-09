using System;
using System.Collections.Generic;

namespace Queues
{
    public class Queue2<T> : Queue1<T>
    {
        public override IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator2<T>(this);
        }
    }

    //Это - перечислитель. Он умеет: смотреть на какой-нибудь элемент,
    //и перемещаться на следующий элемент
    public class QueueEnumerator2<T> : IEnumerator<T>
    {
        Queue2<T> queue;
        QueueItem<T> currentItem;

        public QueueEnumerator2(Queue2<T> queue)
        {
            this.queue = queue;
            //В самом начале перечислитель не смотрит ни на какой элемент
            //Чтобы посмотреть на первый элемент, его нужно сначала переместить.
            this.currentItem = null;
        }

        public T Current
        {
            get { return currentItem.Value; } 
        }

        public bool MoveNext()
        {
            //Если мы еще никуда не смотрим - посмотреть на голову очереди
            if (currentItem == null)
                currentItem = queue.Head;
            //В противном случае, посмотреть на следующий элемент
            else
                currentItem = currentItem.Next;
            //Вернуть true, если нам удалось перейти на следующий элемент, 
            //или false, если не удалось и из foreach нужно выйти
            return currentItem != null;
        }

        // Остальные методы нас не волнуют. Просто всегда пишите так.
        public void Dispose()
        {
            
        }
        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }
        public void Reset()
        {
            
        }
    }

    class Program2
    {
        public static void MainX()
        {
            var queue = new Queue2<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            foreach (var e in queue)
                Console.WriteLine(e);
        }
    }
}