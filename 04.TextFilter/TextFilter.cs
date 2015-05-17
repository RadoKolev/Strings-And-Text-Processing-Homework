using System;

class TextFilter
{
    static void Main()
    {
        Console.WriteLine("Please enter your ban list:");
        string[] banList = Console.ReadLine().Split(new char[] { ',', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine();
        Console.WriteLine("Please enter your text:");
        string text = Console.ReadLine();

        foreach (var banWord in banList)
        {
            text = text.Replace(banWord, new string('*', banWord.Length));
        }
        Console.WriteLine();
        Console.WriteLine("Your text with banned words is:");
        Console.WriteLine(text);
    }
}