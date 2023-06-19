using System;

namespace ConsoleApp2
{
    class InputToFloat
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            // taking input from user
            string userInput = Console.ReadLine();

            // Using float.Parse() method
            try
            {
                float result = float.Parse(userInput);
                Console.WriteLine("Result using float.Parse(): "  + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format");
            }

            // Using float.TryParse() method
            if (float.TryParse(userInput, out float tryParseResult))
            {
                Console.WriteLine("Result using float.TryParse(): " + tryParseResult);
            }
            else
            {
                Console.WriteLine("Invalid input format");
            }

            // Using Convert.ToSingle() method
            try
            {
                float convertResult = Convert.ToSingle(userInput);
                Console.WriteLine("Result using Convert.ToSingle(): " + convertResult);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format");
            }
        }
    }
}
