using System;
using System.Collections.Generic;

namespace Exercise10
{
    class Program
    {
        class PriorityQueue3<T> where T : IEquatable<T>
        {
            private class PriorityNode//Here we are using node.
            {
                public int Priority { get; private set; }
                public T Data { get; private set; }

                public PriorityNode(int priority, T data)
                {
                    Priority = priority;
                    Data = data;
                }
            }

            private IList<PriorityNode> elements;

            public PriorityQueue3()
            {
                elements = new List<PriorityNode>();
            }

            public PriorityQueue3(IDictionary<int, IList<T>> elements) : this()
            {
                foreach (var kvp in elements)
                {
                    foreach (var item in kvp.Value)//Here kvp stands for key-value pair
                    {
                        Enqueue(kvp.Key, item);
                    }
                }
            }

            public int Count => elements.Count;

            public bool Contains(T item)
            {
                foreach (var node in elements)
                {
                    if (node.Data.Equals(item))
                    {
                        return true;
                    }
                }
                return false;
            }

            public T Dequeue()
            {
                if (elements.Count == 0)
                {
                    throw new InvalidOperationException("The priority queue is empty.");
                }

                int highestPriority = GetHighestPriority();
                T highestPriorityItem = default(T);

                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i].Priority == highestPriority)
                    {
                        highestPriorityItem = elements[i].Data;
                        elements.RemoveAt(i);
                        break;
                    }
                }

                return highestPriorityItem;
            }

            public void Enqueue(int priority, T item)
            {
                PriorityNode node = new PriorityNode(priority, item);

                bool added = false;
                for (int i = 0; i < elements.Count; i++)
                {
                    if (node.Priority > elements[i].Priority)
                    {
                        elements.Insert(i, node);
                        added = true;
                        break;
                    }
                }

                if (!added)
                {
                    elements.Add(node);
                }
            }

            public T Peek()
            {
                if (elements.Count == 0)
                {
                    throw new InvalidOperationException("The priority queue is empty.");
                }

                int highestPriority = GetHighestPriority();
                T highestPriorityItem = default(T);

                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i].Priority == highestPriority)
                    {
                        highestPriorityItem = elements[i].Data;
                        break;
                    }
                }

                return highestPriorityItem;
            }

            private int GetHighestPriority()
            {
                if (elements.Count == 0)
                {
                    throw new InvalidOperationException("The priority queue is empty.");
                }

                int highestPriority = int.MinValue;

                foreach (var node in elements)
                {
                    if (node.Priority > highestPriority)
                    {
                        highestPriority = node.Priority;
                    }
                }

                return highestPriority;
            }
        }
    }
}
