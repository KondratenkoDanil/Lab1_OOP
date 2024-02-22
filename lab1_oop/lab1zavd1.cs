using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of y:");
        double y = double.Parse(Console.ReadLine());

        double result = Math.Pow((x + 1) / (x - 1), x) + 18 * x * Math.Pow(y, 2);

        Console.WriteLine("Value of the expression: " + result);
    }
}