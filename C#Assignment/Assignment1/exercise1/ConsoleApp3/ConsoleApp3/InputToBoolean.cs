using System;

namespace ConsoleApp3
{
    class InputToBoolean
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a boolean value (True or False) :");
            //taking input from user
            string input = Console.ReadLine();
            Console.WriteLine("Enter a boolean value (0 or 1) :");
            string number = Console.ReadLine();

            // Using bool.Parse()
            bool value1 = bool.Parse(input);
            Console.WriteLine("Value1 using bool.Parse(): "+value1);

            // Using Convert.ToBoolean()
            bool value2 = Convert.ToBoolean(Convert.ToInt32(number));
            Console.WriteLine($"Value2 using Convert.ToBoolean(): "+ value2);

            // Using bool.TryParse()
            bool value3;
            if (bool.TryParse(input, out value3))
            {
                Console.WriteLine($"Value3 using bool.TryParse(): " + value3);
            }
            else
            {
                Console.WriteLine("Unable to convert " +input+ " to a boolean.");
            }
        }
    }
}
