using System;
using System.Collections.Generic;

namespace LinkedList_Implementation
{
    public class LinkedList<T>//Main LinkedList implementation.
    {
        private LinkedListNode<T> head;
        private int size;

        public LinkedList()
        {
            head = null;
            size = 0;
        }

        public void Insert(T value)//Insert method to insert new elements in LinkedList.
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                LinkedListNode<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            size++;
        }

        public void InsertAtPosition(T value, int position)//InsertAtPosition method to insert at a certain position.
        {
            if (position < 0 || position > size)
            {
                throw new ArgumentOutOfRangeException("position", "Invalid position");
            }

            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (position == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                LinkedListNode<T> current = head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }

            size++;
        }

        public void Delete(T value)//Delete method to delete a value .
        {
            if (head == null)
            {
                return;
            }

            if (head.Value.Equals(value))
            {
                head = head.Next;
                size--;
                return;
            }

            LinkedListNode<T> current = head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next = current.Next.Next;
                    size--;
                    return;
                }
                current = current.Next;
            }
        }

        public void DeleteAtPosition(int position)//DeleteAtPosition to delete value at a position
        {
            if (position < 0 || position >= size)
            {
                throw new ArgumentOutOfRangeException("position", "Invalid position");
            }

            if (position == 0)
            {
                head = head.Next;
            }
            else
            {
                LinkedListNode<T> current = head;
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }

            size--;
        }

        public T Center()//Center method to find value at center node.
        {
            if (head == null)
            {
                throw new InvalidOperationException("List is empty");
            }

            LinkedListNode<T> slow = head;
            LinkedListNode<T> fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow.Value;
        }

        public void Sort()//Sort method to sort the list in ascending order.
        {
            if (head == null)
            {
                return;
            }

            LinkedListNode<T> current = head;
            LinkedListNode<T> next = current.Next;

            while (next != null)
            {
                if (Comparer<T>.Default.Compare(current.Value, next.Value) > 0)
                {
                    T temp = current.Value;
                    current.Value = next.Value;
                    next.Value = temp;
                }

                current = next;
                next = next.Next;
            }
        }

        public void Reverse()//Reverse method to reverse the order of nodes in the list.
        {
            if (head == null)
            {
                return;
            }

            LinkedListNode<T> current = head;
            LinkedListNode<T> next = current.Next;
            head.Next = null;

            while (next != null)
            {
                LinkedListNode<T> temp = next.Next;
                next.Next = current;
                current = next;
                next = temp;
            }

            head = current;
        }

        public int Size()//Size method to return the number of nodes in the list.
        {
            return size;
        }

        public IEnumerator<T> GetEnumerator()//GetEnumerator method to iterate overthe values in list.
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public void Traverse()//Traverse method to print the values of nodes in th list.
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}
