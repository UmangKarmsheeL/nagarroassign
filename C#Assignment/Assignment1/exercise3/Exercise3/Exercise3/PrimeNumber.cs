using System;

namespace Exercise3
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int num1, num2;

            do
            {
                Console.Write("Enter the first number (must be between 2 and 1000): ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number (must be between 2 and 1000 and greater than the first number): ");
                num2 = int.Parse(Console.ReadLine());

                if (num1 >= num2 || num1 < 2 || num2 > 1000)
                {
                    Console.WriteLine("Invalid input. Please enter two positive non-equal integers between 2 and 1000, with the first number smaller than the second number.");
                }
            } 
            
            while (num1 >= num2 || num1 < 2 || num2 > 1000);

            Console.WriteLine("Prime numbers between" +num1+ "and"+ num2 + " :");

            for (int i = num1; i <= num2; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
