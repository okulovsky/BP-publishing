using System;

namespace Slide03
{
    public class QueueItem
    {
        public object Value { get; set; }
        public QueueItem Next { get; set; }
    }

    public class Queue
    {
        QueueItem head;
        QueueItem tail;

        public bool IsEmpty { get { return head == null; } }

        public void Enqueue(object value)
        {
            if (IsEmpty)
                tail = head = new QueueItem { Value = value, Next = null };
            else
            {
                var item = new QueueItem { Value = value, Next = null };
                tail.Next = item;
                tail = item;
            }
        }

        public object Dequeue()
        {
            if (head == null) throw new InvalidOperationException();
            var result = head.Value;
            head = head.Next;
            if (head == null)
                tail = null;
            return result;
        }
        

    }
}