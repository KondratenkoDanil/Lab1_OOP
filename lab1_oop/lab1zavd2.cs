using System;

class Program
{
    static void Main()
    {
        double x = 2;

        double result1 = -2 * x + 3 * Math.Pow(x, 2) - 4 * Math.Pow(x, 3);

        double result2 = 1 + 2 * x + 3 * Math.Pow(x, 2) + 4 * Math.Pow(x, 3);

        Console.WriteLine($"Value of the first expression: {result1}");
        Console.WriteLine($"Value of the second expression: {result2}");
    }
}