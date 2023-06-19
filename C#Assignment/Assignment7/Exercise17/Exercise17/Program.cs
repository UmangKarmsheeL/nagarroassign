using System;

public class InvalidInputException : Exception
{
    public InvalidInputException(string message) : base(message)
    {
    }
}

public class Game
{
    static void Main(string[] args)// This is the entry point.
    {
        Game game = new();
        game.Play();//Play method to start the game.
    }
    private int playCount = 0;

    private int ValidateInput(string userInput)
    {
        if (!int.TryParse(userInput, out int num))
        {
            throw new InvalidInputException("Please enter a number.");
        }
        if (num < 1 || num > 5)
        {
            throw new InvalidInputException("Please enter a number between 1 and 5.");
        }
        return num;
    }

    private bool IsPrime(int num)//Method to check prime number.
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    private bool IsEven(int num)//Method to check even number and so on.
    {
        return num % 2 == 0;
    }

    private bool IsOdd(int num)
    {
        return num % 2 != 0;
    }

    private bool IsNegative(int num)
    {
        return num < 0;
    }

    private bool IsZero(int num)
    {
        return num == 0;
    }

    public void Play()//This is the play method which acts according to user inputs.
    {
        while (true)
        {
            Console.WriteLine("Enter any number from 1-5:");
            try
            {
                int num = ValidateInput(Console.ReadLine());
                playCount++;
                if (num == 1)
                {
                    Console.WriteLine("Enter even number.");
                }
                else if (num == 2)
                {
                    Console.WriteLine("Enter odd number.");
                }
                else if (num == 3)
                {
                    Console.WriteLine("Enter a prime number.");
                }
                else if (num == 4)
                {
                    Console.WriteLine("Enter a negative number.");
                }
                else if (num == 5)
                {
                    Console.WriteLine("Enter zero.");
                }

                int userNum = int.Parse(Console.ReadLine());//This part checks for error and throw error messages.
                if (num == 1 && !IsEven(userNum))
                {
                    throw new InvalidInputException("Incorrect input. Please enter an even number.");
                }
                else if (num == 2 && !IsOdd(userNum))
                {
                    throw new InvalidInputException("Incorrect input. Please enter an odd number.");
                }
                else if (num == 3 && !IsPrime(userNum))
                {
                    throw new InvalidInputException("Incorrect input. Please enter a prime number.");
                }
                else if (num == 4 && !IsNegative(userNum))
                {
                    throw new InvalidInputException("Incorrect input. Please enter a negative number.");
                }
                else if (num == 5 && !IsZero(userNum))
                {
                    throw new InvalidInputException("Incorrect input. Please enter zero.");
                }

                if (playCount == 5)
                {
                    Console.WriteLine("You have played this game 5 times.");
                    break;
                }
            }
            catch (InvalidInputException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
