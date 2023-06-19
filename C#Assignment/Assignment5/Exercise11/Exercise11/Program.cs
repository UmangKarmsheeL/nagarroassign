using System;

namespace Exercise11
{

    public static class IntegerExtentions
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else if (number<= 3)
            {
                return true;
            }
            else if ( number %2 == 0 || number% 3 == 0)
            {
                return false;
            }
            else
            {
                for(int i = 5; i*i<= number; i += 6)
                {
                    if(number %i ==0 || number % (i+2)== 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool IsDivisibleBy(this int number , params int[] divisors)
        {
            if(divisors == null || divisors.Length == 0)
            {
                throw new ArgumentException("at least specify one divisor.");
            }
            foreach(int divisor in divisors)
            {
                if(number% divisor != 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine("Number is odd: " + number.IsOdd());
            Console.WriteLine("Number is even: " + number.IsEven());
            Console.WriteLine("Number is prime: " + number.IsPrime());
            Console.WriteLine("Number is divisible by 2 and 3 : " + number.IsDivisibleBy(2 ,3));

        }

    }
}
