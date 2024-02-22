using System;

class Program
{
    static void Main()
    {
        string input = "This is a string with several words, the last of which contains several 'k' letters";

        int count = CountKInLastWord(input);

        Console.WriteLine($"The number of 'k' letters in the last word: {count}");
    }

    static int CountKInLastWord(string input)
    {
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string lastWord = words[words.Length - 1];

        int count = 0;
        foreach (char c in lastWord)
        {
            if (c == 'k' || c == 'K')
            {
                count++;
            }
        }

        return count;
    }
}