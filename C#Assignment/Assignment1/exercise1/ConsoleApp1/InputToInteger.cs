using System;

namespace ConsoleApp1
{
    class InputToInteger
    {
        static void Main(string[] args)
        {
            // Take input from user as a string
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter a decimal number:");
            string dec = Console.ReadLine();
            

            // Use int.TryParse to attempt to parse the input string and return true of false
            bool res;
            res = int.TryParse(input, out _);

            Console.WriteLine("Result from int.TryParse: " + res);

            
            // Use int.Parse to parse the input string 
            int result2 = int.Parse(input);
            Console.WriteLine("Result from int.Parse: " + result2);

            // Use Convert.ToInt32 to convert the input string
            int result3 = Convert.ToInt32(Convert.ToDouble(dec));
            Console.WriteLine("Result from Convert.ToInt32: " + result3);
        }
    }
}
