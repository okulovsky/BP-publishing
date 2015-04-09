using System;
using System.Collections.Generic;

namespace Slide00
{
    public class ListStack
    {
        List<int> list = new List<int>();
        public void Push(int value)
        {
            list.Add(value);
        }
        public int Pop()
        {
            if (list.Count == 0) throw new InvalidOperationException();
            var result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }
    }

    public class ListQueue
    {
        List<int> list = new List<int>();
        public void Enqueue(int value)
        {
            list.Add(value);
        }

        public int Dequeue()
        {
            if (list.Count == 0) throw new InvalidOperationException();
            var result = list[0];
            list.RemoveAt(0);
            return result;
        }
    }
}