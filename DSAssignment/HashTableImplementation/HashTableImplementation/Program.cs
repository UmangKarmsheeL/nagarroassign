using System;

namespace HashTableImplementation
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the capacity of the hash table: ");
            int capacity = int.Parse(Console.ReadLine());
            HashTable<string, int> hashTable = new HashTable<string, int>(capacity);

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Contains");
                Console.WriteLine("4. Get Value by Key");
                Console.WriteLine("5. Size/Iterator");
                Console.WriteLine("6. Traverse");
                Console.WriteLine("7. Exit");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter the key: ");
                        string key = Console.ReadLine();
                        Console.Write("Enter the value: ");
                        int value = int.Parse(Console.ReadLine());
                        hashTable.Insert(key, value);
                        Console.WriteLine("Key-Value pair inserted successfully!");
                        break;

                    case 2:
                        Console.Write("Enter the key: ");
                        key = Console.ReadLine();
                        hashTable.Delete(key);
                        Console.WriteLine("Key-Value pair deleted successfully!");
                        break;

                    case 3:
                        Console.Write("Enter the key: ");
                        key = Console.ReadLine();
                        if (hashTable.Contains(key))
                        {
                            Console.WriteLine("Key found in the hash table!");
                        }
                        else
                        {
                            Console.WriteLine("Key not found in the hash table!");
                        }
                        break;

                    case 4:
                        Console.Write("Enter the key: ");
                        key = Console.ReadLine();
                        try
                        {
                            value = hashTable.GetValueByKey(key);
                            Console.WriteLine("Value: " + value);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 5:
                        Console.WriteLine("Size: " + hashTable.Size());
                        break;

                    case 6:
                        hashTable.Traverse();
                        break;

                    case 7:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }
    }
}
