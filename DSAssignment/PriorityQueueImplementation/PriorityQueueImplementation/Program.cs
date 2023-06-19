using System;

namespace PriorityQueueImplementation
{


    class Program
    {
        static void Main(string[] args)//This the main method to check the functionality of the priorityQueue.
        {
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

            while (true)
            {
                Console.WriteLine("Enter a command (enqueue, dequeue, peek, contains, size, reverse, center, traverse, quit):");
                string command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "enqueue":
                        Console.WriteLine("Enter an integer to enqueue:");
                        int item = int.Parse(Console.ReadLine());
                        priorityQueue.Enqueue(item);
                        Console.WriteLine("Enqueued item {0}.", item);
                        break;

                    case "dequeue":
                        int dequeuedItem = priorityQueue.Dequeue();
                        if (dequeuedItem != default(int))
                        {
                            Console.WriteLine("Dequeued item {0}.", dequeuedItem);
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty.");
                        }
                        break;

                    case "peek":
                        int peekedItem = priorityQueue.Peek();
                        if (peekedItem != default(int))
                        {
                            Console.WriteLine("Highest priority item is {0}.", peekedItem);
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty.");
                        }
                        break;

                    case "contains":
                        Console.WriteLine("Enter an integer to check if it's in the queue:");
                        int searchItem = int.Parse(Console.ReadLine());
                        bool containsItem = priorityQueue.Contains(searchItem);
                        if (containsItem)
                        {
                            Console.WriteLine("{0} is in the queue.", searchItem);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not in the queue.", searchItem);
                        }
                        break;

                    case "size":
                        Console.WriteLine("Queue size is {0}.", priorityQueue.Size());
                        break;

                    case "reverse":
                        priorityQueue.Reverse();
                        Console.WriteLine("Queue has been reversed.");
                        break;

                    case "center":
                        int centerItem = priorityQueue.Center();
                        if (centerItem != default(int))
                        {
                            Console.WriteLine("Center item is {0}.", centerItem);
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty.");
                        }
                        break;

                    case "traverse":
                        Console.WriteLine("Queue items:");
                        priorityQueue.Traverse();
                        break;

                    case "quit":
                        return;

                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
