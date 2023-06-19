using System;
using System.Collections.Generic;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample usage
            var pq = new PriorityQueue<int>();
            pq.Enqueue(1, 10);
            pq.Enqueue(2, 20);
            pq.Enqueue(1, 15);
            Console.WriteLine(pq.Dequeue());  // 15
            Console.WriteLine(pq.Dequeue());  // 10
            Console.WriteLine(pq.Dequeue());  // 20
        }
    }

    class PriorityQueue<T> where T : IEquatable<T>
    {
        private IDictionary<int, IList<T>> elements;

        public PriorityQueue()
        {
            elements = new Dictionary<int, IList<T>>();
        }

        public PriorityQueue(IDictionary<int, IList<T>> elements) : this()
        {
            foreach (var kvp in elements)
            {
                foreach (var item in kvp.Value)
                {
                    Enqueue(kvp.Key, item);
                }
            }
        }

        public int Count
        {
            get
            {
                int count = 0;
                foreach (var kvp in elements)
                {
                    count += kvp.Value.Count;
                }
                return count;
            }
        }

        public bool Contains(T item)
        {
            foreach (var kvp in elements)
            {
                if (kvp.Value.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }

        public T Dequeue()
        {
            int highestPriority = GetHighestPriority();
            var list = elements[highestPriority];
            T item = list[0];
            list.RemoveAt(0);
            if (list.Count == 0)
            {
                elements.Remove(highestPriority);
            }
            return item;
        }

        public void Enqueue(int priority, T item)
        {
            if (!elements.ContainsKey(priority))
            {
                elements.Add(priority, new List<T>());
            }
            elements[priority].Add(item);
        }

        public T Peek()
        {
            int highestPriority = GetHighestPriority();
            var list = elements[highestPriority];
            return list[0];
        }

        private int GetHighestPriority()
        {
            int highestPriority = int.MinValue;
            foreach (var priority in elements.Keys)
            {
                if (priority > highestPriority)
                {
                    highestPriority = priority;
                }
            }
            return highestPriority;
        }
    }
}
