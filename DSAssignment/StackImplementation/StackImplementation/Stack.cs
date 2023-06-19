using System;
using System.Collections.Generic;

namespace StackImplementation
{
    class Stack<T>
    {
        private List<T> stack = new List<T>();

        public void Push(T data)//This method is to add new elements to top of the stack.
        {
            stack.Add(data);
        }

        public T Pop()//This method is to remove element from the top of the stack 
        {
            if (!IsEmpty())
            {
                T data = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return data;
            }
            else
            {
                throw new Exception("Stack is empty");//If empty it will throw exception.
            }
        }

        public T Peek()//This method returns the top of the stack without removing it.
        {
            if (!IsEmpty())
            {
                return stack[stack.Count - 1];
            }
            else
            {
                throw new Exception("Stack is empty");
            }
        }

        public bool Contains(T data)//This method check if the given  element is in the stack.
        {
            return stack.Contains(data);
        }

        public int Size()//This method returns the number of elements in the stack.
        {
            return stack.Count;
        }

        public T Center()//This method returns the middle element in the stack.
        {
            if (!IsEmpty())
            {
                int index = stack.Count / 2;
                if (stack.Count % 2 == 0)
                {
                    index--;
                }
                return stack[index];
            }
            else
            {
                throw new Exception("Stack is empty");
            }
        }

        public void Sort()//This method sort the elements of the stack in ascending order.
        {
            stack.Sort();
        }

        public void Reverse()//This method reverse the order of the elements in the stack.
        {
            stack.Reverse();
        }

        public IEnumerator<T> GetEnumerator()//This method iterates over the elments in the stack.
        {
            return stack.GetEnumerator();
        }

        public void Traverse()//This method prints all the elements in the stack.
        {
            foreach (T data in stack)
            {
                Console.WriteLine(data);
            }
        }

        public bool IsEmpty()//This method returns true if stack is empty.
        {
            return stack.Count == 0;
        }
    }
}
