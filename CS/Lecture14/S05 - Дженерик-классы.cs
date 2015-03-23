using System;
using System.Collections.Generic;

namespace Slide05
{
    public class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> Next { get; set; }
    }

    public class Queue<T>
    {
        QueueItem<T> head;
        QueueItem<T> tail;

        public bool IsEmpty { get { return head == null; } }

        public void Enqueue(T value)
        {
            if (IsEmpty)
                tail = head = new QueueItem<T> { Value = value, Next = null };
            else
            {
                var item = new QueueItem<T> { Value = value, Next = null };
                tail.Next = item;
                tail = item;
            }
        }

        public T Dequeue()
        {
            if (head == null) throw new InvalidOperationException();
            var result = head.Value;
            head = head.Next;
            if (head == null)
                tail = null;
            return result;
        }
    }

    public class ListStack<T>
    {
        List<T> list = new List<T>();
        public void Push(T value)
        {
            list.Add(value);
        }
        public T Pop()
        {
            if (list.Count == 0) throw new InvalidOperationException();
            var result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }
    }
}