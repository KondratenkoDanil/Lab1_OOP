using System;

class Program
{
    static void Main()
    {
        int n = 20;

        Console.WriteLine($"Prime numbers in the range [2, {n}]:");
        PrintPrimeNumbers(n);
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }
        return true;
    }

    static void PrintPrimeNumbers(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}