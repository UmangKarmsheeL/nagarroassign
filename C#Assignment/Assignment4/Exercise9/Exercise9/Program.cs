using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise9
{
    class Program
    {
        public interface IPriority
        {
            int Priority { get; }
        }

        public class PriorityQueue2<T> where T : IEquatable<T>, IPriority
        {
            private IDictionary<int, IList<T>> elements;

            public PriorityQueue2()
            {
                elements = new Dictionary<int, IList<T>>();
            }

            public PriorityQueue2(IEnumerable<T> elements) : this()
            {
                foreach (var element in elements)
                {
                    Enqueue(element);
                }
            }

            public int Count
            {
                get { return elements.Values.Sum(list => list.Count); }
            }

            public bool Contains(T item)
            {
                IList<T> list;
                if (elements.TryGetValue(item.Priority, out list))
                {
                    return list.Contains(item);
                }
                return false;
            }

            public T Dequeue()
            {
                var priority = GetHighestPriority();
                var list = elements[priority];
                var item = list[0];
                list.RemoveAt(0);
                if (list.Count == 0)
                {
                    elements.Remove(priority);
                }
                return item;
            }

            public void Enqueue(T item)
            {
                IList<T> list;
                if (!elements.TryGetValue(item.Priority, out list))
                {
                    list = new List<T>();
                    elements[item.Priority] = list;
                }
                list.Add(item);
            }

            public T Peek()
            {
                var priority = GetHighestPriority();
                var list = elements[priority];
                return list[0];
            }

            private int GetHighestPriority()
            {
                return elements.Keys.Max();
            }
        }
    }
    }
