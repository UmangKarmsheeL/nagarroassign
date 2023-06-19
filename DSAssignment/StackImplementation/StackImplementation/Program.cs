using System;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();//This the main method to test the functionality of stack.

            while (true)
            {
                Console.WriteLine("Enter a command (push, pop, peek, contains, size, center, sort, reverse, traverse, quit):");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "push":
                        Console.WriteLine("Enter a number to push:");
                        int data = int.Parse(Console.ReadLine());
                        stack.Push(data);
                        Console.WriteLine("Pushed " + data);
                        break;
                    case "pop":
                        try
                        {
                            int popped = stack.Pop();
                            Console.WriteLine("Popped " + popped);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "peek":
                        try
                        {
                            int peeked = stack.Peek();
                            Console.WriteLine("Peeked " + peeked);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "contains":
                        Console.WriteLine("Enter a number to check if it's in the stack:");
                        int search = int.Parse(Console.ReadLine());
                        if (stack.Contains(search))
                        {
                            Console.WriteLine(search + " is in the stack");
                        }
                        else
                        {
                            Console.WriteLine(search + " is not in the stack");
                        }
                        break;
                    case "size":
                        Console.WriteLine("Stack size: " + stack.Size());
                        break;
                    case "center":
                        try
                        {
                            int center = stack.Center();
                            Console.WriteLine("Center: " + center);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "sort":
                        stack.Sort();
                        Console.WriteLine("Stack sorted");
                        break;
                    case "reverse":
                        stack.Reverse();
                        Console.WriteLine("Stack reversed");
                        break;
                    case "traverse":
                        Console.WriteLine("Stack contents:");
                        stack.Traverse();
                        break;
                    case "quit":
                        return;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}
