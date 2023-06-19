using System;
using System.Collections.Generic;

namespace PriorityQueueImplementation
{
    class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> items;

        
        public PriorityQueue()// Constructor
        {
            items = new List<T>();
        }

        
        public void Enqueue(T item)//This method adds an item to the priority queue based on its priority.
        {
            items.Add(item);

            // Find the index where the new item should be inserted based on its priority
            int currentIndex = items.Count - 1;
            while (currentIndex > 0 && item.CompareTo(items[currentIndex - 1]) < 0)
            {
                items[currentIndex] = items[currentIndex - 1];
                currentIndex--;
            }

            // Insert the new item at the correct index
            items[currentIndex] = item;
        }


        public T Dequeue()//This method removes and returns the highest priority item from the queue.
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Cannot dequeue from an empty priority queue.");
            }

            T item = items[0];
            items.RemoveAt(0);
            return item;
        }


        public T Peek()//This method returns the highest priority item from the queue without removing it.
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Cannot peek at an empty priority queue.");
            }

            return items[0];
        }


        public bool Contains(T item)//This method returns whether the queue contains the specified item.
        {
            return items.Contains(item);
        }

        
        public int Size()//This method returns the number of items in the queue.
        {
            return items.Count;
        }

        
        public void Reverse()//This method reverses the order of items in the queue.
        {
            items.Reverse();
        }

        
        public T Center()//This method returns the item at the center of the queue (or null if the queue is empty).
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Cannot get center item from an empty priority queue.");
            }

            return items[(items.Count - 1) / 2];
        }

        
        public IEnumerator<T> GetEnumerator()//This method returns an iterator for the items in the queue.
        {
            return items.GetEnumerator();
        }

        
        public void Traverse()//This method prints the items in the queue.
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
