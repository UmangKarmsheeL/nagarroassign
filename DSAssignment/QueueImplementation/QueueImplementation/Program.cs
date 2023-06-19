using System;

namespace QueueImplementation
{

    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new();

            while (true)
            {
                Console.WriteLine("Choose an operation: ");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Contains");
                Console.WriteLine("5. Size");
                Console.WriteLine("6. Center");
                Console.WriteLine("7. Sort");
                Console.WriteLine("8. Reverse");
                Console.WriteLine("9. Traverse");
                Console.WriteLine("10. Exit");

                int choice = 0;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter an integer.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter an item to enqueue: ");
                        int item = 0;
                        try
                        {
                            item = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input format. Please enter an integer.");
                            continue;
                        }
                        queue.Enqueue(item);
                        break;

                    case 2:
                        try
                        {
                            int dequeued = queue.Dequeue();
                            Console.WriteLine("Dequeued item: " + dequeued);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        try
                        {
                            int peeked = queue.Peek();
                            Console.WriteLine("Peeked item: " + peeked);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 4:
                        try
                        {
                            Console.Write("Enter an item to check if it's in the queue: ");
                            int checkItem = int.Parse(Console.ReadLine());
                            if (queue.Contains(checkItem))
                            {
                                Console.WriteLine(checkItem + " is in the queue");
                            }
                            else
                            {
                                Console.WriteLine(checkItem + " is not in the queue");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input format. Please enter a valid integer.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Size of queue: " + queue.Size());
                        break;

                    case 6:
                        int center = queue.Center();
                        if (center != default(int))
                        {
                            Console.WriteLine("Center of queue: " + center);
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty");
                        }
                        break;

                    case 7:
                        queue.Sort();
                        Console.WriteLine("Queue sorted");
                        break;

                    case 8:
                        queue.Reverse();
                        Console.WriteLine("Queue reversed");
                        break;

                    case 9:
                        Console.WriteLine("Queue contents:");
                        queue.Traverse();
                        break;

                    case 10:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}