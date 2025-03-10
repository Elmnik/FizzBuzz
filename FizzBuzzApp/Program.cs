using System;

class Program
{
    static void fizzBuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number (1 to 16):");

            // Read input and check if it's a valid integer
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                throw new FormatException("Invalid input. Please enter a valid integer.");
            }

            // Validate range
            if (n <= 0 || n >= 16)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Number must be between 1 and 16.");
            }

            fizzBuzz(n);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}