using System;
using System.Collections.Generic;

namespace QueueImplementation
{
    class Queue<T>//Here we are creating Queue.
    {
        private List<T> items;

        public Queue()
        {
            items = new List<T>();
        }
        //Here are the different method to Queue.
        public void Enqueue(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            items.Add(item);
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return items[0];
        }

        public bool Contains(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            return items.Contains(item);
        }

        public int Size()
        {
            return items.Count;
        }

        public T Center()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return items[items.Count / 2];
        }

        public void Sort()
        {
            items.Sort();
        }

        public void Reverse()
        {
            items.Reverse();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public void Traverse()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
}