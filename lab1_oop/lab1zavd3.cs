using System;

class Program
{
    static void Main()
    {
        double a1 = 3, b1 = 4, c1 = 5;
        double a2 = 6, b2 = 8, c2 = 10;

        double area1 = CalculateArea(a1, b1, c1);
        double area2 = CalculateArea(a2, b2, c2);

        bool areEqual = Math.Abs(area1 - area2) < 0.0001;

        Console.WriteLine(areEqual);
    }

    static double CalculateArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}