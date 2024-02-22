using System;

class Program
{
    static void Main()
    {
        int[] sequence = { 4, 8, 2, 6, 1, 9, 3 };

        ReplaceSmallestWithAverage(sequence);

        Console.WriteLine("Modified sequence:");
        foreach (var item in sequence)
        {
            Console.Write(item + " ");
        }
    }

    static void ReplaceSmallestWithAverage(int[] sequence)
    {
        double average = 0;
        foreach (var item in sequence)
        {
            average += item;
        }
        average /= sequence.Length;

        int smallest = sequence[0];
        int smallestIndex = 0;
        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] < smallest)
            {
                smallest = sequence[i];
                smallestIndex = i;
            }
        }

        sequence[smallestIndex] = (int)average;
    }
}