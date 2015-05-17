using System;

class CountSubstring
{
    private static int _times;

    static void Main()
    {
        Console.WriteLine("Please enter your text: ");
        string text = Console.ReadLine();
        Console.Write("Please enter the search word: ");
        string word = Console.ReadLine();

        int index = text.IndexOf(word);
        int times = 0;
        while (index >= 0 && index <= text.Length)
        {
            index = text.IndexOf(word, index + 1);
            times++;
        }
        Console.WriteLine(times);
    }
}