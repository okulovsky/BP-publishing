using System;
using System.Collections.Generic;

namespace Queues
{
    //Это очередь, которую мы будем рассматривать. 
    //Я определю в ней интерфейс IEnumerable<T>, который означает сущность,
    //элементы которой можно перечислить. По этой сущности можно бегать foreach
    //Назначение этого метода - вернуть "перечислитель", сущность, 
    //которая перечисляет элементы
    //Я сделаю метод виртуальным, чтобы пробовать разные перечислители. 
    //Это отсутствует в видео, и сделано только для оптимизации кода в проекте
    //Чтобы не переписывать класс каждый раз целиком
    public class Queue1<T> : IEnumerable<T>
    {
        public virtual IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //Не будем останавливаться на этом. Просто всегда пишите так.
        //Это связано с архитектурными особенностями IEnumerable<T>,
        //И требует следующего уровня понимания архитектур
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        public QueueItem<T> Head { get; private set; }
        QueueItem<T> tail;

        public bool IsEmpty { get { return Head == null; } }

        public void Enqueue(T value)
        {
            if (IsEmpty)
                tail = Head = new QueueItem<T> { Value = value, Next = null };
            else
            {
                var item = new QueueItem<T> { Value = value, Next = null };
                tail.Next = item;
                tail = item;
            }
        }

        public T Dequeue()
        {
            if (Head == null) throw new InvalidOperationException();
            var result = Head.Value;
            Head = Head.Next;
            if (Head == null)
                tail = null;
            return result;
        }


    }


    public class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> Next { get; set; }
    }

   
}