using System;

namespace LinkedList_Implementation
{

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            Console.WriteLine("Enter integer values to add to the list (one per line).");
            Console.WriteLine("Enter a non-integer value to stop.");

            try
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    int value;

                    if (int.TryParse(input, out value))
                    {
                        list.Insert(value);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding values to the list: {ex.Message}");
            }

            Console.WriteLine("List contents:");
            list.Traverse();

            try
            {
                Console.WriteLine("Enter an integer value to insert at a position in the list:");
                int insertValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the position to insert the value at:");
                int insertPosition = int.Parse(Console.ReadLine());
                list.InsertAtPosition(insertValue, insertPosition);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter an integer value.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"An error occurred while inserting the value: {ex.Message}");
            }

            Console.WriteLine("List contents after insert:");
            list.Traverse();

            try
            {
                Console.WriteLine("Enter an integer value to delete from the list:");
                int deleteValue = int.Parse(Console.ReadLine());
                list.Delete(deleteValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter an integer value.");
            }

            Console.WriteLine("List contents after delete:");
            list.Traverse();

            try
            {
                Console.WriteLine("List center value:");
                Console.WriteLine(list.Center());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"An error occurred while finding the center value: {ex.Message}");
            }

            Console.WriteLine("List contents after sort:");
            list.Sort();
            list.Traverse();

            Console.WriteLine("List contents after reverse:");
            list.Reverse();
            list.Traverse();

            Console.WriteLine("List size:");
            Console.WriteLine(list.Size());

            Console.ReadLine();
        }
    }
}
