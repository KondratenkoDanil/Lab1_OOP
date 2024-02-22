using System;
class Program
{
    static void Main()
    {
        int N = 20;
        int M = 15;

        int destinationFloor = GetDestinationFloor(N, M);

        Console.WriteLine($"The elevator should take the passenger to floor {destinationFloor}");
    }

    static int GetDestinationFloor(int totalFloors, int apartmentNumber)
    {
        int floor = 1;

        while (apartmentNumber > 0)
        {
            if (floor % 2 != 0)
                apartmentNumber -= 3;
            if (apartmentNumber > 0)
                floor++;
        }

        return floor;
    }
}